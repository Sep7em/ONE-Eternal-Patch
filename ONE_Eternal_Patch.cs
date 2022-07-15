using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using GameRes;

namespace ONE_Eternal_Patch
{
    public class ONE_Eternal_Patch
    {
        private static string inputEdition;
        private static string inputLanguage;
        private static string inputBonusCG;
        private static string inputAAContent;

        //Scripts lists
        private static List<String> filesList_FV_OG = new List<String> { "FV_OG_CGMODEAK.SNX", "FV_OG_CGMODEMO.SNX", "FV_OG_CGMODEMS.SNX",
            "FV_OG_CGMODEMU.SNX", "FV_OG_CGMODEMZ.SNX", "FV_OG_CGMODENN.SNX" };

        private static List<String> filesList_VI_OG = new List<String> { "VI_OG_CGMODEAK.SNX", "VI_OG_CGMODEMO.SNX", "VI_OG_CGMODEMS.SNX",
            "VI_OG_CGMODEMU.SNX", "VI_OG_CGMODEMZ.SNX", "VI_OG_CGMODENN.SNX" };

        private static List<String> filesList_FV_OG_JP = new List<String> { "FV_OG_JP_AK26.SNX", "FV_OG_JP_DS01.SNX", "FV_OG_JP_DS05.SNX",
            "FV_OG_JP_DS07.SNX", "FV_OG_JP_DS09.SNX", "FV_OG_JP_DS10_A.SNX", "FV_OG_JP_DS19.SNX", "FV_OG_JP_MI26.SNX",
            "FV_OG_JP_MS22.SNX", "FV_OG_JP_MS25.SNX", "FV_OG_JP_MS27.SNX", "FV_OG_JP_MY24.SNX", "FV_OG_JP_NV30.SNX",
            "FV_OG_JP_RM24.SNX", "FV_OG_JP_SBD25N1.SNX", "FV_OG_JP_SBRM14N1.SNX", "FV_OG_JP_SBRM17M1.SNX" };

        private static List<String> filesList_FV_OG_EN = new List<String> { "FV_OG_EN_AK26.SNX", "FV_OG_EN_DS01.SNX", "FV_OG_EN_DS05.SNX",
            "FV_OG_EN_DS07.SNX", "FV_OG_EN_DS09.SNX", "FV_OG_EN_DS10_A.SNX", "FV_OG_EN_DS19.SNX", "FV_OG_EN_MI26.SNX",
            "FV_OG_EN_MS22.SNX", "FV_OG_EN_MS25.SNX", "FV_OG_EN_MS27.SNX", "FV_OG_EN_MY24.SNX", "FV_OG_EN_NV30.SNX",
            "FV_OG_EN_RM24.SNX", "FV_OG_EN_SBD25N1.SNX", "FV_OG_EN_SBRM14N1.SNX", "FV_OG_EN_SBRM17M1.SNX" };

        private static List<String> filesList_VI_OG_JP = new List<String> { "VI_OG_JP_AK26.SNX", "VI_OG_JP_DS01.SNX", "VI_OG_JP_DS05.SNX",
            "VI_OG_JP_DS07.SNX", "VI_OG_JP_DS09.SNX", "VI_OG_JP_DS10_A.SNX", "VI_OG_JP_DS19.SNX", "VI_OG_JP_MI26.SNX",
            "VI_OG_JP_MS22.SNX", "VI_OG_JP_MS25.SNX", "VI_OG_JP_MS27.SNX", "VI_OG_JP_MY24.SNX", "VI_OG_JP_NV30.SNX",
            "VI_OG_JP_RM24.SNX", "VI_OG_JP_SBD25N1.SNX", "VI_OG_JP_SBRM14N1.SNX", "VI_OG_JP_SBRM17M1.SNX" };

        private static List<String> filesList_VI_OG_EN = new List<String> { "VI_OG_EN_AK26.SNX", "VI_OG_EN_DS01.SNX", "VI_OG_EN_DS05.SNX",
            "VI_OG_EN_DS07.SNX", "VI_OG_EN_DS09.SNX", "VI_OG_EN_DS10_A.SNX", "VI_OG_EN_DS19.SNX", "VI_OG_EN_MI26.SNX",
            "VI_OG_EN_MS22.SNX", "VI_OG_EN_MS25.SNX", "VI_OG_EN_MS27.SNX", "VI_OG_EN_MY24.SNX", "VI_OG_EN_NV30.SNX",
            "VI_OG_EN_RM24.SNX", "VI_OG_EN_SBD25N1.SNX", "VI_OG_EN_SBRM14N1.SNX", "VI_OG_EN_SBRM17M1.SNX" };

        private static List<String> filesList_FV_BCG = new List<String> { "FV_BCG_CGMODEAK.SNX", "FV_BCG_CGMODEMO.SNX", "FV_BCG_CGMODEMS.SNX",
            "FV_BCG_CGMODEMU.SNX", "FV_BCG_CGMODEMZ.SNX", "FV_BCG_CGMODENN.SNX" };

