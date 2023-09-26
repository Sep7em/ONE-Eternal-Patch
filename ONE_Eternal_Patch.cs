using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using GameRes;
using ONE_Eternal_Patch_GUI;

namespace ONE_Eternal_Patch
{
    public class ONE_Eternal_Patch
    {
        public static void Patch(Edition edition, Language language, bool PS1Content, bool AAContent, bool miscContent, string path, RichTextBox richTextBox)
        {
            //////////////////////////////
            //EXTRACTION OF THE PATCH FILES
            //////////////////////////////
            //First, we create a view of the file that'll allow us to work on it, the file is still encrypted.
            ArcView originalFile = null;
            ArcView originalSNDFile = null;
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
            List<Entry> resultSNDFilesList = new List<Entry>();
            ArcFile arcOriginalFiles = null;
            ArcFile arcOriginalSNDFiles = null;
            ArcFile arcPatchFiles = null;
            ArchiveFileSystem afsOriginalFiles = null;
            ArchiveFileSystem afsOriginalSNDFiles = null;
            ArchiveFileSystem afsPatchFiles = null;

            try
            {
                //Then, we want to get the encrypted file with the LstOpener
                //The arcfile is composed of the view on the original file, of an instance of LstOpener used to determinate the format
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
                //Create a dictionary of data where the key is equal to the name of the entry and where the content is equal to the current entry
                afsPatchFiles = arcPatchFiles.CreateFileSystem();
            }
            catch (NullReferenceException e)
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

            Files_Lists.InitializeLists(out List<Entry> patchSNXFilesList, out List<Entry> patchIMGFilesList, out List<Entry> patchSNDFilesList, afsPatchFiles, edition, language, PS1Content, AAContent, miscContent);

            IOrderedEnumerable<Entry> sortedSNX;
            IOrderedEnumerable<Entry> sortedIMG;
            //Full Voice Edition: sorting of the list by Windows alphabetical order ("_" => "0...9" => "A...Z")
            if (edition == Edition.FV)
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

                //The first entry of the archive is NECEMEM.SNX in this edition
                if (!PS1Content)
                    patchFilesList.Add(afsPatchFiles.FindFile("VI_OG_NECEMEM.SNX"));
                else
                    patchFilesList.Add(afsPatchFiles.FindFile("VI_PS1_NECEMEM.SNX"));

                patchFilesList.Last().Name = "NECEMEM.SNX";
            }

            //The list is then sorted by type
            patchFilesList.AddRange(sortedSNX);
            patchFilesList.AddRange(sortedIMG);

            //In the Chinese version, the SNX and IMG files are mixed together
            if (language == Language.CH)
            {
                patchFilesList = patchFilesList.OrderBy(f => f.Name).ToList();
            }


            //This file only exists in the English translated version and is placed at the end of the archive for some reasons.
            //I'm pretty sure it's a mistake of the TL team but I prefer to update it, just in case.
            if (language == Language.EN)
            {
                if (AAContent && PS1Content)
                    patchFilesList.Add(afsPatchFiles.FindFile("PS1_AA_EN_CGMODEAKMU.PNG"));
                else if (AAContent && !PS1Content)
                    patchFilesList.Add(afsPatchFiles.FindFile("AA_EN_CGMODEAKMU.PNG"));
                else if (!AAContent && PS1Content)
                    patchFilesList.Add(afsPatchFiles.FindFile("PS1_EN_CGMODEAKMU.PNG"));
                else if (!AAContent && !PS1Content)
                    patchFilesList.Add(afsPatchFiles.FindFile("OG_EN_CGMODEAKMU.PNG"));

                patchFilesList.Last().Name = "CGMODEAKMU.PNG";
            }

            List<string> filesListToNotUpdate = new List<string> { "BG814.PNG", "CGMODENA.SNX", "NA18.SNX", "NA22.SNX",
                "NA24.SNX", "NA25.SNX", "NA27.SNX", "NAE.SNX", "BG400.PNG", "CGMODENABK.PNG", "CGMODENACHIP.PNG",
                "CGMODETOPMENUNA.PNG", "CGNA01.PNG", "CGNA01M.PNG", "CGNA02.PNG", "CGNA02M.PNG", "CGNA03.PNG", "CGNA03M.PNG",
                "CGNA04.PNG", "CGNA04M.PNG", "CGNA05.PNG", "CGNA05M.PNG", "FGAK17.PNG", "FGAK18.PNG", "FGMI17.PNG", "FGMI18.PNG",
                "FGMI19.PNG", "FGMS18.PNG", "FGMS19.PNG", "FGMY16.PNG", "FGMY17.PNG", "FGMZ17.PNG", "FGMZ18.PNG",
                "FGNA01A.PNG", "FGNA01B.PNG", "FGNA02.PNG", "FGNA03.PNG", "FGNA04.PNG", "FGNA05.PNG", "FGNA06.PNG",
                "FGNA07.PNG", "FGNA08.PNG", "FGNA09.PNG", "FGRM16.PNG", "FGRM17.PNG", "FGRM18.PNG" };

