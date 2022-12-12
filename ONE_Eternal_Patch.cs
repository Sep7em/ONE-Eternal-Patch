using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using GameRes;

namespace ONE_Eternal_Patch
{
    public class ONE_Eternal_Patch
    {
        private static string inputEdition;
        private static string inputLanguage;
        private static string inputBonusCG;
        private static string inputAAContent;

        public static void Patch(string edition, string language, string bonusCG, string aaContent, string path, RichTextBox richTextBox)
        {
            inputEdition = edition;
            inputLanguage = language;
            inputBonusCG = bonusCG;
            inputAAContent = aaContent;

            //////////////////////////////
            //EXTRACTING OF THE PATCH FILES
            //////////////////////////////
            //First, we create a view of the file that'll allow us to work on it, the file is still encrypted.
            ArcView originalFile = null;
            ArcView patchFile = null;
            try
            {
                patchFile = new ArcView("./ONE_Patch_Files");
            }
            catch (System.IO.FileNotFoundException e)
            {
                richTextBox.ForeColor = Color.Red;
                richTextBox.Text += "Error: the file \"ONE_Patch_Files\" was not found.\n" +
                    "Make sure to place it in the same directory as the executable.\n\n" +
                    "Error details: " + e; ;
                return;
            }
            catch (System.UnauthorizedAccessException e)
            {
                richTextBox.ForeColor = Color.Red;
                richTextBox.Text += "Error: the file \"ONE_Patch_Files\" can't be accessed.\n" +
                    "Make sure that the file and the current folder are not in read only access.\n\n" +
                    "Error details: " + e;
                return;
            }
            catch (Exception e)
            {
                richTextBox.ForeColor = Color.Red;
                richTextBox.Text += e.Message;
                return;
            }

            LstOpener lst = new LstOpener();
            List<Entry> resultFilesList = new List<Entry>();
            ArcFile arcOriginalFiles = null;
            ArcFile arcPatchFiles = null;
            ArchiveFileSystem afsOriginalFiles = null;
            ArchiveFileSystem afsPatchFiles = null;

            try
            {
                //then, we want to get the encrypted file with the LstOpener
                //the arcfile is composed of the view on the original file, of an instance of LstOpener used to determinate the format
                //and of a list of all the files/entries with their names, type, offset and size
                arcPatchFiles = lst.TryOpen(patchFile);
            }
            catch (System.UnauthorizedAccessException e)
            {
                richTextBox.ForeColor = Color.Red;
                richTextBox.Text += "Error: the file \"ONE_Patch_Files.lst\" can't be accessed.\n" +
                    "Make sure that the file and the current folder are not in read only access.\n\n" +
                    "Error details: " + e;
                return;
            }
            catch (Exception e)
            {
                richTextBox.ForeColor = Color.Red;
                richTextBox.Text += e.Message;
                return;
            }


            try
            {
                //create a dictionary of data where the key is equal to the name of the entry and where the content is equal to the current entry
                afsPatchFiles = arcPatchFiles.CreateFileSystem();
            }
            catch (System.NullReferenceException e)
            {
                richTextBox.ForeColor = Color.Red;
                richTextBox.Text += "Error: the file \"ONE_Patch_Files.lst\" was not found.\n" +
                    "Make sure to place it in the same directory as the executable.\n\n" +
                    "Error details: " + e;
                return;
            }
            catch (Exception e)
            {
                richTextBox.ForeColor = Color.Red;
                richTextBox.Text += e.Message;
                return;
            }

            List<Entry> patchFilesList = new List<Entry>();

            Files_Lists.InitializeLists(out List<Entry> patchSNXFilesList, out List<Entry> patchIMGFilesList, afsPatchFiles, inputEdition, inputLanguage, inputBonusCG, inputAAContent);

            List<String> prefixList = new List<String> { "FV_OG_JP_", "FV_OG_EN_", "FV_OG_SP_", "FV_OG_CH_", "FV_OG_",
            "FV_BCG_AA_JP_", "FV_BCG_AA_EN_", "FV_BCG_AA_SP_", "FV_BCG_AA_CH_", "FV_BCG_AA_",
            "FV_BCG_JP_", "FV_BCG_EN_", "FV_BCG_SP_", "FV_BCG_CH_", "FV_BCG_",
            "FV_AA_JP_", "FV_AA_EN_", "FV_AA_SP_", "FV_AA_CH_", "FV_AA_",
            "VI_OG_JP_", "VI_OG_EN_", "VI_OG_",
            "VI_BCG_AA_JP_", "VI_BCG_AA_EN_", "VI_BCG_AA_",
            "VI_BCG_JP_", "VI_BCG_EN_", "VI_BCG_",
            "VI_AA_JP_", "VI_AA_EN_", "VI_AA_",
            "OG_JP_", "OG_EN_", "OG_SP_", "OG_CH_", "OG_",
            "BCG_AA_JP_", "BCG_AA_EN_", "BCG_AA_SP_", "BCG_AA_CH_",
            "BCG_JP_", "BCG_EN_", "BCG_SP_", "BCG_CH_", "BCG_",
            "AA_JP_", "AA_EN_", "AA_SP_", "AA_CH_", "AA_" };

            //Removing of the prefixes
            for (int j = 0; j < patchSNXFilesList.Count; j++)
            {
                string filename = ((Entry)patchSNXFilesList.ToArray()[j]).Name;
                foreach (String prefix in prefixList)
                {
                    //Remove the prefix of the name of the files
                    if (filename.StartsWith(prefix))
                    {
                        ((Entry)patchSNXFilesList.ToArray()[j]).Name = filename.Replace(prefix, "");
                        break;
                    }
                }
            }

            for (int j = 0; j < patchIMGFilesList.Count; j++)
            {
                string filename = ((Entry)patchIMGFilesList.ToArray()[j]).Name;
                foreach (String prefix in prefixList)
                {
                    //Remove the prefix of the name of the files
                    if (filename.StartsWith(prefix))
                    {
                        ((Entry)patchIMGFilesList.ToArray()[j]).Name = filename.Replace(prefix, "");
                        break;
                    }
                }
            }

            IOrderedEnumerable<Entry> sortedSNX;
            IOrderedEnumerable<Entry> sortedIMG;
            //Full Voice Edition: sorting of the list by Windows alphabetical order ("_" => "0...9" => "A...Z")
            if (inputEdition.Substring(0, 1) == "1")
            {
                sortedSNX = patchSNXFilesList.OrderBy(f => f.Name);
                sortedIMG = patchIMGFilesList.OrderBy(f => f.Name);
            }
            //Vista Edition: the list must be sorted in the unconventional order "0...9" => "_" => "A...Z"
            //Since all the file names are in upper case, we can just use the Ordinal order with the names in lower case
            else
            {
                sortedSNX = patchSNXFilesList.OrderBy(f => f.Name.ToLower(), StringComparer.Ordinal);
                sortedIMG = patchIMGFilesList.OrderBy(f => f.Name.ToLower(), StringComparer.Ordinal);
            }

            //The list is then sorted by type
            patchFilesList.AddRange(sortedSNX);
            patchFilesList.AddRange(sortedIMG);

            //In the Chinese version, the SNX and IMG files are mixed together
            if (inputLanguage.Substring(0, 1) == "4")
            {
                patchFilesList = patchFilesList.OrderBy(f => f.Name).ToList();
            }


            //This file only exists in the English translated version and is placed at the end of the archive for some reasons.
            //I'm pretty sure it's a mistake of the TL team but I prefer to update it, just in case.
            if (inputLanguage.Substring(0, 1) == "2")
            {
                if (inputAAContent.Substring(0, 1) == "1" && inputBonusCG.Substring(0, 1) == "1")
                {
                    patchFilesList.Add(afsPatchFiles.FindFile("BCG_AA_EN_CGMODEAKMU.PNG"));
                }
                else if (inputAAContent.Substring(0, 1) == "1" && inputBonusCG.Substring(0, 1) == "2")
                {
                    patchFilesList.Add(afsPatchFiles.FindFile("AA_EN_CGMODEAKMU.PNG"));
                }
                else if (inputAAContent.Substring(0, 1) == "2" && inputBonusCG.Substring(0, 1) == "1")
                {
                    patchFilesList.Add(afsPatchFiles.FindFile("BCG_EN_CGMODEAKMU.PNG"));
                }
                else if (inputAAContent.Substring(0, 1) == "2" && inputBonusCG.Substring(0, 1) == "2")
                {
                    patchFilesList.Add(afsPatchFiles.FindFile("OG_EN_CGMODEAKMU.PNG"));
                }

                patchFilesList.Last().Name = "CGMODEAKMU.PNG";
            }

            List<String> filesListToNotUpdate = new List<String> { "BG400.PNG", "FGAK17.PNG", "FGAK18.PNG",
            "FGMI17.PNG", "FGMI18.PNG", "FGMI19.PNG", "FGMS18.PNG", "FGMS19.PNG", "FGMY16.PNG", "FGMY17.PNG",
            "FGMZ17.PNG", "FGMZ18.PNG", "FGRM16.PNG", "FGRM17.PNG", "FGRM18.PNG" };

            //In the case of the Spanish translated version, the files are outside of the archive instead of being inside of it
            //The writing of the files is thus much simpler than the rest and is contained in the if condition bellow
            if (inputLanguage.Substring(0, 1) == "3")
            {
                List<String> filesListToDelete = new List<String> { "CGMODEAK.SNX", "CGMODEMO.SNX", "CGMODEMS.SNX",
                "CGMODEMU.SNX", "CGMODEMZ.SNX", "CGMODENN.SNX", "FGAK12.PNG", "FGAK13.PNG", "FGAK14.PNG", "FGAK15.PNG",
                "FGMI03.PNG", "FGMI04.PNG", "FGMI05.PNG", "FGMI06.PNG", "FGMS07.PNG", "FGMS08.PNG", "FGMS09.PNG",
                "FGMS10.PNG", "FGMY11.PNG", "FGMY12.PNG", "FGMY13.PNG", "FGMY14.PNG", "FGMZ12.PNG", "FGMZ13.PNG",
                "FGMZ14.PNG", "FGMZ15.PNG", "FGRM07.PNG", "FGRM12.PNG", "FGRM13.PNG", "FGRM14.PNG", "FGRM15.PNG" };
                filesListToDelete.AddRange(filesListToNotUpdate);

                //Delete the files that might not be used to have a clean directory
                foreach (string fileName in filesListToDelete)
                {
                    if (File.Exists(path + fileName))
                    {
                        richTextBox.Text += fileName + " will be deleted.\n";
                        File.Delete(path + fileName);
                    }
                }

                foreach (Entry entry in patchFilesList)
                {
                    if (File.Exists(path + entry.Name))
                    {
                        richTextBox.Text += entry.Name + " will be updated.\n";
                    }
                    else
                    {
                        richTextBox.Text += entry.Name + " will be inserted.\n";
                    }
                    var inputSpanishFile = arcPatchFiles.OpenEntry(entry);
                    var outputSpanishFile = File.Open(path + entry.Name, FileMode.Create);
                    inputSpanishFile.CopyTo(outputSpanishFile);
                    inputSpanishFile.Close();
                    outputSpanishFile.Close();
                }

                richTextBox.Text += "\nDone!";
                richTextBox.Text += "\nPress any key to continue.";
                
                return;
            }

            //////////////////////////////
            //EXTRACTING OF THE ORIGINAL FILES
            //////////////////////////////
            string originalFileName = inputEdition.Substring(0, 1) == "1" ? inputLanguage.Substring(0, 1) != "4" ? "one" : "one_cn" : "lcsebody1";
            try
            {
                originalFile = new ArcView(path + originalFileName);
            }
            catch (System.IO.FileNotFoundException e)
            {
                richTextBox.ForeColor = Color.Red;
                richTextBox.Text += "Error: the file \"" + originalFileName + "\" was not found.\n" +
                    "Make sure to place it in the same directory as the executable.\n\n" +
                    "Error details: " + e;
                return;
            }
            catch (System.UnauthorizedAccessException e)
            {
                richTextBox.ForeColor = Color.Red;
                richTextBox.Text += "Error: the file \"" + originalFileName + "\" can't be accessed.\n" +
                    "Make sure that the file and the current folder are not in read only access.\n\n" +
                    "Error details: " + e;
                return;
            }
            catch (Exception e)
            {
                richTextBox.ForeColor = Color.Red;
                richTextBox.Text += e.Message;
                return;
            }

            try
            {
                arcOriginalFiles = lst.TryOpen(originalFile);
            }
            catch (System.UnauthorizedAccessException e)
            {
                richTextBox.ForeColor = Color.Red;
                richTextBox.Text += "Error: the file \"" + originalFileName + ".lst\" can't be accessed.\n" +
                    "Make sure that the file and the current folder are not in read only access.\n\n" +
                    "Error details: " + e;
                return;
            }
            catch (Exception e)
            {
                richTextBox.ForeColor = Color.Red;
                richTextBox.Text += e.Message;
                return;
            }
            try
            {
                afsOriginalFiles = arcOriginalFiles.CreateFileSystem();
            }
            catch (System.NullReferenceException e)
            {
                richTextBox.ForeColor = Color.Red;
                richTextBox.Text += "Error: the file \"" + originalFileName + ".lst\" was not found.\n" +
                    "Make sure to place it in the same directory as the executable.\n\n" +
                    "Error details: " + e;
                return;
            }
            catch (Exception e)
            {
                richTextBox.ForeColor = Color.Red;
                richTextBox.Text += e.Message;
                return;
            }


            List<Entry> originalFilesList = new List<Entry>();
            originalFilesList = (List<Entry>)afsOriginalFiles.GetFiles();

            int i = 0;
            foreach (Entry entry in originalFilesList)
            {
                //In the Vista Edition, the first entry of the archive is NECEMEM.SNX
                //It's a very particular file that will propably never been updated by the patch so we add it and skip to the next file
                if (inputEdition.Substring(0, 1) == "2" && i == 0 && entry.Name.Equals("NECEMEM.SNX"))
                {
                    resultFilesList.Add(entry);
                    continue;
                }

                String fileName = string.Empty;
                if (patchFilesList.ToArray().Length > i)
                {
                    fileName = ((Entry)patchFilesList.ToArray()[i]).Name;
                }

                //Skip the bonus CGs if the user doesn't want them
                if (inputBonusCG.Substring(0, 1) == "2" && filesListToNotUpdate.Any(entry.Name.Contains))
                {
                    continue;
                }

                //Update
                if (patchFilesList.ToArray().Length > i &&
                    entry.Name.Equals(fileName))
                {
                    resultFilesList.Add((Entry)patchFilesList.ToArray()[i]);
                    richTextBox.Text += fileName + " will be updated.\n";
                    i++;
                }
                //Insert new file(s) and the current original file
                else if (patchFilesList.ToArray().Length > i &&
                    entry.Type.Equals(((Entry)patchFilesList.ToArray()[i]).Type) &&
                    String.Compare(entry.Name, fileName) > 0)
                {

                    while (patchFilesList.ToArray().Length > i &&
                        entry.Type.Equals(((Entry)patchFilesList.ToArray()[i]).Type) &&
                        String.Compare(entry.Name, fileName) > 0 &&
                        !fileName.Equals("CGMODEAKMU.PNG"))
                    {

                        resultFilesList.Add((Entry)patchFilesList.ToArray()[i]);
                        richTextBox.Text += fileName + " will be inserted.\n";
                        i++;

                        if (patchFilesList.ToArray().Length > i)
                        {
                            fileName = ((Entry)patchFilesList.ToArray()[i]).Name;
                        }
                    }

                    resultFilesList.Add(entry);
                }
                //Insert the current original file
                else
                {
                    resultFilesList.Add(entry);
                }
            }


            ////////////////////
            //WRITING PART
            ////////////////////
            richTextBox.Text += "Writing...\n";
            
            var cp932 = Encodings.cp932.WithFatalFallback(); //cp932 is the encoding for the Japanese characters
            var nbFiles = resultFilesList.ToArray().Length; //count the number of files

            //The file one_TEMP will be written directly into binary
            BinaryWriter bw = null;
            bw = new BinaryWriter(File.Create("./one_TEMP.lst"));
            Boolean headerWritten = false;
            long offset = 0;

            //The key is always equal to 01 in hexa (at least for ONE), it's possible to change it without any impact but I don't see the point to do it
            var key = 0x01;
            var convertedKey = key;

            //The first operation takes the key, convert it into binary, move the bits to 8 positions towards the left and make a binary OR with the first key, I've put some examples
            //This allows the key to be on 32 bits instead of 8 (the program uses a lot of 32 bits functions)
            convertedKey |= convertedKey << 8; //1 => 257, 0001 => 0000 0001 0000 0001
            convertedKey |= convertedKey << 16; //257 => 16 843 009 => 0001 0001 0001 0001

            //This key is used to encrypt the SNX files, it's always equal to 02
            //We only need the key to be on 8 bits so we don't do a conversion
            var keySNX = 0x02;

            //This part is used to initialize the variables used to read the one_TEMP file
            Stream stream = null;
            var output = PhysicalFileSystem.CreateFile("./one_TEMP");

            //Loop that will treat each file, it's going to insert an entry into the one_TEMP.lst file and then insert it into the one_TEMP file afterwards
            foreach (Entry entry in resultFilesList)
            {
                //We start with the transformation of the data
                String fileName = entry.Name;
                int pointPosition = fileName.IndexOf(".");
                String extension = fileName.Substring(pointPosition + 1, fileName.Length - pointPosition - 1);

                byte[] bufferName = LstOpener.WriteName(fileName.Substring(0, pointPosition), 64, (byte)key, cp932);
                long fileSize = entry.Size ^ convertedKey;
                long convertedOffset = offset ^ convertedKey;
                offset += entry.Size;

                //Type is the only part that is not encrypted with the key
                int type = 0;
                if (extension.Equals("SNX"))
                {
                    type = 1;
                }
                else if (extension.Equals("BMP"))
                {
                    type = 2;
                }
                else if (extension.Equals("PNG"))
                {
                    type = 3;
                }
                else if (extension.Equals("WAV"))
                {
                    type = 4;
                }
                else if (extension.Equals("OGG"))
                {
                    type = 5;
                }
                else
                {
                    type = -1;
                }

                //Byte writing in the lst file
                //Writing of the header
                if (!headerWritten)
                {
                    //The header corresponds to the 4 first bytes of the files, it indicates the number of files and the key (4th bytes)
                    var header = nbFiles ^ convertedKey;
                    bw.Write(header);
                    headerWritten = true;
                }
                bw.Write((int)convertedOffset);
                bw.Write((int)fileSize);
                bw.Write(bufferName);
                bw.Write(type);

                //Creation of the file into the one file
                //These two conditions are used to determinate if the current file comes from the original files or the patch files
                if (patchFilesList.Exists(file => file.Name == entry.Name))
                {
                    stream = arcPatchFiles.OpenEntry(entry);
                }
                else if (afsOriginalFiles.FileExists(entry.Name))
                {
                    stream = arcOriginalFiles.OpenEntry(entry);
                }

                int byteTempo = 0;
                //The SNX files need to be written byte by byte, indeed, we need to transform them because they're encrypted in the one file with a XOR key 02 to make sure that nobody can read them
                if (type == 1)
                {
                    while ((byteTempo = stream.ReadByte()) > -1)
                    {
                        byteTempo ^= keySNX;
                        output.WriteByte((byte)byteTempo); //we directly write the bytes into the file without using the stream
                    }
                }
                else
                {
                    stream.CopyTo(output);
                }

                stream.Dispose();
            }

            //The original Japanese Full Voice Edition ends with 48 bytes corresponding to the end of a PNG file.
            //It's not the case for the English translation or the Vista Edition, it doesn't seem to have an impact in the game and it's very probably a mistake since the last file is also a PNG file (the value is duplicated).
            //However, I prefer to put it in order to have a faithful recreation of the file.
            if (inputEdition.Substring(0, 1) == "1" && inputLanguage.Substring(0, 1) == "1")
            {
                List<byte> listByteFinFichier = new List<byte> { 0xa4, 0x01, 0xcc, 0x9c, 0x72, 0x05, 0x0c, 0x0c, 0x33,
                0x01, 0x47, 0x00, 0x8f, 0x07, 0xef, 0x9f, 0xce, 0xaa, 0x0a, 0x60, 0xb8, 0x6e, 0x5e, 0x0c, 0x7e, 0x0b,
                0x30, 0x00, 0xf1, 0x70, 0xc4, 0x43, 0x75, 0x7e, 0x8f, 0x0a, 0x00, 0x00, 0x00, 0x00, 0x49, 0x45, 0x4e,
                0x44, 0xae, 0x42, 0x60, 0x82 };

                foreach (byte b in listByteFinFichier)
                {
                    output.WriteByte(b);
                }
            }

            bw.Close();
            output.Close();
            output.Dispose();
            originalFile.Dispose();
            patchFile.Dispose();

            //At the end, we replace the original files with the files that we have created.
            File.SetAttributes(originalFile.Name, FileAttributes.Normal);
            File.SetAttributes(originalFile.Name + ".lst", FileAttributes.Normal);

            File.Delete(originalFile.Name);
            File.Delete(originalFile.Name + ".lst");

            File.Move("one_TEMP", originalFile.Name);
            File.Move("one_TEMP.lst", originalFile.Name + ".lst");

            richTextBox.Text += "\nDone!";
        }
    }
}