        private static List<String> filesList_VI_BCG = new List<String> { "VI_BCG_CGMODEAK.SNX", "VI_BCG_CGMODEMO.SNX", "VI_BCG_CGMODEMS.SNX",
            "VI_BCG_CGMODEMU.SNX", "VI_BCG_CGMODEMZ.SNX", "VI_BCG_CGMODENN.SNX" };

        private static List<String> filesList_FV_BCG_JP = new List<String> { "FV_BCG_JP_AK26.SNX", "FV_BCG_JP_DS01.SNX", "FV_BCG_JP_DS05.SNX",
            "FV_BCG_JP_DS07.SNX", "FV_BCG_JP_DS09.SNX", "FV_BCG_JP_DS10_A.SNX", "FV_BCG_JP_DS19.SNX", "FV_BCG_JP_MS22.SNX",
            "FV_BCG_JP_MS25.SNX", "FV_BCG_JP_MS27.SNX", "FV_BCG_JP_MY24.SNX", "FV_BCG_JP_NV30.SNX", "FV_BCG_JP_RM24.SNX",
            "FV_BCG_JP_SBD25N1.SNX", "FV_BCG_JP_SBRM14N1.SNX", "FV_BCG_JP_SBRM17M1.SNX" };

        private static List<String> filesList_FV_BCG_EN = new List<String> { "FV_BCG_EN_AK26.SNX", "FV_BCG_EN_DS01.SNX", "FV_BCG_EN_DS05.SNX",
            "FV_BCG_EN_DS07.SNX", "FV_BCG_EN_DS09.SNX", "FV_BCG_EN_DS10_A.SNX", "FV_BCG_EN_DS19.SNX", "FV_BCG_EN_MS22.SNX",
            "FV_BCG_EN_MS25.SNX", "FV_BCG_EN_MS27.SNX", "FV_BCG_EN_MY24.SNX", "FV_BCG_EN_NV30.SNX", "FV_BCG_EN_RM24.SNX",
            "FV_BCG_EN_SBD25N1.SNX", "FV_BCG_EN_SBRM14N1.SNX", "FV_BCG_EN_SBRM17M1.SNX" };

        private static List<String> filesList_VI_BCG_JP = new List<String> { "VI_BCG_JP_AK26.SNX", "VI_BCG_JP_DS01.SNX", "VI_BCG_JP_DS05.SNX",
            "VI_BCG_JP_DS07.SNX", "VI_BCG_JP_DS09.SNX", "VI_BCG_JP_DS10_A.SNX", "VI_BCG_JP_DS19.SNX", "VI_BCG_JP_MS22.SNX",
            "VI_BCG_JP_MS25.SNX", "VI_BCG_JP_MS27.SNX", "VI_BCG_JP_MY24.SNX", "VI_BCG_JP_NV30.SNX", "VI_BCG_JP_RM24.SNX",
            "VI_BCG_JP_SBD25N1.SNX", "VI_BCG_JP_SBRM14N1.SNX", "VI_BCG_JP_SBRM17M1.SNX" };

        private static List<String> filesList_VI_BCG_EN = new List<String> { "VI_BCG_EN_AK26.SNX", "VI_BCG_EN_DS01.SNX", "VI_BCG_EN_DS05.SNX",
            "VI_BCG_EN_DS07.SNX", "VI_BCG_EN_DS09.SNX", "VI_BCG_EN_DS10_A.SNX", "VI_BCG_EN_DS19.SNX", "VI_BCG_EN_MS22.SNX",
            "VI_BCG_EN_MS25.SNX", "VI_BCG_EN_MS27.SNX", "VI_BCG_EN_MY24.SNX", "VI_BCG_EN_NV30.SNX", "VI_BCG_EN_RM24.SNX",
            "VI_BCG_EN_SBD25N1.SNX", "VI_BCG_EN_SBRM14N1.SNX", "VI_BCG_EN_SBRM17M1.SNX" };

        private static List<String> filesList_FV_AA = new List<String> { "FV_AA_CGMODEAK.SNX", "FV_AA_CGMODEMO.SNX", "FV_AA_CGMODEMS.SNX",
            "FV_AA_CGMODEMU.SNX", "FV_AA_CGMODEMZ.SNX", "FV_AA_CGMODENN.SNX" };

        private static List<String> filesList_VI_AA = new List<String> { "VI_AA_CGMODEAK.SNX", "VI_AA_CGMODEMO.SNX", "VI_AA_CGMODEMS.SNX",
            "VI_AA_CGMODEMU.SNX", "VI_AA_CGMODEMZ.SNX", "VI_AA_CGMODENN.SNX" };

        private static List<String> filesList_FV_AA_JP = new List<String> { "FV_AA_JP_AK26.SNX", "FV_AA_JP_MI26.SNX" };