            //In the case of the Spanish translated version, the files are outside of the archive instead of being inside of it
            //The writing of the files is thus much simpler than the rest and is contained mostly in the if condition below
            //Note however that the NECEMEM.SNX file needs to be inserted into the archive to work in the case of the PS1 content
            if (language == Language.SP)
            {
                List<string> filesListToDelete = new List<string> { "AP00.SNX", "CALCNUMBERSRCYGRID.SNX", "CGMODE.SNX",
                "CGMODEAK.SNX", "CGMODEMO.SNX", "CGMODEMS.SNX", "CGMODEMU.SNX", "CGMODEMZ.SNX", "CGMODENN.SNX",
                "NECEMEM.SNX", "FGAK12.PNG", "FGAK13.PNG", "FGAK14.PNG", "FGAK15.PNG", "FGMI03.PNG", "FGMI04.PNG",
                "FGMI05.PNG", "FGMI06.PNG", "FGMS07.PNG", "FGMS08.PNG", "FGMS09.PNG", "FGMS10.PNG", "FGMY11.PNG",
                "FGMY12.PNG", "FGMY13.PNG", "FGMY14.PNG", "FGMZ12.PNG", "FGMZ13.PNG", "FGMZ14.PNG", "FGMZ15.PNG",
                "FGRM07.PNG", "FGRM12.PNG", "FGRM13.PNG", "FGRM14.PNG", "FGRM15.PNG" };
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

                //In case of the PS1 content, the NECEMEM.SNX file still needs to be inserted
                patchFilesList.Clear();

                if (PS1Content)
                    patchFilesList.Add(afsPatchFiles.FindFile("FV_PS1_NECEMEM.SNX"));

                else
                    patchFilesList.Add(afsPatchFiles.FindFile("FV_OG_NECEMEM.SNX"));
                
                patchFilesList.Last().Name = "NECEMEM.SNX";
            }

            //////////////////////////////
            //OPENING OF THE GAME ARCHIVE (SCRIPTS AND IMAGES)
            //////////////////////////////
            string originalFileName = "one";

            if (edition == Edition.VI)
                originalFileName = "lcsebody1";
            else if (language == Language.CH)
                originalFileName = "one_cn";
            else if (language == Language.KR)
                originalFileName = "one_kr";

            try
            {
                originalFile = new ArcView(path + originalFileName);
            }
            catch (FileNotFoundException e)
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
            catch (UnauthorizedAccessException e)
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
            catch (NullReferenceException e)
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

