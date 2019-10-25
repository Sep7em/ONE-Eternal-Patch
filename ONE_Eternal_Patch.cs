using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using GameRes;

namespace ONE_Eternal_Patch
{
    class ONE_Eternal_Patch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ONE Eternal Patch v1.0");
            Console.WriteLine("developed by Sep7\n");

            //////////
            //INPUTS
            //////////
            string inputLanguage = "";
            do
            {
                Console.WriteLine("Enter 1 if you want to patch the Japanese Version.");
                Console.WriteLine("Enter 2 if you want to patch the English translated Version.");

                inputLanguage = Console.ReadLine();

                if (inputLanguage.Length != 1 || (inputLanguage.Substring(0, 1) != "1" && inputLanguage.Substring(0, 1) != "2"))
                {
                    Console.WriteLine("Syntax Error.\n");
                }
            } while (inputLanguage.Length != 1 || (inputLanguage.Substring(0, 1) != "1" && inputLanguage.Substring(0, 1) != "2"));

            string inputBonusCG = "";
            do
            {
                Console.WriteLine("\nEnter 1 if you want to add the bonus CGs.");
                Console.WriteLine("Enter 2 if you want to remove them.");

                inputBonusCG = Console.ReadLine();

                if (inputBonusCG.Length != 1 || (inputBonusCG.Substring(0, 1) != "1" && inputBonusCG.Substring(0, 1) != "2"))
                {
                    Console.WriteLine("Syntax Error.");
                }
            } while (inputBonusCG.Length != 1 || (inputBonusCG.Substring(0, 1) != "1" && inputBonusCG.Substring(0, 1) != "2"));

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
                Console.WriteLine("\nError: the file \"ONE_Patch_Files\" was not found.\n" +
                    "Make sure to place it in the same directory as the executable.\n\n" +
                    "Error details: " + e +
                    "\n\nPress any key to continue.");
                Console.ReadKey(true);
                System.Environment.Exit(1);
            }
            catch (System.UnauthorizedAccessException e)
            {
                Console.WriteLine("\nError: the file \"ONE_Patch_Files\" can't be accessed.\n" +
                    "Make sure that the file and the current folder are not in read only access.\n\n" +
                    "Error details: " + e +
                    "\n\nPress any key to continue.");
                Console.ReadKey(true);
                System.Environment.Exit(1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadKey(true);
                System.Environment.Exit(1);
            }

            LstOpener lst = new LstOpener();
            List<Entry> resultFilesList = new List<Entry>();
            ArcFile arcOriginalFiles = null;
            ArcFile arcPatchFiles = null;
            ArchiveFileSystem afsOriginalFiles = null;
            ArchiveFileSystem afsPatchFiles = null;
            String suffix = "";

            try
            {
                //then, we want to get the encrypted file with the LstOpener
                //the arcfile is composed of the view on the original file, of an instance of LstOpener used to determinate the format
                //and of a list of all the files/entries with their names, type, offset and size
                arcPatchFiles = lst.TryOpen(patchFile);
            }
            catch (System.UnauthorizedAccessException e)
            {
                Console.WriteLine("\nError: the file \"ONE_Patch_Files.lst\" can't be accessed.\n" +
                    "Make sure that the file and the current folder are not in read only access.\n\n" +
                    "Error details: " + e +
                    "\n\nPress any key to continue.");
                Console.ReadKey(true);
                System.Environment.Exit(1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadKey(true);
                System.Environment.Exit(1);
            }


            try
            {
                //create a dictionary of data where the key is equal to the name of the entry and where the content is equal to the current entry
                afsPatchFiles = arcPatchFiles.CreateFileSystem();
            }
            catch (System.NullReferenceException e)
            {
                Console.WriteLine("\nError: the file \"ONE_Patch_Files.lst\" was not found.\n" +
                    "Make sure to place it in the same directory as the executable.\n\n" +
                    "Error details: " + e +
                    "\n\nPress any key to continue.");
                Console.ReadKey(true);
                System.Environment.Exit(1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadKey(true);
                System.Environment.Exit(1);
            }

            List<Entry> patchFilesList = new List<Entry>();

            //Remove the Bonus CGs in the Japanese version
            if (inputBonusCG.Substring(0, 1) == "2" && inputLanguage.Substring(0, 1) == "1")
            {
                suffix = "_JAP";
            }
            //Remove the Bonus CGs in the English version
            else if (inputBonusCG.Substring(0, 1) == "2" && inputLanguage.Substring(0, 1) == "2")
            {
                suffix = "_ENG";
            }
            //Add the Bonus CGs in the Japanese version
            else if (inputBonusCG.Substring(0, 1) == "1" && inputLanguage.Substring(0, 1) == "1")
            {
                suffix = "_JAPBCG";
            }
            //Add the Bonus CGs in the English version
            else
            {
                suffix = "_ENGBCG";
            }

            //Scripts
            patchFilesList.Add(afsPatchFiles.FindFile("AK26" + suffix + ".SNX"));
            patchFilesList.Add(afsPatchFiles.FindFile("CGMODEAK" + suffix + ".SNX"));
            patchFilesList.Add(afsPatchFiles.FindFile("CGMODEMO" + suffix + ".SNX"));
            patchFilesList.Add(afsPatchFiles.FindFile("CGMODEMS" + suffix + ".SNX"));
            patchFilesList.Add(afsPatchFiles.FindFile("CGMODEMU" + suffix + ".SNX"));
            patchFilesList.Add(afsPatchFiles.FindFile("CGMODEMZ" + suffix + ".SNX"));
            patchFilesList.Add(afsPatchFiles.FindFile("CGMODENN" + suffix + ".SNX"));
            patchFilesList.Add(afsPatchFiles.FindFile("DS01" + suffix + ".SNX"));
            patchFilesList.Add(afsPatchFiles.FindFile("DS05" + suffix + ".SNX"));
            patchFilesList.Add(afsPatchFiles.FindFile("DS07" + suffix + ".SNX"));
            patchFilesList.Add(afsPatchFiles.FindFile("DS09" + suffix + ".SNX"));
            patchFilesList.Add(afsPatchFiles.FindFile("DS10_A" + suffix + ".SNX"));
            patchFilesList.Add(afsPatchFiles.FindFile("DS19" + suffix + ".SNX"));
            patchFilesList.Add(afsPatchFiles.FindFile("MS22" + suffix + ".SNX"));
            patchFilesList.Add(afsPatchFiles.FindFile("MS25" + suffix + ".SNX"));
            patchFilesList.Add(afsPatchFiles.FindFile("MS27" + suffix + ".SNX"));
            patchFilesList.Add(afsPatchFiles.FindFile("MY24" + suffix + ".SNX"));
            patchFilesList.Add(afsPatchFiles.FindFile("NV30" + suffix + ".SNX"));
            patchFilesList.Add(afsPatchFiles.FindFile("RM24" + suffix + ".SNX"));
            patchFilesList.Add(afsPatchFiles.FindFile("SBD25N1" + suffix + ".SNX"));
            patchFilesList.Add(afsPatchFiles.FindFile("SBRM14N1" + suffix + ".SNX"));
            patchFilesList.Add(afsPatchFiles.FindFile("SBRM17M1" + suffix + ".SNX"));

            //PNGs
            if (inputBonusCG.Substring(0, 1) == "1")
            {
                patchFilesList.Add(afsPatchFiles.FindFile("BG400.PNG"));
            }

            patchFilesList.Add(afsPatchFiles.FindFile("CGMODEAKBK" + suffix + ".PNG"));
            patchFilesList.Add(afsPatchFiles.FindFile("CGMODEAKCHIP" + suffix + ".PNG"));
            patchFilesList.Add(afsPatchFiles.FindFile("CGMODEMOBK" + suffix + ".PNG"));
            patchFilesList.Add(afsPatchFiles.FindFile("CGMODEMOCHIP" + suffix + ".PNG"));
            patchFilesList.Add(afsPatchFiles.FindFile("CGMODEMSBK" + suffix + ".PNG"));
            patchFilesList.Add(afsPatchFiles.FindFile("CGMODEMSCHIP" + suffix + ".PNG"));
            patchFilesList.Add(afsPatchFiles.FindFile("CGMODEMUBK" + suffix + ".PNG"));
            patchFilesList.Add(afsPatchFiles.FindFile("CGMODEMUCHIP" + suffix + ".PNG"));
            patchFilesList.Add(afsPatchFiles.FindFile("CGMODEMZBK" + suffix + ".PNG"));
            patchFilesList.Add(afsPatchFiles.FindFile("CGMODEMZCHIP" + suffix + ".PNG"));
            patchFilesList.Add(afsPatchFiles.FindFile("CGMODENNBK" + suffix + ".PNG"));
            patchFilesList.Add(afsPatchFiles.FindFile("CGMODENNCHIP" + suffix + ".PNG"));

            if (inputBonusCG.Substring(0, 1) == "1")
            {
                patchFilesList.Add(afsPatchFiles.FindFile("FGAK17.PNG"));
                patchFilesList.Add(afsPatchFiles.FindFile("FGAK18.PNG"));
                patchFilesList.Add(afsPatchFiles.FindFile("FGMI17.PNG"));
                patchFilesList.Add(afsPatchFiles.FindFile("FGMI18.PNG"));
                patchFilesList.Add(afsPatchFiles.FindFile("FGMI19.PNG"));
                patchFilesList.Add(afsPatchFiles.FindFile("FGMS18.PNG"));
                patchFilesList.Add(afsPatchFiles.FindFile("FGMS19.PNG"));
                patchFilesList.Add(afsPatchFiles.FindFile("FGMY16.PNG"));
                patchFilesList.Add(afsPatchFiles.FindFile("FGMY17.PNG"));
                patchFilesList.Add(afsPatchFiles.FindFile("FGMZ17.PNG"));
                patchFilesList.Add(afsPatchFiles.FindFile("FGMZ18.PNG"));
                patchFilesList.Add(afsPatchFiles.FindFile("FGRM16.PNG"));
                patchFilesList.Add(afsPatchFiles.FindFile("FGRM17.PNG"));
                patchFilesList.Add(afsPatchFiles.FindFile("FGRM18.PNG"));
            }

            //This file only exists in the English translated version and is placed at the end of the archive for some reasons.
            //I'm pretty sure it's a mistake of the TL team but I prefer to update it, just in case.
            if (inputLanguage.Substring(0, 1) == "2")
            {
                patchFilesList.Add(afsPatchFiles.FindFile("CGMODEAKMU" + suffix + ".PNG"));
            }

            List<String> filesListToNotUpdate = new List<String> { "BG400.PNG", "FGAK17.PNG", "FGAK18.PNG",
            "FGMI17.PNG", "FGMI18.PNG", "FGMI19.PNG", "FGMS18.PNG", "FGMS19.PNG", "FGMY16.PNG", "FGMY17.PNG",
            "FGMZ17.PNG", "FGMZ18.PNG", "FGRM16.PNG", "FGRM17.PNG", "FGRM18.PNG" };

            //////////////////////////////
            //EXTRACTING OF THE ORIGINAL FILES
            //////////////////////////////
            try
            {
                originalFile = new ArcView("./one");
            }
            catch (System.IO.FileNotFoundException e)
            {
                Console.WriteLine("\nError: the file \"one\" was not found.\n" +
                    "Make sure to place it in the same directory as the executable.\n\n" +
                    "Error details: " + e +
                    "\n\nPress any key to continue.");
                Console.ReadKey(true);
                System.Environment.Exit(1);
            }
            catch (System.UnauthorizedAccessException e)
            {
                Console.WriteLine("\nError: the file \"one\" can't be accessed.\n" +
                    "Make sure that the file and the current folder are not in read only access.\n\n" +
                    "Error details: " + e +
                    "\n\nPress any key to continue.");
                Console.ReadKey(true);
                System.Environment.Exit(1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadKey(true);
                System.Environment.Exit(1);
            }

            try
            {
                arcOriginalFiles = lst.TryOpen(originalFile);
            }
            catch (System.UnauthorizedAccessException e)
            {
                Console.WriteLine("\nError: the file \"one.lst\" can't be accessed.\n" +
                    "Make sure that the file and the current folder are not in read only access.\n\n" +
                    "Error details: " + e +
                    "\n\nPress any key to continue.");
                Console.ReadKey(true);
                System.Environment.Exit(1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadKey(true);
                System.Environment.Exit(1);
            }
            try
            {
                afsOriginalFiles = arcOriginalFiles.CreateFileSystem();
            }
            catch (System.NullReferenceException e)
            {
                Console.WriteLine("\nError: the file \"one.lst\" was not found.\n" +
                    "Make sure to place it in the same directory as the executable.\n\n" +
                    "Error details: " + e +
                    "\n\nPress any key to continue.");
                Console.ReadKey(true);
                System.Environment.Exit(1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadKey(true);
                System.Environment.Exit(1);
            }


            List<Entry> originalFilesList = new List<Entry>();
            originalFilesList = (List<Entry>)afsOriginalFiles.GetFiles();

            int i = 0;
            foreach (Entry entry in originalFilesList)
            {
                String fileName = "";
                //Updating the name of the file
                if (patchFilesList.ToArray().Length > i)
                {
                    fileName = ((Entry)patchFilesList.ToArray()[i]).Name;
                    //Remove the suffix of the name of the files
                    if (fileName.Contains(suffix))
                    {
                        fileName = fileName.Replace(suffix, "");
                    }
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
                    Console.WriteLine(fileName + " will be updated.");
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
                        Console.WriteLine(fileName + " will be inserted.");
                        i++;

                        //Updating the name of the file
                        if (patchFilesList.ToArray().Length > i)
                        {
                            fileName = ((Entry)patchFilesList.ToArray()[i]).Name;
                            //Remove the suffix of the name of the files
                            if (fileName.Contains(suffix))
                            {
                                fileName = fileName.Replace(suffix, "");
                            }
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
            Console.WriteLine("Writing...");

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

            //This key is used to encrypt the SNX files, she's always equal to 02
            //We only need the key to be on 8 bits so we don't do a conversion
            var keySNX = 0x02;

            //This part is used to initialize the variables used to read the one_TEMP file
            Stream stream = null;
            var output = PhysicalFileSystem.CreateFile("./one_TEMP");

            //Loop that will treat each file, it's going to insert an entry into the one_TEMP.lst file and then insert it into the one_TEMP file afterwards
            foreach (Entry entry in resultFilesList)
            {
                //We start with the transformation of the data
                //Remove the suffix of the name of the files
                String fileName = entry.Name;
                if (fileName.Contains(suffix))
                {
                    fileName = fileName.Replace(suffix, "");
                }
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
                    //The header corresponds to the 4 first bytes of the files, he indicates the number of files and the key (4th bytes)
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
                if (afsOriginalFiles.FileExists(entry.Name))
                {
                    stream = arcOriginalFiles.OpenEntry(entry);
                }
                else if (afsPatchFiles.FileExists(entry.Name))
                {
                    stream = arcPatchFiles.OpenEntry(entry);
                }

                int byteTempo = 0;
                //The SNX files need to be written byte by byte, indeed, we need to transform them because they're encrypted in the one file with a XOR key 02 to make sure that nobody can read them
                if (type == 1)
                {
                    while ((byteTempo = stream.ReadByte()) > -1)
                    {
                        byteTempo = byteTempo ^ keySNX;
                        output.WriteByte((byte)byteTempo); //we directly wrote the bytes into the file without using the stream
                    }
                }
                else
                {
                    stream.CopyTo(output);
                }

                stream.Dispose();
            }

            //The original Japanese version ends with 48 bytes corresponding to the end of a PNG file.
            //It's not the case for the English translation, it doesn't seem to have an impact in the game and it's very probably a mistake since the last file is also a PNG file (the value is duplicated).
            //However, I prefer to put it in order to have a faithful recreation of the file.
            if (inputLanguage.Substring(0, 1) == "1")
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
            File.SetAttributes("one", FileAttributes.Normal);
            File.SetAttributes("one.lst", FileAttributes.Normal);

            File.Delete("one");
            File.Delete("one.lst");

            File.Move("one_TEMP", "one");
            File.Move("one_TEMP.lst", "one.lst");

            Console.WriteLine("\nDone!");
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey(true);
        }
    }
}