        private static List<String> filesList_FV_AA_EN = new List<String> { "FV_AA_EN_AK26.SNX", "FV_AA_EN_MI26.SNX" };

        private static List<String> filesList_VI_AA_JP = new List<String> { "VI_AA_JP_AK26.SNX", "VI_AA_JP_MI26.SNX" };

        private static List<String> filesList_VI_AA_EN = new List<String> { "VI_AA_EN_AK26.SNX", "VI_AA_EN_MI26.SNX" };

        private static List<String> filesList_FV_BCG_AA = new List<String> { "FV_BCG_AA_CGMODEAK.SNX", "FV_BCG_AA_CGMODEMO.SNX", "FV_BCG_AA_CGMODEMS.SNX",
            "FV_BCG_AA_CGMODEMU.SNX", "FV_BCG_AA_CGMODEMZ.SNX", "FV_BCG_AA_CGMODENN.SNX" };

        private static List<String> filesList_VI_BCG_AA = new List<String> { "VI_BCG_AA_CGMODEAK.SNX", "VI_BCG_AA_CGMODEMO.SNX", "VI_BCG_AA_CGMODEMS.SNX",
            "VI_BCG_AA_CGMODEMU.SNX", "VI_BCG_AA_CGMODEMZ.SNX", "VI_BCG_AA_CGMODENN.SNX" };

        private static List<String> filesList_FV_BCG_AA_JP = new List<String> { "FV_BCG_AA_JP_AK26.SNX" };

        private static List<String> filesList_FV_BCG_AA_EN = new List<String> { "FV_BCG_AA_EN_AK26.SNX" };

        private static List<String> filesList_VI_BCG_AA_JP = new List<String> { "VI_BCG_AA_JP_AK26.SNX" };

        private static List<String> filesList_VI_BCG_AA_EN = new List<String> { "VI_BCG_AA_EN_AK26.SNX" };


        //Images Lists
        private static List<String> filesList_OG = new List<String> { "OG_FGAK12.PNG", "OG_FGAK13.PNG", "OG_FGAK14.PNG", "OG_FGAK15.PNG", "OG_FGMI03.PNG",
            "OG_FGMI04.PNG", "OG_FGMI05.PNG", "OG_FGMI06.PNG", "OG_FGMS07.PNG", "OG_FGMS08.PNG", "OG_FGMS09.PNG", "OG_FGMS10.PNG", "OG_FGMY11.PNG",
            "OG_FGMY12.PNG", "OG_FGMY13.PNG", "OG_FGMY14.PNG", "OG_FGMZ12.PNG", "OG_FGMZ13.PNG", "OG_FGMZ14.PNG", "OG_FGMZ15.PNG", "OG_FGRM07.PNG", 
            "OG_FGRM12.PNG", "OG_FGRM13.PNG", "OG_FGRM14.PNG", "OG_FGRM15.PNG" };

        private static List<String> filesList_OG_JP = new List<String> { "OG_JP_CGMODEAKBK.PNG", "OG_JP_CGMODEAKCHIP.PNG", "OG_JP_CGMODEMOBK.PNG",
            "OG_JP_CGMODEMOCHIP.PNG", "OG_JP_CGMODEMSBK.PNG", "OG_JP_CGMODEMSCHIP.PNG", "OG_JP_CGMODEMUBK.PNG", "OG_JP_CGMODEMUCHIP.PNG",
            "OG_JP_CGMODEMZBK.PNG", "OG_JP_CGMODEMZCHIP.PNG", "OG_JP_CGMODENNBK.PNG", "OG_JP_CGMODENNCHIP.PNG" };

        private static List<String> filesList_OG_EN = new List<String> { "OG_EN_CGMODEAKBK.PNG", "OG_EN_CGMODEAKCHIP.PNG", "OG_EN_CGMODEMOBK.PNG",
            "OG_EN_CGMODEMOCHIP.PNG", "OG_EN_CGMODEMSBK.PNG", "OG_EN_CGMODEMSCHIP.PNG", "OG_EN_CGMODEMUBK.PNG", "OG_EN_CGMODEMUCHIP.PNG",
            "OG_EN_CGMODEMZBK.PNG", "OG_EN_CGMODEMZCHIP.PNG", "OG_EN_CGMODENNBK.PNG", "OG_EN_CGMODENNCHIP.PNG" };

        private static List<String> filesList_BCG = new List<String> { "BCG_BG400.PNG", "BCG_FGAK17.PNG", "BCG_FGAK18.PNG", "BCG_FGMI17.PNG", "BCG_FGMI18.PNG",
            "BCG_FGMI19.PNG", "BCG_FGMS18.PNG", "BCG_FGMS19.PNG", "BCG_FGMY16.PNG", "BCG_FGMY17.PNG", "BCG_FGMZ17.PNG", "BCG_FGMZ18.PNG",
            "BCG_FGRM16.PNG", "BCG_FGRM17.PNG", "BCG_FGRM18.PNG" };