            //////////////////////////////
            //OPENING OF THE GAME ARCHIVE (VOICES)
            //////////////////////////////
            string originalSNDFileName = "SoundPackSEVo";
            if (PS1Content && (language == Language.JP || language == Language.EN || language == Language.SP))
            {
                try
                {
                    originalSNDFile = new ArcView(path + originalSNDFileName);
                }
                catch (FileNotFoundException e)
                {
                    richTextBox.ForeColor = Color.Red;
                    richTextBox.Text += "Error: the file \"" + originalSNDFileName + "\" was not found.\n" +
                        "Make sure to place it in the same directory as the executable.\n\n" +
                        "Error details: " + e;
                    return;
                }
                catch (UnauthorizedAccessException e)
                {
                    richTextBox.ForeColor = Color.Red;
                    richTextBox.Text += "Error: the file \"" + originalSNDFileName + "\" can't be accessed.\n" +
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
                    arcOriginalSNDFiles = lst.TryOpen(originalSNDFile);
                }
                catch (UnauthorizedAccessException e)
                {
                    richTextBox.ForeColor = Color.Red;
                    richTextBox.Text += "Error: the file \"" + originalSNDFileName + ".lst\" can't be accessed.\n" +
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
                    afsOriginalSNDFiles = arcOriginalSNDFiles.CreateFileSystem();
                }
                catch (NullReferenceException e)
                {
                    richTextBox.ForeColor = Color.Red;
                    richTextBox.Text += "Error: the file \"" + originalSNDFileName + ".lst\" was not found.\n" +
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
            }

            //////////////////////////////
            //CREATION OF THE SAVES BACKUP AND SAVES CONTROL
            //////////////////////////////
            bool savesToConvert = false;

            int i = 0;
            int choiceFlagsNumberFV = 198;
            int choiceFlagsNumberVI = 203;
            int choiceFlagsNumberFVEP20 = 201;
            int choiceFlagsNumberVIEP20 = 206;
            int CGFlagsNumberFV = 139;
            int CGFlagsNumberVI = 142;
            int CGFlagsNumberFVEP20 = 163;
            int CGFlagsNumberVIEP20 = 166;
            int textFlagsNumberFV = 30859;
            int textFlagsNumberVI = 31118;
            int textFlagsNumberFVEP20 = 32671;
            int textFlagsNumberVIEP20 = 32674;
            List<StandardSave> standardSavesToConvertList = new List<StandardSave>();

            string savesDirectoryName = path + (language != Language.KR ? "sav" : "sav_kr");
            DirectoryInfo savesDir = new DirectoryInfo(savesDirectoryName);

            //The Vista Edition can have its saves either in the sav folder or in C:\Users\[Current User]\AppData\Local\VirtualStore\Program Files (x86)\nexton\one_fv\sav
            if (PS1Content && edition == Edition.VI && !savesDir.Exists)
            {
                savesDirectoryName = System.Environment.GetEnvironmentVariable("USERPROFILE") + "\\AppData\\Local\\VirtualStore\\Program Files (x86)\\nexton\\one_fv\\sav";
                savesDir = new DirectoryInfo(savesDirectoryName);
            }

            if (PS1Content && savesDir.Exists)
            {
                richTextBox.Text += "Creation of the saves backup and saves control...";
                richTextBox.Update();

                //SAVE__.LCS
                long FVSaveSize = (CGFlagsNumberFV * 2 * 4) + (textFlagsNumberFV * 2); //62830
                long FVEP20SaveSize = (CGFlagsNumberFVEP20 * 2 * 4) + (textFlagsNumberFVEP20 * 2); //66646
                long VISaveSize = 16 + (CGFlagsNumberVI * 2 * 4) + (textFlagsNumberVI * 2); //63388
                long VIEP20SaveSize = 16 + (CGFlagsNumberVIEP20 * 2 * 4) + (textFlagsNumberVIEP20 * 2); //66692

                string backupDirectoryPath = savesDirectoryName + "\\saves_backup_" + DateTime.Now.ToString("MMddyyHHmmss");

                if (File.Exists(savesDirectoryName + "\\SAVE__.LCS"))
                {
                    FileInfo saveFile = new FileInfo(savesDirectoryName + "\\SAVE__.LCS");
                    if (edition == Edition.FV && (saveFile.Length == VISaveSize || saveFile.Length == VIEP20SaveSize))
                    {
                        richTextBox.ForeColor = Color.Red;
                        richTextBox.Text += "Error: your global save (SAVE__.LCS) was detected as being made with the " +
                            "Vista Edition but you've selected the Full Voice Edition.\n" +
                            "Are you sure of your choice?";
                        return;
                    }
                    else if (edition == Edition.VI && (saveFile.Length == FVSaveSize || saveFile.Length == FVEP20SaveSize))
                    {
                        richTextBox.ForeColor = Color.Red;
                        richTextBox.Text += "Error: your global save (SAVE__.LCS) was detected as being made with the " +
                            "Full Voice Edition but you've selected the Vista Edition.\n" +
                            "Are you sure of your choice?";
                        return;
                    }
                    else if ((saveFile.Length != FVSaveSize && saveFile.Length != FVEP20SaveSize && saveFile.Length != VISaveSize && saveFile.Length != VIEP20SaveSize))
                    {
                        richTextBox.ForeColor = Color.Red;
                        richTextBox.Text += "Error: your global save (SAVE__.LCS) has an unknown size.\n" +
                            "Remove it from your sav folder.";
                        return;
                    }

                    if ((edition == Edition.FV && saveFile.Length == FVSaveSize) ||
                        (edition == Edition.VI && saveFile.Length == VISaveSize))
                    {
                        Directory.CreateDirectory(backupDirectoryPath);
                        File.Copy(savesDirectoryName + "\\SAVE__.LCS", backupDirectoryPath + "\\SAVE__.LCS");
                        savesToConvert = true;
                    }
                }

                //SAVE00.LCS to SAVE99.LCS
                richTextBox.Text += " (save(s): ";
                for (i = 0 ; i <= 99 ; i++)
                {
                    if (File.Exists(savesDirectoryName + "\\SAVE" + i.ToString().PadLeft(2, '0') + ".LCS"))
                    {
                        BinaryReader br = new BinaryReader(File.OpenRead(savesDirectoryName + "\\SAVE" + i.ToString().PadLeft(2, '0') + ".LCS"));
                        richTextBox.Text += i.ToString().PadLeft(2, '0') + " ";
                        richTextBox.Update();

                        //The first part of the save file is constitued of a PNG with a resolution of 128x96.
                        //IEND is written at the end of every PNG, that's how we know where it ends.
                        int iendFlag = 0;
                        int offsetFinPNG = 0;
                        byte b = 0;
                        while (iendFlag < 4)
                        {
                            b = br.ReadByte();

                            if ((iendFlag == 0 && (int)b == 73) || //I
                                (iendFlag == 1 && (int)b == 69) || //E
                                (iendFlag == 2 && (int)b == 78) || //N
                                (iendFlag == 3 && (int)b == 68))   //D
                                iendFlag++;
                            else
                                iendFlag = 0;

                            offsetFinPNG++;
                        }

                        //We then read the 4 bytes checksum related to the IEND chunk to truly end the PNG.
                        br.ReadBytes(4);
                        offsetFinPNG += 4;

                        //The second part is composed of all the other save data.
                        //The rule to decrypt this part is simple: do a 00 XOR on the first byte,
                        //a 01 XOR on the second, etc. When you've reached FE, convert the current
                        //byte and go back to 00 (FF isn't used for some reason).
                        int saveKey = 0;
                        byte[] bytesBuffer = new byte[4];
                        int saveSize = -1;
                        int id = -1;
                        bool subScriptNameFound = false;
                        string subScriptName = "";
                        bool scriptNameFound = false;
                        string scriptName = "";
                        int choiceFlagsNumber = -1;
                        int CGFlagsNumber = -1;
                        int textFlagsNumber = -1;

                        for (int j = 0; j + offsetFinPNG < br.BaseStream.Length; j++)
                        {
                            b = br.ReadByte();

                            if ((edition == Edition.FV && (j == 0 || j == 300 || j == 11488 || j == 11512 || j == 11516)) ||
                                (edition == Edition.VI && (j == 0 || j == 336 || j == 11576 || j == 11600 || j == 11604)))
                                bytesBuffer[0] = (byte)(b ^ (byte)saveKey);
                            else if ((edition == Edition.FV && (j == 1 || j == 301 || j == 11489 || j == 11513 || j == 11517)) ||
                                     (edition == Edition.VI && (j == 1 || j == 337 || j == 11577 || j == 11601 || j == 11605)))
                                bytesBuffer[1] = (byte)(b ^ (byte)saveKey);
                            else if ((edition == Edition.FV && (j == 2 || j == 302 || j == 11490 || j == 11514 || j == 11518)) ||
                                     (edition == Edition.VI && (j == 2 || j == 338 || j == 11578 || j == 11602 || j == 11606)))
                                bytesBuffer[2] = (byte)(b ^ (byte)saveKey);
                            //SAVE SIZE
                            else if (j == 3)
                            {
                                bytesBuffer[3] = (byte)(b ^ (byte)saveKey);
                                saveSize = BitConverter.ToInt32(bytesBuffer, 0);
                            }
                            //ID
                            else if ((edition == Edition.FV && j == 303) || (edition == Edition.VI && j == 339))
                            {
                                bytesBuffer[3] = (byte)(b ^ (byte)saveKey);
                                id = BitConverter.ToInt32(bytesBuffer, 0);
                            }
                            //SUB SCRIPT NAME
                            else if ((edition == Edition.FV && j >= 916 && j <= 979 && !subScriptNameFound) || (edition == Edition.VI && j >= 1004 && j <= 1067 && !subScriptNameFound))
                            {
                                if ((byte)(b ^ (byte)saveKey) != 0b00)
                                    subScriptName += (char)(b ^ (byte)saveKey);
                                else
                                    subScriptNameFound = true;
                            }
                            //SCRIPT NAME
                            else if ((edition == Edition.FV && j >= 7128 && j <= 7191 && !scriptNameFound) || (edition == Edition.VI && j >= 7216 && j <= 7279 && !subScriptNameFound))
                            {
                                if ((byte)(b ^ (byte)saveKey) != 0b00)
                                    scriptName += (char)(b ^ (byte)saveKey);
                                else
                                    scriptNameFound = true;
                            }
                            //NUMBER OF CHOICE FLAGS
                            else if ((edition == Edition.FV && j == 11491) || (edition == Edition.VI && j == 11579))
                            {
                                bytesBuffer[3] = (byte)(b ^ (byte)saveKey);
                                choiceFlagsNumber = BitConverter.ToInt32(bytesBuffer, 0);
                            }
                            //NUMBER OF PARAMETER/CG FLAGS
                            else if ((edition == Edition.FV && j == 11515) || (edition == Edition.VI && j == 11603))
                            {
                                bytesBuffer[3] = (byte)(b ^ (byte)saveKey);
                                CGFlagsNumber = BitConverter.ToInt32(bytesBuffer, 0);
                            }
                            //NUMBER OF TEXT FLAGS
                            else if ((edition == Edition.FV && j == 11519) || (edition == Edition.VI && j == 11607))
                            {
                                bytesBuffer[3] = (byte)(b ^ (byte)saveKey);
                                textFlagsNumber = BitConverter.ToInt32(bytesBuffer, 0);
                            }

                            saveKey++;
                            if (saveKey >= 255)
                                saveKey = 0;
                        }

                        if (edition == Edition.FV && choiceFlagsNumber == choiceFlagsNumberVI && CGFlagsNumber == CGFlagsNumberVI && textFlagsNumber == textFlagsNumberVI)
                        {
                            richTextBox.ForeColor = Color.Red;
                            richTextBox.Text += "Error: your save SAVE" + i.ToString().PadLeft(2, '0') + ".LCS was detected as being made with the " +
                                "Vista Edition but you've selected the Full Voice Edition.\n" +
                                "Are you sure of your choice?";
                            return;
                        }
                        else if (edition == Edition.VI && choiceFlagsNumber == choiceFlagsNumberFV && CGFlagsNumber == CGFlagsNumberFV && textFlagsNumber == textFlagsNumberFV)
                        {
                            richTextBox.ForeColor = Color.Red;
                            richTextBox.Text += "Error: your save SAVE" + i.ToString().PadLeft(2, '0') + ".LCS was detected as being made with the " +
                                "Full Voice Edition but you've selected the Vista Edition.\n" +
                                "Are you sure of your choice?";
                            return;
                        }
                        else if ((edition == Edition.FV && choiceFlagsNumber == choiceFlagsNumberFV && CGFlagsNumber == CGFlagsNumberFV && textFlagsNumber == textFlagsNumberFV) ||
                                 (edition == Edition.VI && choiceFlagsNumber == choiceFlagsNumberVI && CGFlagsNumber == CGFlagsNumberVI && textFlagsNumber == textFlagsNumberVI))
                        {
                            StandardSave currentSave = new StandardSave
                            {
                                Name = "SAVE" + i.ToString().PadLeft(2, '0') + ".LCS",
                                Size = saveSize,
                                Id = id,
                                SubScriptName = subScriptName,
                                ScriptName = scriptName,
                                ChoiceFlagsNumber = choiceFlagsNumber,
                                CGFlagsNumber = CGFlagsNumber,
                                TextFlagsNumber = textFlagsNumber,
                            };
                            standardSavesToConvertList.Add(currentSave);

                            savesToConvert = true;
                        }
                        else if ((edition == Edition.FV && ((choiceFlagsNumber != choiceFlagsNumberFV && choiceFlagsNumber != choiceFlagsNumberFVEP20) || (CGFlagsNumber != CGFlagsNumberFV && CGFlagsNumber != CGFlagsNumberFVEP20) || (textFlagsNumber != textFlagsNumberFV && textFlagsNumber != textFlagsNumberFVEP20))) ||
                                 (edition == Edition.VI && ((choiceFlagsNumber != choiceFlagsNumberVI && choiceFlagsNumber != choiceFlagsNumberVIEP20) || (CGFlagsNumber != CGFlagsNumberVI && CGFlagsNumber != CGFlagsNumberVIEP20) || (textFlagsNumber != textFlagsNumberVI && textFlagsNumber != textFlagsNumberVIEP20))))
                        {
                            richTextBox.ForeColor = Color.Red;
                            richTextBox.Text += "Error: your save SAVE" + i.ToString().PadLeft(2, '0') + ".LCS seems corrupted.\n" +
                                "Remove it from your sav folder.";
                            return;
                        }

                        Directory.CreateDirectory(backupDirectoryPath);
                        File.Copy(savesDirectoryName + "\\SAVE" + i.ToString().PadLeft(2, '0') + ".LCS", backupDirectoryPath + "\\SAVE" + i.ToString().PadLeft(2, '0') + ".LCS");
                        br.Close();
                    }
                }
                richTextBox.Text = richTextBox.Text.Remove(richTextBox.Text.Length - 1, 1);
                richTextBox.Text += ")\n";
            }


            //////////////////////////////
            //EXTRACTION OF THE ORIGINAL FILES (SCRIPTS AND IMAGES)
            //////////////////////////////
            List<Entry> originalFilesList = new List<Entry>();
            originalFilesList = (List<Entry>)afsOriginalFiles.GetFiles();

            i = 0;
            foreach (Entry entry in originalFilesList)
            {
                string fileName = string.Empty;
                if (patchFilesList.ToArray().Length > i)
                {
                    fileName = ((Entry)patchFilesList.ToArray()[i]).Name;
                }

                //Skip the PS1 content if the user doesn't want it
                if (!PS1Content && filesListToNotUpdate.Any(entry.Name.Contains))
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

                    if (entry.Name.Equals(fileName))
                    {
                        resultFilesList.Add((Entry)patchFilesList.ToArray()[i]);
                        richTextBox.Text += fileName + " will be updated.\n";
                        i++;
                    }
                    else
                    {
                        resultFilesList.Add(entry);
                    }
                }
                //Insert the current original file
                else
                {
                    resultFilesList.Add(entry);
                }
            }


