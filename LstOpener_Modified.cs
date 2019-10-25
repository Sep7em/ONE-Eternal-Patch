//! \file       LstOpener_Modified.cs
//! \date       Tue Oct 22 23:26:00 2019
//! \brief      Modified LstOpener
//
// Copyright (C) 2014-2015 by morkt
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
// IN THE SOFTWARE.
//

using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Text;
using GameRes;

namespace ONE_Eternal_Patch
{
    //Class for each element
    internal class NextonEntry : Entry
    {
        public byte Key;
    }

    //Classe for the archive
    //We make sure to use an ArchiveFormat
    [Export(typeof(ArchiveFormat))]
    public class LstOpener : ArchiveFormat
    {
        public override string Tag { get { return "LST"; } }
        public override string Description { get { return "Nexton LikeC engine resource archive"; } }
        public override uint Signature { get { return 0; } }
        public override bool IsHierarchic { get { return false; } } //doesn't have a sub directory
        public override bool CanWrite { get { return false; } }

        public LstOpener()
        {
            Extensions = new string[] { "" };
        }

        public override ArcFile TryOpen(ArcView file)
        {
            string lstname = file.Name + ".lst"; //we find the name of the file with the name of the original file
            if (!VFS.FileExists(lstname))
                return null;
            using (var lst = VFS.OpenView(lstname)) //lst is a view on the file lst that is created with the name of the file of the view
            {
                List<Entry> dir = null;
                try
                {
                    dir = OpenMoon(lst, file.MaxOffset);
                }
                catch { /* ignore parse errors */ }
                if (null == dir)
                    dir = OpenNexton(lst, file.MaxOffset);
                if (null == dir)
                    return null;
                return new ArcFile(file, this, dir);
            }
        }

        private List<Entry> OpenMoon(ArcView lst, long max_offset)
        {
            int count = (int)(lst.View.ReadUInt32(0) ^ 0xcccccccc);
            if (count <= 0 || (4 + count * 0x2c) > lst.MaxOffset) //the two conditions are valid when we try to open ONE
                return null;
            var cp932 = Encodings.cp932.WithFatalFallback();
            var dir = new List<Entry>(count);
            uint index_offset = 4;
            for (int i = 0; i < count; ++i)
            {
                string name = ReadName(lst, index_offset + 8, 0x24, 0xcc, cp932);
                if (0 == name.Length)
                    return null;
                var entry = FormatCatalog.Instance.Create<Entry>(name);
                entry.Offset = lst.View.ReadUInt32(index_offset) ^ 0xcccccccc;
                entry.Size = lst.View.ReadUInt32(index_offset + 4) ^ 0xcccccccc;
                if (!entry.CheckPlacement(max_offset))
                    return null;
                dir.Add(entry);
                index_offset += 0x2c;
            }
            return dir;
        }

        static string[] TypeExt = new string[] { "LST", "SNX", "BMP", "PNG", "WAV", "OGG" };

        //with the view on the lst file and the size of the original file, this function returns a list of entries of all the files
        //each entry has a name, an offset, a size and a key
        private List<Entry> OpenNexton(ArcView lst, long max_offset)
        {
            uint key = lst.View.ReadByte(3); // guess xor key, in our case it's 01, be careful, it's the 4th byte in the file (since we start at 0)
            if (0 == key)
                return null;
            //The first operation takes the key, convert it into binary, move the bits to 8 positions towards the left and make a binary OR with the first key, I've put some examples
            //this allows the key to be on 32 bits instead of 8 (the program uses a lot of 32 bits functions)
            key |= key << 8; //1 => 257, 0001 => 0001 0000 0001
            key |= key << 16; //257 => 16 843 009
            //here count is equal to the number of files in the archive
            int count = (int)(lst.View.ReadUInt32(0) ^ key); //^ is an exclusif or, 0101 ^ 0011 = 0110
            if (count <= 0 || (4 + count * 0x4c) > lst.MaxOffset) //0x4C is the hexadecimal value 4C
                return null;
            var cp932 = Encodings.cp932.WithFatalFallback(); //cp932 is the encoding for the Japanese characters
            var dir = new List<Entry>(count);
            uint index_offset = 4;
            //For each file/entry
            for (int i = 0; i < count; ++i)
            {
                string name = ReadName(lst, index_offset + 8, 0x40, (byte)key, cp932);
                if (0 == name.Length)
                    return null;
                var entry = new NextonEntry
                {
                    Name = name,
                    Offset = lst.View.ReadUInt32(index_offset) ^ key,
                    Size = lst.View.ReadUInt32(index_offset + 4) ^ key,
                };
                if (!entry.CheckPlacement(max_offset))
                    return null;
                int type = lst.View.ReadInt32(index_offset + 0x48);
                if (type >= 0 && type < TypeExt.Length)
                {
                    entry.Name = Path.ChangeExtension(name, TypeExt[type]);
                    if (2 == type || 3 == type)
                        entry.Type = "image";
                    else if (4 == type || 5 == type)
                        entry.Type = "audio";
                    else if (1 == type)
                    {
                        entry.Type = "script";
                        entry.Key = (byte)(key + 1);
                    }
                }
                dir.Add(entry);
                index_offset += 0x4c;
            }
            return dir;
        }

        public override Stream OpenEntry(ArcFile arc, Entry entry)
        {
            var nxent = entry as NextonEntry;
            if (null == nxent || 0 == nxent.Key)
                return arc.File.CreateStream(entry.Offset, entry.Size);
            var data = arc.File.View.ReadBytes(entry.Offset, entry.Size);
            for (int i = 0; i != data.Length; ++i)
                data[i] ^= nxent.Key;
            return new BinMemoryStream(data, entry.Name);
        }

        //The first name starts at the byte number 12 (value 40 for ONE) and 64 bytes are reserved for this one
        //if the name is less than 64 bytes, the rest is filled with the 0 value.
        private static string ReadName(ArcView view, long offset, uint size, byte key, Encoding enc)
        {
            byte[] buffer = new byte[size];
            uint n;
            for (n = 0; n < size; ++n)
            {
                byte b = view.View.ReadByte(offset + n);
                if (0 == b)
                    break;
                if (b != key)
                    b ^= key;
                buffer[n] = b;
            }
            return enc.GetString(buffer, 0, (int)n); //n is the number of elements in the buffer/array
        }


        //Function that I have written.
        //The first name starts at the byte number 12 (value 40 for ONE) and 64 bytes are reserved for this one
        //if the name is less than 64 bytes, the rest is filled with the 0 value.
        public static byte[] WriteName(String name, uint size, byte key, Encoding enc)
        {
            byte[] buffer = new byte[64];
            byte[] bufferName = enc.GetBytes(name);
            
            uint n;
            for (n = 0; n < 64; ++n)
            {
                if (n < bufferName.Length && bufferName[n] != key) {
                    bufferName[n] ^= key;
                    buffer[n] = bufferName[n];
                }
                else if (n >= bufferName.Length) {
                    buffer[n] = 0;
                }
            }
            
            return buffer;
        }
    }
}