        private static List<String> filesList_BCG_JP = new List<String> { "BCG_JP_CGMODEAKBK.PNG", "BCG_JP_CGMODEAKCHIP.PNG", "BCG_JP_CGMODEMOBK.PNG",
            "BCG_JP_CGMODEMOCHIP.PNG", "BCG_JP_CGMODEMSBK.PNG", "BCG_JP_CGMODEMSCHIP.PNG", "BCG_JP_CGMODEMUBK.PNG", "BCG_JP_CGMODEMUCHIP.PNG",
            "BCG_JP_CGMODEMZBK.PNG", "BCG_JP_CGMODEMZCHIP.PNG", "BCG_JP_CGMODENNBK.PNG", "BCG_JP_CGMODENNCHIP.PNG" };

        private static List<String> filesList_BCG_EN = new List<String> { "BCG_EN_CGMODEAKBK.PNG", "BCG_EN_CGMODEAKCHIP.PNG", "BCG_EN_CGMODEMOBK.PNG",
            "BCG_EN_CGMODEMOCHIP.PNG", "BCG_EN_CGMODEMSBK.PNG", "BCG_EN_CGMODEMSCHIP.PNG", "BCG_EN_CGMODEMUBK.PNG", "BCG_EN_CGMODEMUCHIP.PNG",
            "BCG_EN_CGMODEMZBK.PNG", "BCG_EN_CGMODEMZCHIP.PNG", "BCG_EN_CGMODENNBK.PNG", "BCG_EN_CGMODENNCHIP.PNG" };

        private static List<String> filesList_AA = new List<String> { "AA_FGAK12.PNG", "AA_FGAK13.PNG", "AA_FGAK14.PNG", "AA_FGAK15.PNG", "AA_FGMI03.PNG",
            "AA_FGMI04.PNG", "AA_FGMI05.PNG", "AA_FGMI06.PNG", "AA_FGMS07.PNG", "AA_FGMS08.PNG", "AA_FGMS09.PNG", "AA_FGMS10.PNG",
            "AA_FGMY11.PNG", "AA_FGMY12.PNG", "AA_FGMY13.PNG", "AA_FGMY14.PNG", "AA_FGMZ12.PNG", "AA_FGMZ13.PNG", "AA_FGMZ14.PNG",
            "AA_FGMZ15.PNG", "AA_FGRM07.PNG", "AA_FGRM12.PNG", "AA_FGRM13.PNG", "AA_FGRM14.PNG", "AA_FGRM15.PNG" };

        private static List<String> filesList_AA_JP = new List<String> { "AA_JP_CGMODEAKBK.PNG", "AA_JP_CGMODEMOBK.PNG", "AA_JP_CGMODEMSBK.PNG",
            "AA_JP_CGMODEMUBK.PNG", "AA_JP_CGMODEMZBK.PNG", "AA_JP_CGMODENNBK.PNG" };

        private static List<String> filesList_AA_EN = new List<String> { "AA_EN_CGMODEAKBK.PNG", "AA_EN_CGMODEMOBK.PNG", "AA_EN_CGMODEMSBK.PNG",
            "AA_EN_CGMODEMUBK.PNG", "AA_EN_CGMODEMZBK.PNG", "AA_EN_CGMODENNBK.PNG" };

        private static List<String> filesList_BCG_AA_JP = new List<String> { "BCG_AA_JP_CGMODEAKBK.PNG", "BCG_AA_JP_CGMODEMOBK.PNG",
            "BCG_AA_JP_CGMODEMSBK.PNG", "BCG_AA_JP_CGMODEMUBK.PNG", "BCG_AA_JP_CGMODEMZBK.PNG", "BCG_AA_JP_CGMODENNBK.PNG" };

        private static List<String> filesList_BCG_AA_EN = new List<String> { "BCG_AA_EN_CGMODEAKBK.PNG", "BCG_AA_EN_CGMODEMOBK.PNG",
            "BCG_AA_EN_CGMODEMSBK.PNG", "BCG_AA_EN_CGMODEMUBK.PNG", "BCG_AA_EN_CGMODEMZBK.PNG", "BCG_AA_EN_CGMODENNBK.PNG" };