            //////////////////////////////
            //EXTRACTION OF THE ORIGINAL FILES (VOICES)
            //////////////////////////////
            long patchedSNDArchiveSize = 221739541;
            if (PS1Content && (language == Language.JP || language == Language.EN || language == Language.SP) && originalSNDFile.MaxOffset < patchedSNDArchiveSize)
            {
                List<Entry> originalSNDFilesList = new List<Entry>();
                originalSNDFilesList = (List<Entry>)afsOriginalSNDFiles.GetFiles();

                i = 0;
                foreach (Entry entry in originalSNDFilesList)
                {
                    string fileName = string.Empty;
                    if (patchSNDFilesList.ToArray().Length > i)
                    {
                        fileName = ((Entry)patchSNDFilesList.ToArray()[i]).Name;
                    }

                    //Update
                    if (patchSNDFilesList.ToArray().Length > i &&
                        entry.Name.Equals(fileName))
                    {
                        resultSNDFilesList.Add((Entry)patchSNDFilesList.ToArray()[i]);
                        i++;
                    }
                    //Insert new file(s) and the current original file
                    else if (patchSNDFilesList.ToArray().Length > i &&
                        entry.Type.Equals(((Entry)patchSNDFilesList.ToArray()[i]).Type) &&
                        String.Compare(entry.Name, fileName) > 0)
                    {

                        while (patchSNDFilesList.ToArray().Length > i &&
                            entry.Type.Equals(((Entry)patchSNDFilesList.ToArray()[i]).Type) &&
                            String.Compare(entry.Name, fileName) > 0)
                        {

                            resultSNDFilesList.Add((Entry)patchSNDFilesList.ToArray()[i]);
                            i++;

                            if (patchSNDFilesList.ToArray().Length > i)
                            {
                                fileName = ((Entry)patchSNDFilesList.ToArray()[i]).Name;
                            }
                        }

                        if (entry.Name.Equals(fileName))
                        {
                            resultSNDFilesList.Add((Entry)patchSNDFilesList.ToArray()[i]);
                            i++;
                        }
                        else
                        {
                            resultSNDFilesList.Add(entry);
                        }
                    }
                    //Insert the current original file
                    else
                    {
                        resultSNDFilesList.Add(entry);
                    }
                }
            }

            ////////////////////
            //WRITING (SCRIPTS AND IMAGES)
            ////////////////////
            richTextBox.Text += "Writing of the scripts and images...\n";
            
            var cp932 = Encodings.cp932.WithFatalFallback(); //cp932 is the encoding for the Japanese characters
            var nbFiles = resultFilesList.ToArray().Length; //count the number of files

            //The file one_TEMP will be written directly into binary
            BinaryWriter bw = null;
            bw = new BinaryWriter(File.Create("./one_TEMP.lst"));
            bool headerWritten = false;
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
                string fileName = entry.Name;
                int pointPosition = fileName.IndexOf(".");
                string extension = fileName.Substring(pointPosition + 1, fileName.Length - pointPosition - 1);

                byte[] bufferName = LstOpener.WriteName(fileName.Substring(0, pointPosition), 64, (byte)key, cp932);
                long fileSize = entry.Size ^ convertedKey;
                long convertedOffset = offset ^ convertedKey;
                offset += entry.Size;

                //Type is the only part that is not encrypted with the key
                int type = 0;
                if (extension.Equals("SNX"))
                    type = 1;
                else if (extension.Equals("BMP"))
                    type = 2;
                else if (extension.Equals("PNG"))
                    type = 3;
                else if (extension.Equals("WAV"))
                    type = 4;
                else if (extension.Equals("OGG"))
                    type = 5;
                else
                    type = -1;

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
            //The Spanish translation also has it since the developers never touched to the ONE archive.
            //It's not the case for the other translations or the Vista Edition, it doesn't seem to have an impact in the game and it's very probably a mistake since the last file is also a PNG file (the value is duplicated).
            //However, I prefer to put it in order to have a faithful recreation of the file.
            if (edition == Edition.FV && (language == Language.JP || language == Language.SP))
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

            //At the end, we replace the original files with the files that we have created.
            File.SetAttributes(originalFile.Name, FileAttributes.Normal);
            File.SetAttributes(originalFile.Name + ".lst", FileAttributes.Normal);

            File.Delete(originalFile.Name);
            File.Delete(originalFile.Name + ".lst");

            File.Move("one_TEMP", originalFile.Name);
            File.Move("one_TEMP.lst", originalFile.Name + ".lst");