        private static void InitializeLists(out List<Entry> patchSNXFilesList, out List<Entry> patchIMGFilesList, ArchiveFileSystem afsPatchFiles)
        {
            patchSNXFilesList = new List<Entry>();
            patchIMGFilesList = new List<Entry>();

            //Full Voice Edition + H-scenes + No Bonus CG + Japanese
            if (inputEdition.Substring(0, 1) == "1" && inputAAContent.Substring(0, 1) == "2" && inputBonusCG.Substring(0, 1) == "2" && inputLanguage.Substring(0, 1) == "1")
            {
                foreach (String entry in filesList_FV_OG) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_FV_OG_JP) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_OG) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_OG_JP) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
            }

            //Full Voice Edition + H-scenes + No Bonus CG + English
            else if (inputEdition.Substring(0, 1) == "1" && inputAAContent.Substring(0, 1) == "2" && inputBonusCG.Substring(0, 1) == "2" && inputLanguage.Substring(0, 1) == "2")
            {
                foreach (String entry in filesList_FV_OG) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_FV_OG_EN) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_OG) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_OG_EN) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
            }

            //Full Voice Edition + H-scenes + Bonus CGs + Japanese
            else if (inputEdition.Substring(0, 1) == "1" && inputAAContent.Substring(0, 1) == "2" && inputBonusCG.Substring(0, 1) == "1" && inputLanguage.Substring(0, 1) == "1")
            {
                foreach (String entry in filesList_FV_BCG) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_FV_BCG_JP) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_JP_MI26.SNX"));
                foreach (String entry in filesList_OG) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_BCG) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_BCG_JP) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
            }

            //Full Voice Edition + H-scenes + Bonus CGs + English
            else if (inputEdition.Substring(0, 1) == "1" && inputAAContent.Substring(0, 1) == "2" && inputBonusCG.Substring(0, 1) == "1" && inputLanguage.Substring(0, 1) == "2")
            {
                foreach (String entry in filesList_FV_BCG) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_FV_BCG_EN) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_EN_MI26.SNX"));
                foreach (String entry in filesList_OG) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_BCG) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_BCG_EN) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
            }

            //Full Voice Edition + All Ages + No Bonus CG + Japanese
            else if (inputEdition.Substring(0, 1) == "1" && inputAAContent.Substring(0, 1) == "1" && inputBonusCG.Substring(0, 1) == "2" && inputLanguage.Substring(0, 1) == "1")
            {
                foreach (String entry in filesList_FV_AA) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_FV_AA_JP) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_JP_DS01.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_JP_DS05.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_JP_DS07.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_JP_DS09.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_JP_DS10_A.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_JP_DS19.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_JP_MS22.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_JP_MS25.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_JP_MS27.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_JP_MY24.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_JP_NV30.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_JP_RM24.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_JP_SBD25N1.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_JP_SBRM14N1.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_JP_SBRM17M1.SNX"));
                foreach (String entry in filesList_AA) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_AA_JP) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_JP_CGMODEAKCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_JP_CGMODEMOCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_JP_CGMODEMSCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_JP_CGMODEMUCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_JP_CGMODEMZCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_JP_CGMODENNCHIP.PNG"));
            }

            //Full Voice Edition + All Ages + No Bonus CG + English
            else if (inputEdition.Substring(0, 1) == "1" && inputAAContent.Substring(0, 1) == "1" && inputBonusCG.Substring(0, 1) == "2" && inputLanguage.Substring(0, 1) == "2")
            {
                foreach (String entry in filesList_FV_AA) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_FV_AA_EN) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_EN_DS01.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_EN_DS05.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_EN_DS07.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_EN_DS09.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_EN_DS10_A.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_EN_DS19.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_EN_MS22.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_EN_MS25.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_EN_MS27.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_EN_MY24.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_EN_NV30.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_EN_RM24.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_EN_SBD25N1.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_EN_SBRM14N1.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_EN_SBRM17M1.SNX"));
                foreach (String entry in filesList_AA) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_AA_EN) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_EN_CGMODEAKCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_EN_CGMODEMOCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_EN_CGMODEMSCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_EN_CGMODEMUCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_EN_CGMODEMZCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_EN_CGMODENNCHIP.PNG"));
            }

            //Full Voice Edition + All Ages + Bonus CG + Japanese
            else if (inputEdition.Substring(0, 1) == "1" && inputAAContent.Substring(0, 1) == "1" && inputBonusCG.Substring(0, 1) == "1" && inputLanguage.Substring(0, 1) == "1")
            {
                foreach (String entry in filesList_FV_BCG_AA) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_FV_BCG_AA_JP) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_JP_DS01.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_JP_DS05.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_JP_DS07.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_JP_DS09.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_JP_DS10_A.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_JP_DS19.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_JP_MS22.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_JP_MS25.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_JP_MS27.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_JP_MY24.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_JP_NV30.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_JP_RM24.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_JP_SBD25N1.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_JP_SBRM14N1.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_JP_SBRM17M1.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_AA_JP_MI26.SNX"));
                foreach (String entry in filesList_BCG) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_AA) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_BCG_AA_JP) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("BCG_JP_CGMODEAKCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("BCG_JP_CGMODEMOCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("BCG_JP_CGMODEMSCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("BCG_JP_CGMODEMUCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("BCG_JP_CGMODEMZCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("BCG_JP_CGMODENNCHIP.PNG"));
            }

            //Full Voice Edition + All Ages + Bonus CG + English
            else if (inputEdition.Substring(0, 1) == "1" && inputAAContent.Substring(0, 1) == "1" && inputBonusCG.Substring(0, 1) == "1" && inputLanguage.Substring(0, 1) == "2")
            {
                foreach (String entry in filesList_FV_BCG_AA) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_FV_BCG_AA_EN) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_EN_DS01.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_EN_DS05.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_EN_DS07.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_EN_DS09.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_EN_DS10_A.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_EN_DS19.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_EN_MS22.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_EN_MS25.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_EN_MS27.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_EN_MY24.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_EN_NV30.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_EN_RM24.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_EN_SBD25N1.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_EN_SBRM14N1.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_EN_SBRM17M1.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_AA_EN_MI26.SNX"));
                foreach (String entry in filesList_BCG) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_AA) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_BCG_AA_EN) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("BCG_EN_CGMODEAKCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("BCG_EN_CGMODEMOCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("BCG_EN_CGMODEMSCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("BCG_EN_CGMODEMUCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("BCG_EN_CGMODEMZCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("BCG_EN_CGMODENNCHIP.PNG"));
            }

            //Vista Edition + H-scenes + No Bonus CG + Japanese
            else if (inputEdition.Substring(0, 1) == "2" && inputAAContent.Substring(0, 1) == "2" && inputBonusCG.Substring(0, 1) == "2" && inputLanguage.Substring(0, 1) == "1")
            {
                foreach (String entry in filesList_VI_OG) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_VI_OG_JP) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_OG) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_OG_JP) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
            }

            //Vista Edition + H-scenes + No Bonus CG + English
            else if (inputEdition.Substring(0, 1) == "2" && inputAAContent.Substring(0, 1) == "2" && inputBonusCG.Substring(0, 1) == "2" && inputLanguage.Substring(0, 1) == "2")
            {
                foreach (String entry in filesList_VI_OG) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_VI_OG_EN) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_OG) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_OG_EN) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
            }

            //Vista Edition + H-scenes + Bonus CGs + Japanese
            else if (inputEdition.Substring(0, 1) == "2" && inputAAContent.Substring(0, 1) == "2" && inputBonusCG.Substring(0, 1) == "1" && inputLanguage.Substring(0, 1) == "1")
            {
                foreach (String entry in filesList_VI_BCG) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_VI_BCG_JP) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_JP_MI26.SNX"));
                foreach (String entry in filesList_OG) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_BCG) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_BCG_JP) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
            }

            //Vista Edition + H-scenes + Bonus CGs + English
            else if (inputEdition.Substring(0, 1) == "2" && inputAAContent.Substring(0, 1) == "2" && inputBonusCG.Substring(0, 1) == "1" && inputLanguage.Substring(0, 1) == "2")
            {
                foreach (String entry in filesList_VI_BCG) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_VI_BCG_EN) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_EN_MI26.SNX"));
                foreach (String entry in filesList_OG) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_BCG) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_BCG_EN) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
            }

            //Vista Edition + All Ages + No Bonus CG + Japanese
            else if (inputEdition.Substring(0, 1) == "2" && inputAAContent.Substring(0, 1) == "1" && inputBonusCG.Substring(0, 1) == "2" && inputLanguage.Substring(0, 1) == "1")
            {
                foreach (String entry in filesList_VI_AA) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_VI_AA_JP) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_JP_DS01.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_JP_DS05.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_JP_DS07.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_JP_DS09.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_JP_DS10_A.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_JP_DS19.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_JP_MS22.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_JP_MS25.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_JP_MS27.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_JP_MY24.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_JP_NV30.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_JP_RM24.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_JP_SBD25N1.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_JP_SBRM14N1.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_JP_SBRM17M1.SNX"));
                foreach (String entry in filesList_AA) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_AA_JP) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_JP_CGMODEAKCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_JP_CGMODEMOCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_JP_CGMODEMSCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_JP_CGMODEMUCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_JP_CGMODEMZCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_JP_CGMODENNCHIP.PNG"));
            }

            //Vista Edition + All Ages + No Bonus CG + English
            else if (inputEdition.Substring(0, 1) == "2" && inputAAContent.Substring(0, 1) == "1" && inputBonusCG.Substring(0, 1) == "2" && inputLanguage.Substring(0, 1) == "2")
            {
                foreach (String entry in filesList_VI_AA) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_VI_AA_EN) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_EN_DS01.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_EN_DS05.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_EN_DS07.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_EN_DS09.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_EN_DS10_A.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_EN_DS19.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_EN_MS22.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_EN_MS25.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_EN_MS27.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_EN_MY24.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_EN_NV30.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_EN_RM24.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_EN_SBD25N1.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_EN_SBRM14N1.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_EN_SBRM17M1.SNX"));
                foreach (String entry in filesList_AA) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_AA_EN) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_EN_CGMODEAKCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_EN_CGMODEMOCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_EN_CGMODEMSCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_EN_CGMODEMUCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_EN_CGMODEMZCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_EN_CGMODENNCHIP.PNG"));
            }

            //Vista Edition + All Ages + Bonus CG + Japanese
            else if (inputEdition.Substring(0, 1) == "2" && inputAAContent.Substring(0, 1) == "1" && inputBonusCG.Substring(0, 1) == "1" && inputLanguage.Substring(0, 1) == "1")
            {
                foreach (String entry in filesList_VI_BCG_AA) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_VI_BCG_AA_JP) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_BCG_JP_DS01.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_BCG_JP_DS05.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_BCG_JP_DS07.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_BCG_JP_DS09.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_BCG_JP_DS10_A.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_BCG_JP_DS19.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_BCG_JP_MS22.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_BCG_JP_MS25.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_BCG_JP_MS27.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_BCG_JP_MY24.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_BCG_JP_NV30.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_BCG_JP_RM24.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_BCG_JP_SBD25N1.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_BCG_JP_SBRM14N1.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_BCG_JP_SBRM17M1.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_AA_JP_MI26.SNX"));
                foreach (String entry in filesList_BCG) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_AA) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_BCG_AA_JP) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("BCG_JP_CGMODEAKCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("BCG_JP_CGMODEMOCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("BCG_JP_CGMODEMSCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("BCG_JP_CGMODEMUCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("BCG_JP_CGMODEMZCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("BCG_JP_CGMODENNCHIP.PNG"));
            }

            //Vista Edition + All Ages + Bonus CG + English
            else if (inputEdition.Substring(0, 1) == "2" && inputAAContent.Substring(0, 1) == "1" && inputBonusCG.Substring(0, 1) == "1" && inputLanguage.Substring(0, 1) == "2")
            {
                foreach (String entry in filesList_VI_BCG_AA) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_VI_BCG_AA_EN) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_BCG_EN_DS01.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_BCG_EN_DS05.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_BCG_EN_DS07.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_BCG_EN_DS09.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_BCG_EN_DS10_A.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_BCG_EN_DS19.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_BCG_EN_MS22.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_BCG_EN_MS25.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_BCG_EN_MS27.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_BCG_EN_MY24.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_BCG_EN_NV30.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_BCG_EN_RM24.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_BCG_EN_SBD25N1.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_BCG_EN_SBRM14N1.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_BCG_EN_SBRM17M1.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_AA_EN_MI26.SNX"));
                foreach (String entry in filesList_BCG) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_AA) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_BCG_AA_EN) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("BCG_EN_CGMODEAKCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("BCG_EN_CGMODEMOCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("BCG_EN_CGMODEMSCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("BCG_EN_CGMODEMUCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("BCG_EN_CGMODEMZCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("BCG_EN_CGMODENNCHIP.PNG"));
            }
        }


        public static void Main(string[] args)
        {
            Console.WriteLine("ONE Eternal Patch v1.1");
            Console.WriteLine("developed by Sep7\n");

            //////////
            //INPUTS
            //////////
            inputEdition = string.Empty;
            do
            {
                Console.WriteLine("Enter 1 if you want to patch the Full Voice Edition.");
                Console.WriteLine("Enter 2 if you want to patch the Vista Edition.");

                inputEdition = Console.ReadLine();

                if (inputEdition.Length != 1 || (inputEdition.Substring(0, 1) != "1" && inputEdition.Substring(0, 1) != "2"))
                {
                    Console.WriteLine("Syntax Error.\n");
                }
            } while (inputEdition.Length != 1 || (inputEdition.Substring(0, 1) != "1" && inputEdition.Substring(0, 1) != "2"));

            inputLanguage = string.Empty;
            do
            {
                Console.WriteLine("\nEnter 1 if you want to patch the Japanese Version.");
                Console.WriteLine("Enter 2 if you want to patch the English translated Version.");

                inputLanguage = Console.ReadLine();

                if (inputLanguage.Length != 1 || (inputLanguage.Substring(0, 1) != "1" && inputLanguage.Substring(0, 1) != "2"))
                {
                    Console.WriteLine("Syntax Error.\n");
                }
            } while (inputLanguage.Length != 1 || (inputLanguage.Substring(0, 1) != "1" && inputLanguage.Substring(0, 1) != "2"));

            inputBonusCG = string.Empty;
            do
            {
                Console.WriteLine("\nEnter 1 if you want to add the bonus CGs.");
                Console.WriteLine("Enter 2 if you don't want them.");

                inputBonusCG = Console.ReadLine();

                if (inputBonusCG.Length != 1 || (inputBonusCG.Substring(0, 1) != "1" && inputBonusCG.Substring(0, 1) != "2"))
                {
                    Console.WriteLine("Syntax Error.");
                }
            } while (inputBonusCG.Length != 1 || (inputBonusCG.Substring(0, 1) != "1" && inputBonusCG.Substring(0, 1) != "2"));

            inputAAContent = string.Empty;
            do
            {
                Console.WriteLine("\nEnter 1 if you want to remove the H-scenes (beta).");
                Console.WriteLine("Enter 2 if you want to have the H-scenes.");

                inputAAContent = Console.ReadLine();

                if (inputAAContent.Length != 1 || (inputAAContent.Substring(0, 1) != "1" && inputAAContent.Substring(0, 1) != "2"))
                {
                    Console.WriteLine("Syntax Error.");
                }
            } while (inputAAContent.Length != 1 || (inputAAContent.Substring(0, 1) != "1" && inputAAContent.Substring(0, 1) != "2"));

            Console.WriteLine("\n");

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

            InitializeLists(out List<Entry> patchSNXFilesList, out List<Entry> patchIMGFilesList, afsPatchFiles);

            List<String> prefixList = new List<String> { "FV_OG_JP_", "FV_OG_EN_", "FV_OG_",
            "FV_BCG_AA_JP_", "FV_BCG_AA_EN_", "FV_BCG_AA_",
            "FV_BCG_JP_", "FV_BCG_EN_", "FV_BCG_",
            "FV_AA_JP_", "FV_AA_EN_", "FV_AA_",
            "VI_OG_JP_", "VI_OG_EN_", "VI_OG_",
            "VI_BCG_AA_JP_", "VI_BCG_AA_EN_", "VI_BCG_AA_",
            "VI_BCG_JP_", "VI_BCG_EN_", "VI_BCG_",
            "VI_AA_JP_", "VI_AA_EN_", "VI_AA_",
            "OG_JP_", "OG_EN_", "OG_",
            "BCG_AA_JP_", "BCG_AA_EN_",
            "BCG_JP_", "BCG_EN_", "BCG_",
            "AA_JP_", "AA_EN_", "AA_" };

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

            //The list in then sorted by type
            patchFilesList.AddRange(sortedSNX);
            patchFilesList.AddRange(sortedIMG);


            //This file only exists in the English translated version and is placed at the end of the archive for some reasons.
            //I'm pretty sure it's a mistake of the TL team but I prefer to update it, just in case.
            if (inputLanguage.Substring(0, 1) == "2")
            {
                if (inputAAContent.Substring(0, 1) == "1" && inputBonusCG.Substring(0, 1) == "1") {
                    patchFilesList.Add(afsPatchFiles.FindFile("BCG_AA_EN_CGMODEAKMU.PNG"));
                }
                else if (inputAAContent.Substring(0, 1) == "1" && inputBonusCG.Substring(0, 1) == "2") {
                    patchFilesList.Add(afsPatchFiles.FindFile("AA_EN_CGMODEAKMU.PNG"));
                }
                else if (inputAAContent.Substring(0, 1) == "2" && inputBonusCG.Substring(0, 1) == "1") {
                    patchFilesList.Add(afsPatchFiles.FindFile("BCG_EN_CGMODEAKMU.PNG"));
                }
                else if (inputAAContent.Substring(0, 1) == "2" && inputBonusCG.Substring(0, 1) == "2") {
                    patchFilesList.Add(afsPatchFiles.FindFile("OG_EN_CGMODEAKMU.PNG"));
                }

                patchFilesList.Last().Name = "CGMODEAKMU.PNG";
            }

            List<String> filesListToNotUpdate = new List<String> { "BG400.PNG", "FGAK17.PNG", "FGAK18.PNG",
            "FGMI17.PNG", "FGMI18.PNG", "FGMI19.PNG", "FGMS18.PNG", "FGMS19.PNG", "FGMY16.PNG", "FGMY17.PNG",
            "FGMZ17.PNG", "FGMZ18.PNG", "FGRM16.PNG", "FGRM17.PNG", "FGRM18.PNG" };

            //////////////////////////////
            //EXTRACTING OF THE ORIGINAL FILES
            //////////////////////////////
            string originalFileName = inputEdition.Substring(0, 1) == "1" ? "one" : "lcsebody1";
            try
            {
                originalFile = new ArcView("./" + originalFileName);
            }
            catch (System.IO.FileNotFoundException e)
            {
                Console.WriteLine("\nError: the file \"" + originalFileName + "\" was not found.\n" +
                    "Make sure to place it in the same directory as the executable.\n\n" +
                    "Error details: " + e +
                    "\n\nPress any key to continue.");
                Console.ReadKey(true);
                System.Environment.Exit(1);
            }
            catch (System.UnauthorizedAccessException e)
            {
                Console.WriteLine("\nError: the file \"" + originalFileName + "\" can't be accessed.\n" +
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
                Console.WriteLine("\nError: the file \"" + originalFileName + ".lst\" can't be accessed.\n" +
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
                Console.WriteLine("\nError: the file \"" + originalFileName + ".lst\" was not found.\n" +
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
                        byteTempo = byteTempo ^ keySNX;
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
            File.SetAttributes(originalFileName, FileAttributes.Normal);
            File.SetAttributes(originalFileName + ".lst", FileAttributes.Normal);

            File.Delete(originalFileName);
            File.Delete(originalFileName + ".lst");

            File.Move("one_TEMP", originalFileName);
            File.Move("one_TEMP.lst", originalFileName + ".lst");

            Console.WriteLine("\nDone!");
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey(true);
        }
    }
}