            ////////////////////
            //WRITING (VOICES)
            ////////////////////
            if (PS1Content && (language == Language.JP || language == Language.EN || language == Language.SP) && originalSNDFile.MaxOffset < patchedSNDArchiveSize)
            {
                richTextBox.Text += "Writing of the voices...\n";

                nbFiles = resultSNDFilesList.ToArray().Length; //count the number of files

                //The file one_SND_TEMP will be written directly into binary
                bw = new BinaryWriter(File.Create("./one_SND_TEMP.lst"));
                headerWritten = false;
                offset = 0;

                //This part is used to initialize the variables used to read the one_TEMP file
                stream = null;
                output = PhysicalFileSystem.CreateFile("./one_SND_TEMP");

                //Loop that will treat each file, it's going to insert an entry into the one_SND_TEMP.lst file and then insert it into the one_SND_TEMP file afterwards
                foreach (Entry entry in resultSNDFilesList)
                {
                    //We start with the transformation of the data
                    string fileName = entry.Name;
                    int pointPosition = fileName.IndexOf(".");
                    string extension = fileName.Substring(pointPosition + 1, fileName.Length - pointPosition - 1);

                    byte[] bufferName = LstOpener.WriteName(fileName.Substring(0, pointPosition), 64, (byte)key, cp932);
                    long fileSize = entry.Size ^ convertedKey;
                    long convertedOffset = offset ^ convertedKey;
                    offset += entry.Size;

                    //Type is the only part that is not encrypted with the key
                    int type = 0;
                    if (extension.Equals("SNX"))
                        type = 1;
                    else if (extension.Equals("BMP"))
                        type = 2;
                    else if (extension.Equals("PNG"))
                        type = 3;
                    else if (extension.Equals("WAV"))
                        type = 4;
                    else if (extension.Equals("OGG"))
                        type = 5;
                    else
                        type = -1;

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
                    if (patchSNDFilesList.Exists(file => file.Name == entry.Name))
                    {
                        stream = arcPatchFiles.OpenEntry(entry);
                    }
                    else if (afsOriginalSNDFiles.FileExists(entry.Name))
                    {
                        stream = arcOriginalSNDFiles.OpenEntry(entry);
                    }

                    stream.CopyTo(output);
                    stream.Dispose();
                }

                bw.Close();
                output.Close();
                output.Dispose();
                originalSNDFile.Dispose();

                //At the end, we replace the original files with the files that we have created.
                File.SetAttributes(originalSNDFile.Name, FileAttributes.Normal);
                File.SetAttributes(originalSNDFile.Name + ".lst", FileAttributes.Normal);

                File.Delete(originalSNDFile.Name);
                File.Delete(originalSNDFile.Name + ".lst");

                File.Move("one_SND_TEMP", originalSNDFile.Name);
                File.Move("one_SND_TEMP.lst", originalSNDFile.Name + ".lst");
            }
            else if (PS1Content && (language == Language.JP || language == Language.EN || language == Language.SP))
            {
                richTextBox.Text += "New voices already added.\n";
            }

            patchFile.Dispose();

            if (originalSNDFile != null)
                originalSNDFile.Dispose();

            ////////////////////
            //SAVES CONVERSION
            ////////////////////
            if (!savesToConvert && PS1Content)
            {
                richTextBox.Text += "No save needing a conversion was found so no conversion was made.";
                if (edition == Edition.VI)
                    richTextBox.Text += " If the patch hasn't found your current save(s) please check the README.";
                richTextBox.Text += "\n";
            }
            else if (savesToConvert)
            {
                richTextBox.Text += "Conversion of your saves...";
                BinaryReader br = null;

                if (File.Exists(savesDirectoryName + "\\SAVE__.LCS"))
                {
                    br = new BinaryReader(File.OpenRead(savesDirectoryName + "\\SAVE__.LCS"));
                    bw = new BinaryWriter(File.Create(savesDirectoryName + "\\SAVE__temp.LCS"));

                    //The save of the Vista Edition starts by the string "DEFAULTVERSION" followed by two 00 bytes
                    if (edition == Edition.VI)
                        bw.Write(br.ReadBytes(16));

                    //Writing of the first and second parts of the save.
                    //The first part is constitued of random 4 bytes numbers.
                    //The second part of the save is constitued of flags for parameters and CGs.
                    //To decrypt the second part you need to do a XOR with the correponding random numbers of the previous part.
                    for (i = 0; i < 2; i++)
                    {
                        if (edition == Edition.FV)
                        {
                            bw.Write(br.ReadBytes(CGFlagsNumberFV * 4));
                            for (int j = 0; j < CGFlagsNumberFVEP20 - CGFlagsNumberFV; j++)
                                bw.Write(0);
                        }
                        else if (edition == Edition.VI)
                        {
                            bw.Write(br.ReadBytes(CGFlagsNumberVI * 4));
                            for (int j = 0; j < CGFlagsNumberVIEP20 - CGFlagsNumberVI; j++)
                                bw.Write(0);
                        }
                    }

                    //Writing of the third and fourth parts of the save.
                    //They're the same things as the two previous parts except the flags are on 1 byte
                    //and that they're used to indicate the ids of the texts already read.
                    for (i = 0; i < 2; i++)
                    {
                        if (edition == Edition.FV)
                        {
                            bw.Write(br.ReadBytes(textFlagsNumberFV));
                            for (int j = 0; j < textFlagsNumberFVEP20 - textFlagsNumberFV; j++)
                                bw.Write((byte)0x00);
                        }
                        else if (edition == Edition.VI)
                        {
                            bw.Write(br.ReadBytes(textFlagsNumberVI));
                            for (int j = 0; j < textFlagsNumberVIEP20 - textFlagsNumberVI; j++)
                                bw.Write((byte)0x00);
                        }
                    }

                    br.Close();
                    bw.Close();
                    File.Delete(savesDirectoryName + "\\SAVE__.LCS");
                    File.Move(savesDirectoryName + "\\SAVE__temp.LCS", savesDirectoryName + "\\SAVE__.LCS");
                }

                richTextBox.Text += " (save(s): ";
                string savesNotOK = "";
                foreach (StandardSave standardSave in standardSavesToConvertList)
                {
                    br = new BinaryReader(File.OpenRead(savesDirectoryName + "\\"+standardSave.Name));
                    bw = new BinaryWriter(File.Create(savesDirectoryName + "\\TEMP" + standardSave.Name));

                    richTextBox.Text += standardSave.Name.Substring(4, 2) + " ";
                    richTextBox.Update();

                    //First part of the save file with the PNG.
                    int iendFlag = 0;
                    int offsetFinPNG = 0;
                    byte b = 0;
                    while (iendFlag < 4)
                    {
                        b = br.ReadByte();

                        if ((iendFlag == 0 && (int)b == 73) || //I
                            (iendFlag == 1 && (int)b == 69) || //E
                            (iendFlag == 2 && (int)b == 78) || //N
                            (iendFlag == 3 && (int)b == 68))   //D
                            iendFlag++;
                        else
                            iendFlag = 0;

                        bw.Write(b);
                        offsetFinPNG++;
                    }

                    //Checksum of the IEND chunk.
                    bw.Write(br.ReadBytes(4));
                    offsetFinPNG += 4;

                    //We update the save data
                    byte[] saveSize = new byte[4];
                    if (edition == Edition.FV)
                        saveSize = BitConverter.GetBytes(standardSave.Size + ((choiceFlagsNumberFVEP20 - choiceFlagsNumberFV) * 4));
                    else if (edition == Edition.VI)
                        saveSize = BitConverter.GetBytes(standardSave.Size + ((choiceFlagsNumberVIEP20 - choiceFlagsNumberVI) * 4));

                    byte[] choiceFlagsNumber = new byte[4];
                    if (edition == Edition.FV)
                        choiceFlagsNumber = BitConverter.GetBytes(choiceFlagsNumberFVEP20);
                    else if (edition == Edition.VI)
                        choiceFlagsNumber = BitConverter.GetBytes(choiceFlagsNumberVIEP20);
                    
                    byte[] CGFlagsNumber = new byte[4];
                    if (edition == Edition.FV)
                        CGFlagsNumber = BitConverter.GetBytes(CGFlagsNumberFVEP20);
                    else if (edition == Edition.VI)
                        CGFlagsNumber = BitConverter.GetBytes(CGFlagsNumberVIEP20);

                    byte[] textFlagsNumber = new byte[4];
                    if (edition == Edition.FV)
                        textFlagsNumber = BitConverter.GetBytes(textFlagsNumberFVEP20);
                    else if (edition == Edition.VI)
                        textFlagsNumber = BitConverter.GetBytes(textFlagsNumberVIEP20);

                    byte[] newChoicesFlags = new byte[4];
                    if (edition == Edition.FV)
                        newChoicesFlags = new byte[((choiceFlagsNumberFVEP20 - choiceFlagsNumberFV) * 4)];
                    else if (edition == Edition.VI)
                        newChoicesFlags = new byte[((choiceFlagsNumberVIEP20 - choiceFlagsNumberVI) * 4)];

                    for (int j = 0; j < newChoicesFlags.Length; j++)
                        newChoicesFlags[j] = 0x00;

                    //Second part composed of all the other save data.
                    int saveKey = 0;
                    for (i = 0; i + offsetFinPNG < br.BaseStream.Length; i++)
                    {
                        b = br.ReadByte();

                        //SAVE SIZE
                        if (i == 0)
                            saveSize[0] ^= (byte)saveKey;
                        else if (i == 1)
                            saveSize[1] ^= (byte)saveKey;
                        else if (i == 2)
                            saveSize[2] ^= (byte)saveKey;
                        else if (i == 3)
                        {
                            saveSize[3] ^= (byte)saveKey;
                            bw.Write(saveSize);
                        }
                        //NUMBER OF CHOICE FLAGS
                        else if ((edition == Edition.FV && i == 11488) || (edition == Edition.VI && i == 11576))
                            choiceFlagsNumber[0] ^= (byte)saveKey;
                        else if ((edition == Edition.FV && i == 11489) || (edition == Edition.VI && i == 11577))
                            choiceFlagsNumber[1] ^= (byte)saveKey;
                        else if ((edition == Edition.FV && i == 11490) || (edition == Edition.VI && i == 11578))
                            choiceFlagsNumber[2] ^= (byte)saveKey;
                        else if ((edition == Edition.FV && i == 11491) || (edition == Edition.VI && i == 11579))
                        {
                            choiceFlagsNumber[3] ^= (byte)saveKey;
                            bw.Write(choiceFlagsNumber);
                        }
                        //NUMBER OF PARAMETER/CG FLAGS
                        else if ((edition == Edition.FV && i == 11512) || (edition == Edition.VI && i == 11600))
                            CGFlagsNumber[0] ^= (byte)saveKey;
                        else if ((edition == Edition.FV && i == 11513) || (edition == Edition.VI && i == 11601))
                            CGFlagsNumber[1] ^= (byte)saveKey;
                        else if ((edition == Edition.FV && i == 11514) || (edition == Edition.VI && i == 11602))
                            CGFlagsNumber[2] ^= (byte)saveKey;
                        else if ((edition == Edition.FV && i == 11515) || (edition == Edition.VI && i == 11603))
                        {
                            CGFlagsNumber[3] ^= (byte)saveKey;
                            bw.Write(CGFlagsNumber);
                        }
                        //NUMBER OF TEXT FLAGS
                        else if ((edition == Edition.FV && i == 11516) || (edition == Edition.VI && i == 11604))
                            textFlagsNumber[0] ^= (byte)saveKey;
                        else if ((edition == Edition.FV && i == 11517) || (edition == Edition.VI && i == 11605))
                            textFlagsNumber[1] ^= (byte)saveKey;
                        else if ((edition == Edition.FV && i == 11518) || (edition == Edition.VI && i == 11606))
                            textFlagsNumber[2] ^= (byte)saveKey;
                        else if ((edition == Edition.FV && i == 11519) || (edition == Edition.VI && i == 11607))
                        {
                            textFlagsNumber[3] ^= (byte)saveKey;
                            bw.Write(textFlagsNumber);
                        }
                        //CREATION OF THE NEW CHOICE FLAGS
                        else if ((edition == Edition.FV && i == ( 13400 + (choiceFlagsNumberFV * 4))) || (edition == Edition.VI && i == (13624 + (choiceFlagsNumberVI * 4))))
                        {
                            for (int j = 0; j < newChoicesFlags.Length; j++)
                            {
                                newChoicesFlags[j] ^= (byte)saveKey;

                                saveKey++;
                                if (saveKey >= 255)
                                    saveKey = 0;
                            }

                            bw.Write(newChoicesFlags);
                            bw.Write((byte)(b ^ (saveKey - newChoicesFlags.Length) ^ saveKey));
                        }
                        //Since more bytes were added, the rest of the bytes need to be converted again before being inserted
                        else if ((edition == Edition.FV && i > (13400 + (choiceFlagsNumberFV * 4))) || (edition == Edition.VI && i > (13624 + (choiceFlagsNumberVI * 4))))
                        {
                            int preconversion = saveKey - newChoicesFlags.Length;
                            if (preconversion < 0)
                                preconversion += 255;

                            bw.Write((byte)(b ^ preconversion ^ saveKey));
                        }
                        else
                            bw.Write(b);

                        saveKey++;
                        if (saveKey >= 255)
                            saveKey = 0;
                    }

                    br.Close();
                    bw.Close();
                    File.Delete(savesDirectoryName + "\\" + standardSave.Name);
                    File.Move(savesDirectoryName + "\\TEMP" + standardSave.Name, savesDirectoryName + "\\" + standardSave.Name);

                    if (!IsSaveOK(standardSave, edition))
                    {
                         if (savesNotOK.Equals(""))
                            savesNotOK += standardSave.Name.Substring(4, 2);
                         else
                            savesNotOK += ", " + standardSave.Name.Substring(4, 2);
                    }
                }
                richTextBox.Text = richTextBox.Text.Remove(richTextBox.Text.Length - 1, 1);
                richTextBox.Text += ")\n";

                if (!savesNotOK.Equals(""))
                    richTextBox.Text += "Warning: the save(s) "+savesNotOK+" was/were detected as being made after changes made to the game. Check the README.\n";
            }


            richTextBox.Text += "\nDone!";
        }

        public static bool IsSaveOK (StandardSave standardSave, Edition edition)
        {
            if ((standardSave.ScriptName.Equals("Ak26") && standardSave.SubScriptName.Equals("Ak26") && ((edition == Edition.FV && standardSave.Id >= 2613) || (edition == Edition.VI && standardSave.Id >= 2633))) ||
                (standardSave.ScriptName.Equals("DS01") && standardSave.SubScriptName.Equals("DS01") && ((edition == Edition.FV && standardSave.Id >= 5237) || (edition == Edition.VI && standardSave.Id >= 5269))) ||
                (standardSave.ScriptName.Equals("DS05") && standardSave.SubScriptName.Equals("DS05") && ((edition == Edition.FV && standardSave.Id >= 7515) || (edition == Edition.VI && standardSave.Id >= 7578))) ||
                (standardSave.ScriptName.Equals("DS07") && standardSave.SubScriptName.Equals("DS07") && ((edition == Edition.FV && standardSave.Id >= 8399) || (edition == Edition.VI && standardSave.Id >= 8472))) ||
                (standardSave.ScriptName.Equals("DS09") && standardSave.SubScriptName.Equals("DS09") && ((edition == Edition.FV && standardSave.Id >= 9174) || (edition == Edition.VI && standardSave.Id >= 9259))) ||
                (standardSave.ScriptName.Equals("DS10") && standardSave.SubScriptName.Equals("Ds10_a") && ((edition == Edition.FV && standardSave.Id >= 10629) || (edition == Edition.VI && standardSave.Id >= 10727))) ||
                (standardSave.ScriptName.Equals("DS18") && standardSave.SubScriptName.Equals("DS18") && ((edition == Edition.FV && standardSave.Id >= 12547) || (edition == Edition.VI && standardSave.Id >= 12662))) ||
                (standardSave.ScriptName.Equals("DS19") && standardSave.SubScriptName.Equals("DS19") && ((edition == Edition.FV && standardSave.Id >= 12905) || (edition == Edition.VI && standardSave.Id >= 13024))) ||
                (standardSave.ScriptName.Equals("Mi26") && standardSave.SubScriptName.Equals("Mi26") && ((edition == Edition.FV && standardSave.Id >= 15280) || (edition == Edition.VI && standardSave.Id >= 15418))) ||
                (standardSave.ScriptName.Equals("Ms22") && standardSave.SubScriptName.Equals("Ms22") && ((edition == Edition.FV && standardSave.Id >= 16261) || (edition == Edition.VI && standardSave.Id >= 16402))) ||
                (standardSave.ScriptName.Equals("MS25") && standardSave.SubScriptName.Equals("MS25") && ((edition == Edition.FV && standardSave.Id >= 17149) || (edition == Edition.VI && standardSave.Id >= 17294))) ||
                (standardSave.ScriptName.Equals("MS27") && standardSave.SubScriptName.Equals("MS27") && ((edition == Edition.FV && standardSave.Id >= 17921) || (edition == Edition.VI && standardSave.Id >= 18076))) ||
                (standardSave.ScriptName.Equals("MY24") && standardSave.SubScriptName.Equals("MY24") && ((edition == Edition.FV && standardSave.Id >= 19949) || (edition == Edition.VI && standardSave.Id >= 20112))) ||
                (standardSave.ScriptName.Equals("nv30") && standardSave.SubScriptName.Equals("nv30") && ((edition == Edition.FV && standardSave.Id >= 23707) || (edition == Edition.VI && standardSave.Id >= 23900))) ||
                (standardSave.ScriptName.Equals("RM24") && standardSave.SubScriptName.Equals("RM24") && ((edition == Edition.FV && standardSave.Id >= 25863) || (edition == Edition.VI && standardSave.Id >= 26083))) ||
                (standardSave.SubScriptName.Equals("SBD25N1") && ((edition == Edition.FV && standardSave.Id >= 28294) || (edition == Edition.VI && standardSave.Id >= 28523))) ||
                (standardSave.ScriptName.Equals("RM14") && standardSave.SubScriptName.Equals("SBRM14N1") && ((edition == Edition.FV && standardSave.Id >= 29315) || (edition == Edition.VI && standardSave.Id >= 29550))) ||
                (standardSave.ScriptName.Equals("RM17") && standardSave.SubScriptName.Equals("SBRM17M1") && ((edition == Edition.FV && standardSave.Id >= 29540) || (edition == Edition.VI && standardSave.Id >= 29777))))
                return false;

            return true;
        }
    }
}
