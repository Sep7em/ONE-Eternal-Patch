using System;
using System.Collections.Generic;
using GameRes;

namespace ONE_Eternal_Patch
{
    public class Files_Lists
    {
        //Scripts lists
        private static List<String> filesList_FV_OG = new List<String> { "FV_OG_CGMODE.SNX", "FV_OG_CGMODEAK.SNX", "FV_OG_CGMODEMO.SNX",
            "FV_OG_CGMODEMS.SNX", "FV_OG_CGMODEMU.SNX", "FV_OG_CGMODEMZ.SNX", "FV_OG_CGMODENN.SNX", "FV_OG_NECEMEM.SNX" };

        private static List<String> filesList_VI_OG = new List<String> { "VI_OG_CGMODE.SNX", "VI_OG_CGMODEAK.SNX", "VI_OG_CGMODEMO.SNX",
            "VI_OG_CGMODEMS.SNX", "VI_OG_CGMODEMU.SNX", "VI_OG_CGMODEMZ.SNX", "VI_OG_CGMODENN.SNX" };

        private static List<String> filesList_FV_OG_JP = new List<String> { "FV_OG_JP_AK26.SNX", "FV_OG_JP_DS01.SNX", "FV_OG_JP_DS05.SNX",
            "FV_OG_JP_DS07.SNX", "FV_OG_JP_DS09.SNX", "FV_OG_JP_DS10_A.SNX", "FV_OG_JP_DS18.SNX", "FV_OG_JP_DS19.SNX",
            "FV_OG_JP_DS22.SNX", "FV_OG_JP_DS24.SNX", "FV_OG_JP_MI26.SNX", "FV_OG_JP_MS22.SNX", "FV_OG_JP_MS25.SNX",
            "FV_OG_JP_MS27.SNX", "FV_OG_JP_MY24.SNX", "FV_OG_JP_NV30.SNX", "FV_OG_JP_RM24.SNX", "FV_OG_JP_SBD25N1.SNX",
            "FV_OG_JP_SBRM14N1.SNX", "FV_OG_JP_SBRM17M1.SNX" };

        private static List<String> filesList_FV_OG_EN = new List<String> { "FV_OG_EN_AK26.SNX", "FV_OG_EN_DS01.SNX", "FV_OG_EN_DS05.SNX",
            "FV_OG_EN_DS07.SNX", "FV_OG_EN_DS09.SNX", "FV_OG_EN_DS10_A.SNX", "FV_OG_EN_DS18.SNX", "FV_OG_EN_DS19.SNX",
            "FV_OG_EN_DS22.SNX", "FV_OG_EN_DS24.SNX", "FV_OG_EN_MI26.SNX", "FV_OG_EN_MS22.SNX", "FV_OG_EN_MS25.SNX",
            "FV_OG_EN_MS27.SNX", "FV_OG_EN_MY24.SNX", "FV_OG_EN_NV30.SNX", "FV_OG_EN_RM24.SNX", "FV_OG_EN_SBD25N1.SNX",
            "FV_OG_EN_SBRM14N1.SNX", "FV_OG_EN_SBRM17M1.SNX" };

        private static List<String> filesList_FV_OG_SP = new List<String> { "FV_OG_SP_AK26.SNX", "FV_OG_SP_DS01.SNX", "FV_OG_SP_DS05.SNX",
            "FV_OG_SP_DS07.SNX", "FV_OG_SP_DS09.SNX", "FV_OG_SP_DS10_A.SNX", "FV_OG_SP_DS19.SNX", "FV_OG_SP_MI26.SNX",
            "FV_OG_SP_MS22.SNX", "FV_OG_SP_MS25.SNX", "FV_OG_SP_MS27.SNX", "FV_OG_SP_MY24.SNX", "FV_OG_SP_NV30.SNX",
            "FV_OG_SP_RM24.SNX", "FV_OG_SP_SBD25N1.SNX", "FV_OG_SP_SBRM14N1.SNX", "FV_OG_SP_SBRM17M1.SNX" };

        private static List<String> filesList_FV_OG_CH = new List<String> { "FV_OG_CH_AK26.SNX", "FV_OG_CH_DS01.SNX", "FV_OG_CH_DS05.SNX",
            "FV_OG_CH_DS07.SNX", "FV_OG_CH_DS09.SNX", "FV_OG_CH_DS10_A.SNX", "FV_OG_CH_DS18.SNX", "FV_OG_CH_DS19.SNX",
            "FV_OG_CH_DS22.SNX", "FV_OG_CH_DS24.SNX", "FV_OG_CH_MI26.SNX", "FV_OG_CH_MS22.SNX", "FV_OG_CH_MS25.SNX",
            "FV_OG_CH_MS27.SNX", "FV_OG_CH_MY24.SNX", "FV_OG_CH_NV30.SNX", "FV_OG_CH_RM24.SNX", "FV_OG_CH_SBD25N1.SNX",
            "FV_OG_CH_SBRM14N1.SNX", "FV_OG_CH_SBRM17M1.SNX" };

        private static List<String> filesList_VI_OG_JP = new List<String> { "VI_OG_JP_AK26.SNX", "VI_OG_JP_DS01.SNX", "VI_OG_JP_DS05.SNX",
            "VI_OG_JP_DS07.SNX", "VI_OG_JP_DS09.SNX", "VI_OG_JP_DS10_A.SNX", "VI_OG_JP_DS18.SNX", "VI_OG_JP_DS19.SNX",
            "VI_OG_JP_DS22.SNX", "VI_OG_JP_DS24.SNX", "VI_OG_JP_MI26.SNX", "VI_OG_JP_MS22.SNX", "VI_OG_JP_MS25.SNX",
            "VI_OG_JP_MS27.SNX", "VI_OG_JP_MY24.SNX", "VI_OG_JP_NV30.SNX", "VI_OG_JP_RM24.SNX", "VI_OG_JP_SBD25N1.SNX",
            "VI_OG_JP_SBRM14N1.SNX", "VI_OG_JP_SBRM17M1.SNX" };

        private static List<String> filesList_VI_OG_EN = new List<String> { "VI_OG_EN_AK26.SNX", "VI_OG_EN_DS01.SNX", "VI_OG_EN_DS05.SNX",
            "VI_OG_EN_DS07.SNX", "VI_OG_EN_DS09.SNX", "VI_OG_EN_DS10_A.SNX", "VI_OG_EN_DS18.SNX", "VI_OG_EN_DS19.SNX",
            "VI_OG_EN_DS22.SNX", "VI_OG_EN_DS24.SNX", "VI_OG_EN_MI26.SNX", "VI_OG_EN_MS22.SNX", "VI_OG_EN_MS25.SNX",
            "VI_OG_EN_MS27.SNX", "VI_OG_EN_MY24.SNX", "VI_OG_EN_NV30.SNX", "VI_OG_EN_RM24.SNX", "VI_OG_EN_SBD25N1.SNX",
            "VI_OG_EN_SBRM14N1.SNX", "VI_OG_EN_SBRM17M1.SNX" };

        private static List<String> filesList_FV_PS1 = new List<String> { "FV_PS1_CGMODE.SNX", "FV_PS1_CGMODEAK.SNX", "FV_PS1_CGMODEMO.SNX",
            "FV_PS1_CGMODEMS.SNX", "FV_PS1_CGMODEMU.SNX", "FV_PS1_CGMODEMZ.SNX", "FV_PS1_CGMODENA.SNX", "FV_PS1_CGMODENN.SNX",
            "FV_PS1_NECEMEM.SNX" };

        private static List<String> filesList_VI_PS1 = new List<String> { "VI_PS1_CGMODE.SNX", "VI_PS1_CGMODEAK.SNX", "VI_PS1_CGMODEMO.SNX",
            "VI_PS1_CGMODEMS.SNX", "VI_PS1_CGMODEMU.SNX", "VI_PS1_CGMODEMZ.SNX", "VI_PS1_CGMODENA.SNX", "VI_PS1_CGMODENN.SNX" };

        private static List<String> filesList_FV_PS1_JP = new List<String> { "FV_PS1_JP_AK26.SNX", "FV_PS1_JP_DS01.SNX", "FV_PS1_JP_DS05.SNX",
            "FV_PS1_JP_DS07.SNX", "FV_PS1_JP_DS09.SNX", "FV_PS1_JP_DS10_A.SNX", "FV_PS1_JP_DS18.SNX", "FV_PS1_JP_DS19.SNX",
            "FV_PS1_JP_DS22.SNX", "FV_PS1_JP_DS24.SNX", "FV_PS1_JP_MS22.SNX", "FV_PS1_JP_MS25.SNX", "FV_PS1_JP_MS27.SNX",
            "FV_PS1_JP_MY24.SNX", "FV_PS1_JP_NA18.SNX", "FV_PS1_JP_NA22.SNX", "FV_PS1_JP_NA24.SNX", "FV_PS1_JP_NA25.SNX",
            "FV_PS1_JP_NA27.SNX", "FV_PS1_JP_NAE.SNX", "FV_PS1_JP_NV30.SNX", "FV_PS1_JP_RM24.SNX", "FV_PS1_JP_SBD25N1.SNX",
            "FV_PS1_JP_SBRM14N1.SNX", "FV_PS1_JP_SBRM17M1.SNX" };

        private static List<String> filesList_FV_PS1_EN = new List<String> { "FV_PS1_EN_AK26.SNX", "FV_PS1_EN_DS01.SNX", "FV_PS1_EN_DS05.SNX",
            "FV_PS1_EN_DS07.SNX", "FV_PS1_EN_DS09.SNX", "FV_PS1_EN_DS10_A.SNX", "FV_PS1_EN_DS18.SNX", "FV_PS1_EN_DS19.SNX",
            "FV_PS1_EN_DS22.SNX", "FV_PS1_EN_DS24.SNX", "FV_PS1_EN_MS22.SNX", "FV_PS1_EN_MS25.SNX", "FV_PS1_EN_MS27.SNX",
            "FV_PS1_EN_MY24.SNX", "FV_PS1_EN_NA18.SNX", "FV_PS1_EN_NA22.SNX", "FV_PS1_EN_NA24.SNX", "FV_PS1_EN_NA25.SNX",
            "FV_PS1_EN_NA27.SNX", "FV_PS1_EN_NAE.SNX", "FV_PS1_EN_NV30.SNX", "FV_PS1_EN_RM24.SNX", "FV_PS1_EN_SBD25N1.SNX",
            "FV_PS1_EN_SBRM14N1.SNX", "FV_PS1_EN_SBRM17M1.SNX" };

        private static List<String> filesList_FV_PS1_SP = new List<String> { "FV_PS1_SP_AK26.SNX", "FV_PS1_SP_DS01.SNX", "FV_PS1_SP_DS05.SNX",
            "FV_PS1_SP_DS07.SNX", "FV_PS1_SP_DS09.SNX", "FV_PS1_SP_DS10_A.SNX", "FV_PS1_SP_DS19.SNX", "FV_PS1_SP_MS22.SNX",
            "FV_PS1_SP_MS25.SNX", "FV_PS1_SP_MS27.SNX", "FV_PS1_SP_MY24.SNX", "FV_PS1_SP_NV30.SNX", "FV_PS1_SP_RM24.SNX",
            "FV_PS1_SP_SBD25N1.SNX", "FV_PS1_SP_SBRM14N1.SNX", "FV_PS1_SP_SBRM17M1.SNX" };

        private static List<String> filesList_FV_PS1_CH = new List<String> { "FV_PS1_CH_AK26.SNX", "FV_PS1_CH_DS01.SNX", "FV_PS1_CH_DS05.SNX",
            "FV_PS1_CH_DS07.SNX", "FV_PS1_CH_DS09.SNX", "FV_PS1_CH_DS10_A.SNX", "FV_PS1_CH_DS19.SNX", "FV_PS1_CH_MS22.SNX",
            "FV_PS1_CH_MS25.SNX", "FV_PS1_CH_MS27.SNX", "FV_PS1_CH_MY24.SNX", "FV_PS1_CH_NV30.SNX", "FV_PS1_CH_RM24.SNX",
            "FV_PS1_CH_SBD25N1.SNX", "FV_PS1_CH_SBRM14N1.SNX", "FV_PS1_CH_SBRM17M1.SNX" };

        private static List<String> filesList_VI_PS1_JP = new List<String> { "VI_PS1_JP_AK26.SNX", "VI_PS1_JP_DS01.SNX", "VI_PS1_JP_DS05.SNX",
            "VI_PS1_JP_DS07.SNX", "VI_PS1_JP_DS09.SNX", "VI_PS1_JP_DS10_A.SNX", "VI_PS1_JP_DS18.SNX", "VI_PS1_JP_DS19.SNX",
            "VI_PS1_JP_DS22.SNX", "VI_PS1_JP_DS24.SNX", "VI_PS1_JP_MS22.SNX", "VI_PS1_JP_MS25.SNX", "VI_PS1_JP_MS27.SNX",
            "VI_PS1_JP_MY24.SNX", "VI_PS1_JP_NA18.SNX", "VI_PS1_JP_NA22.SNX", "VI_PS1_JP_NA24.SNX", "VI_PS1_JP_NA25.SNX",
            "VI_PS1_JP_NA27.SNX", "VI_PS1_JP_NAE.SNX", "VI_PS1_JP_NV30.SNX", "VI_PS1_JP_RM24.SNX", "VI_PS1_JP_SBD25N1.SNX",
            "VI_PS1_JP_SBRM14N1.SNX", "VI_PS1_JP_SBRM17M1.SNX" };

        private static List<String> filesList_VI_PS1_EN = new List<String> { "VI_PS1_EN_AK26.SNX", "VI_PS1_EN_DS01.SNX", "VI_PS1_EN_DS05.SNX",
            "VI_PS1_EN_DS07.SNX", "VI_PS1_EN_DS09.SNX", "VI_PS1_EN_DS10_A.SNX", "VI_PS1_EN_DS18.SNX", "VI_PS1_EN_DS19.SNX",
            "VI_PS1_EN_DS22.SNX", "VI_PS1_EN_DS24.SNX", "VI_PS1_EN_MS22.SNX", "VI_PS1_EN_MS25.SNX", "VI_PS1_EN_MS27.SNX",
            "VI_PS1_EN_MY24.SNX", "VI_PS1_EN_NA18.SNX", "VI_PS1_EN_NA22.SNX", "VI_PS1_EN_NA24.SNX", "VI_PS1_EN_NA25.SNX",
            "VI_PS1_EN_NA27.SNX", "VI_PS1_EN_NAE.SNX", "VI_PS1_EN_NV30.SNX", "VI_PS1_EN_RM24.SNX", "VI_PS1_EN_SBD25N1.SNX",
            "VI_PS1_EN_SBRM14N1.SNX", "VI_PS1_EN_SBRM17M1.SNX" };

        private static List<String> filesList_FV_AA = new List<String> { "FV_AA_CGMODEAK.SNX", "FV_AA_CGMODEMO.SNX", "FV_AA_CGMODEMS.SNX",
            "FV_AA_CGMODEMU.SNX", "FV_AA_CGMODEMZ.SNX", "FV_AA_CGMODENN.SNX" };

        private static List<String> filesList_VI_AA = new List<String> { "VI_AA_CGMODEAK.SNX", "VI_AA_CGMODEMO.SNX", "VI_AA_CGMODEMS.SNX",
            "VI_AA_CGMODEMU.SNX", "VI_AA_CGMODEMZ.SNX", "VI_AA_CGMODENN.SNX" };

        private static List<String> filesList_FV_AA_JP = new List<String> { "FV_AA_JP_AK26.SNX", "FV_AA_JP_MI26.SNX" };

        private static List<String> filesList_FV_AA_EN = new List<String> { "FV_AA_EN_AK26.SNX", "FV_AA_EN_MI26.SNX" };

        private static List<String> filesList_FV_AA_SP = new List<String> { "FV_AA_SP_AK26.SNX", "FV_AA_SP_MI26.SNX" };

        private static List<String> filesList_FV_AA_CH = new List<String> { "FV_AA_CH_AK26.SNX", "FV_AA_CH_MI26.SNX" };

        private static List<String> filesList_VI_AA_JP = new List<String> { "VI_AA_JP_AK26.SNX", "VI_AA_JP_MI26.SNX" };

        private static List<String> filesList_VI_AA_EN = new List<String> { "VI_AA_EN_AK26.SNX", "VI_AA_EN_MI26.SNX" };

        private static List<String> filesList_FV_PS1_AA = new List<String> { "FV_PS1_AA_CGMODEAK.SNX", "FV_PS1_AA_CGMODEMO.SNX", "FV_PS1_AA_CGMODEMS.SNX",
            "FV_PS1_AA_CGMODEMU.SNX", "FV_PS1_AA_CGMODEMZ.SNX", "FV_PS1_AA_CGMODENN.SNX" };

        private static List<String> filesList_VI_PS1_AA = new List<String> { "VI_PS1_AA_CGMODEAK.SNX", "VI_PS1_AA_CGMODEMO.SNX", "VI_PS1_AA_CGMODEMS.SNX",
            "VI_PS1_AA_CGMODEMU.SNX", "VI_PS1_AA_CGMODEMZ.SNX", "VI_PS1_AA_CGMODENN.SNX" };

        private static List<String> filesList_FV_PS1_AA_JP = new List<String> { "FV_PS1_AA_JP_AK26.SNX" };

        private static List<String> filesList_FV_PS1_AA_EN = new List<String> { "FV_PS1_AA_EN_AK26.SNX" };

        private static List<String> filesList_FV_PS1_AA_SP = new List<String> { "FV_PS1_AA_SP_AK26.SNX" };

        private static List<String> filesList_FV_PS1_AA_CH = new List<String> { "FV_PS1_AA_CH_AK26.SNX" };

        private static List<String> filesList_VI_PS1_AA_JP = new List<String> { "VI_PS1_AA_JP_AK26.SNX" };

        private static List<String> filesList_VI_PS1_AA_EN = new List<String> { "VI_PS1_AA_EN_AK26.SNX" };


        //Images Lists
        private static List<String> filesList_OG = new List<String> { "OG_FGAK12.PNG", "OG_FGAK13.PNG", "OG_FGAK14.PNG", "OG_FGAK15.PNG", 
            "OG_FGMI03.PNG", "OG_FGMI04.PNG", "OG_FGMI05.PNG", "OG_FGMI06.PNG", "OG_FGMS07.PNG", "OG_FGMS08.PNG", "OG_FGMS09.PNG", "OG_FGMS10.PNG", 
            "OG_FGMY11.PNG", "OG_FGMY12.PNG", "OG_FGMY13.PNG", "OG_FGMY14.PNG", "OG_FGMZ12.PNG", "OG_FGMZ13.PNG", "OG_FGMZ14.PNG", "OG_FGMZ15.PNG",
            "OG_FGRM07.PNG", "OG_FGRM12.PNG", "OG_FGRM13.PNG", "OG_FGRM14.PNG", "OG_FGRM15.PNG" };

        private static List<String> filesList_OG_JP = new List<String> { "OG_JP_CGMODEAKBK.PNG", "OG_JP_CGMODEAKCHIP.PNG", "OG_JP_CGMODEMOBK.PNG",
            "OG_JP_CGMODEMOCHIP.PNG", "OG_JP_CGMODEMSBK.PNG", "OG_JP_CGMODEMSCHIP.PNG", "OG_JP_CGMODEMUBK.PNG", "OG_JP_CGMODEMUCHIP.PNG",
            "OG_JP_CGMODEMZBK.PNG", "OG_JP_CGMODEMZCHIP.PNG", "OG_JP_CGMODENNBK.PNG", "OG_JP_CGMODENNCHIP.PNG", "OG_JP_CGMODETOPMENUAK.PNG",
            "OG_JP_CGMODETOPMENUBK.PNG", "OG_JP_CGMODETOPMENUCHIP.PNG", "OG_JP_CGMODETOPMENUMO.PNG", "OG_JP_CGMODETOPMENUMS.PNG",
            "OG_JP_CGMODETOPMENUMU.PNG", "OG_JP_CGMODETOPMENUMZ.PNG", "OG_JP_CGMODETOPMENUNN.PNG" };

        private static List<String> filesList_OG_EN = new List<String> { "OG_EN_CGMODEAKBK.PNG", "OG_EN_CGMODEAKCHIP.PNG", "OG_EN_CGMODEMOBK.PNG",
            "OG_EN_CGMODEMOCHIP.PNG", "OG_EN_CGMODEMSBK.PNG", "OG_EN_CGMODEMSCHIP.PNG", "OG_EN_CGMODEMUBK.PNG", "OG_EN_CGMODEMUCHIP.PNG",
            "OG_EN_CGMODEMZBK.PNG", "OG_EN_CGMODEMZCHIP.PNG", "OG_EN_CGMODENNBK.PNG", "OG_EN_CGMODENNCHIP.PNG", "OG_EN_CGMODETOPMENUAK.PNG",
            "OG_EN_CGMODETOPMENUBK.PNG", "OG_EN_CGMODETOPMENUCHIP.PNG", "OG_EN_CGMODETOPMENUMO.PNG", "OG_EN_CGMODETOPMENUMS.PNG",
            "OG_EN_CGMODETOPMENUMU.PNG", "OG_EN_CGMODETOPMENUMZ.PNG", "OG_EN_CGMODETOPMENUNN.PNG" };

        private static List<String> filesList_OG_SP = new List<String> { "OG_SP_CGMODEAKBK.PNG", "OG_SP_CGMODEAKCHIP.PNG", "OG_SP_CGMODEMOBK.PNG",
            "OG_SP_CGMODEMOCHIP.PNG", "OG_SP_CGMODEMSBK.PNG", "OG_SP_CGMODEMSCHIP.PNG", "OG_SP_CGMODEMUBK.PNG", "OG_SP_CGMODEMUCHIP.PNG",
            "OG_SP_CGMODEMZBK.PNG", "OG_SP_CGMODEMZCHIP.PNG", "OG_SP_CGMODENNBK.PNG", "OG_SP_CGMODENNCHIP.PNG" };

        private static List<String> filesList_OG_CH = new List<String> { "OG_CH_CGMODEAKBK.PNG", "OG_CH_CGMODEAKCHIP.PNG", "OG_CH_CGMODEMOBK.PNG",
            "OG_CH_CGMODEMOCHIP.PNG", "OG_CH_CGMODEMSBK.PNG", "OG_CH_CGMODEMSCHIP.PNG", "OG_CH_CGMODEMUBK.PNG", "OG_CH_CGMODEMUCHIP.PNG",
            "OG_CH_CGMODEMZBK.PNG", "OG_CH_CGMODEMZCHIP.PNG", "OG_CH_CGMODENNBK.PNG", "OG_CH_CGMODENNCHIP.PNG", "OG_CH_CGMODETOPMENUAK.PNG",
            "OG_CH_CGMODETOPMENUBK.PNG", "OG_CH_CGMODETOPMENUCHIP.PNG", "OG_CH_CGMODETOPMENUMO.PNG", "OG_CH_CGMODETOPMENUMS.PNG",
            "OG_CH_CGMODETOPMENUMU.PNG", "OG_CH_CGMODETOPMENUMZ.PNG", "OG_CH_CGMODETOPMENUNN.PNG" };

        private static List<String> filesList_PS1 = new List<String> { "PS1_BG400.PNG", "PS1_CGNA01.PNG", "PS1_CGNA01M.PNG", "PS1_CGNA02.PNG",
            "PS1_CGNA02M.PNG", "PS1_CGNA03.PNG", "PS1_CGNA03M.PNG", "PS1_CGNA04.PNG", "PS1_CGNA04M.PNG", "PS1_CGNA05.PNG", "PS1_CGNA05M.PNG", 
            "PS1_FGAK17.PNG", "PS1_FGAK18.PNG", "PS1_FGMI17.PNG", "PS1_FGMI18.PNG", "PS1_FGMI19.PNG", "PS1_FGMS18.PNG", "PS1_FGMS19.PNG",
            "PS1_FGMY16.PNG", "PS1_FGMY17.PNG", "PS1_FGMZ17.PNG", "PS1_FGMZ18.PNG", "PS1_FGNA01A.PNG", "PS1_FGNA01B.PNG", "PS1_FGNA02.PNG",
            "PS1_FGNA03.PNG", "PS1_FGNA04.PNG", "PS1_FGNA05.PNG", "PS1_FGNA06.PNG", "PS1_FGNA07.PNG", "PS1_FGNA08.PNG", "PS1_FGNA09.PNG",
            "PS1_FGRM16.PNG", "PS1_FGRM17.PNG", "PS1_FGRM18.PNG" };

        private static List<String> filesList_PS1_JP = new List<String> { "PS1_JP_CGMODEAKBK.PNG", "PS1_JP_CGMODEAKCHIP.PNG", "PS1_JP_CGMODEMOBK.PNG",
            "PS1_JP_CGMODEMOCHIP.PNG", "PS1_JP_CGMODEMSBK.PNG", "PS1_JP_CGMODEMSCHIP.PNG", "PS1_JP_CGMODEMUBK.PNG", "PS1_JP_CGMODEMUCHIP.PNG",
            "PS1_JP_CGMODEMZBK.PNG", "PS1_JP_CGMODEMZCHIP.PNG", "PS1_JP_CGMODENABK.PNG", "PS1_JP_CGMODENACHIP.PNG", "PS1_JP_CGMODENNBK.PNG",
            "PS1_JP_CGMODENNCHIP.PNG", "PS1_JP_CGMODETOPMENUAK.PNG", "PS1_JP_CGMODETOPMENUBK.PNG", "PS1_JP_CGMODETOPMENUCHIP.PNG",
            "PS1_JP_CGMODETOPMENUMO.PNG", "PS1_JP_CGMODETOPMENUMS.PNG", "PS1_JP_CGMODETOPMENUMU.PNG", "PS1_JP_CGMODETOPMENUMZ.PNG",
            "PS1_JP_CGMODETOPMENUNA.PNG", "PS1_JP_CGMODETOPMENUNN.PNG" };

        private static List<String> filesList_PS1_EN = new List<String> { "PS1_EN_CGMODEAKBK.PNG", "PS1_EN_CGMODEAKCHIP.PNG", "PS1_EN_CGMODEMOBK.PNG",
            "PS1_EN_CGMODEMOCHIP.PNG", "PS1_EN_CGMODEMSBK.PNG", "PS1_EN_CGMODEMSCHIP.PNG", "PS1_EN_CGMODEMUBK.PNG", "PS1_EN_CGMODEMUCHIP.PNG",
            "PS1_EN_CGMODEMZBK.PNG", "PS1_EN_CGMODEMZCHIP.PNG", "PS1_EN_CGMODENABK.PNG", "PS1_EN_CGMODENACHIP.PNG", "PS1_EN_CGMODENNBK.PNG",
            "PS1_EN_CGMODENNCHIP.PNG", "PS1_EN_CGMODETOPMENUAK.PNG", "PS1_EN_CGMODETOPMENUBK.PNG", "PS1_EN_CGMODETOPMENUCHIP.PNG",
            "PS1_EN_CGMODETOPMENUMO.PNG", "PS1_EN_CGMODETOPMENUMS.PNG", "PS1_EN_CGMODETOPMENUMU.PNG", "PS1_EN_CGMODETOPMENUMZ.PNG",
            "PS1_EN_CGMODETOPMENUNA.PNG", "PS1_EN_CGMODETOPMENUNN.PNG" };

        private static List<String> filesList_PS1_SP = new List<String> { "PS1_SP_CGMODEAKBK.PNG", "PS1_SP_CGMODEAKCHIP.PNG", "PS1_SP_CGMODEMOBK.PNG",
            "PS1_SP_CGMODEMOCHIP.PNG", "PS1_SP_CGMODEMSBK.PNG", "PS1_SP_CGMODEMSCHIP.PNG", "PS1_SP_CGMODEMUBK.PNG", "PS1_SP_CGMODEMUCHIP.PNG",
            "PS1_SP_CGMODEMZBK.PNG", "PS1_SP_CGMODEMZCHIP.PNG", "PS1_SP_CGMODENNBK.PNG", "PS1_SP_CGMODENNCHIP.PNG" };

        private static List<String> filesList_PS1_CH = new List<String> { "PS1_CH_CGMODEAKBK.PNG", "PS1_CH_CGMODEAKCHIP.PNG", "PS1_CH_CGMODEMOBK.PNG",
            "PS1_CH_CGMODEMOCHIP.PNG", "PS1_CH_CGMODEMSBK.PNG", "PS1_CH_CGMODEMSCHIP.PNG", "PS1_CH_CGMODEMUBK.PNG", "PS1_CH_CGMODEMUCHIP.PNG",
            "PS1_CH_CGMODEMZBK.PNG", "PS1_CH_CGMODEMZCHIP.PNG", "PS1_CH_CGMODENNBK.PNG", "PS1_CH_CGMODENNCHIP.PNG" };

        private static List<String> filesList_AA = new List<String> { "AA_FGAK12.PNG", "AA_FGAK13.PNG", "AA_FGAK14.PNG", "AA_FGAK15.PNG", "AA_FGMI03.PNG",
            "AA_FGMI04.PNG", "AA_FGMI05.PNG", "AA_FGMI06.PNG", "AA_FGMS07.PNG", "AA_FGMS08.PNG", "AA_FGMS09.PNG", "AA_FGMS10.PNG",
            "AA_FGMY11.PNG", "AA_FGMY12.PNG", "AA_FGMY13.PNG", "AA_FGMY14.PNG", "AA_FGMZ12.PNG", "AA_FGMZ13.PNG", "AA_FGMZ14.PNG",
            "AA_FGMZ15.PNG", "AA_FGRM07.PNG", "AA_FGRM12.PNG", "AA_FGRM13.PNG", "AA_FGRM14.PNG", "AA_FGRM15.PNG" };

        private static List<String> filesList_AA_JP = new List<String> { "AA_JP_CGMODEAKBK.PNG", "AA_JP_CGMODEMOBK.PNG", "AA_JP_CGMODEMSBK.PNG",
            "AA_JP_CGMODEMUBK.PNG", "AA_JP_CGMODEMZBK.PNG", "AA_JP_CGMODENNBK.PNG" };

        private static List<String> filesList_AA_EN = new List<String> { "AA_EN_CGMODEAKBK.PNG", "AA_EN_CGMODEMOBK.PNG", "AA_EN_CGMODEMSBK.PNG",
            "AA_EN_CGMODEMUBK.PNG", "AA_EN_CGMODEMZBK.PNG", "AA_EN_CGMODENNBK.PNG" };

        private static List<String> filesList_AA_SP = new List<String> { "AA_SP_CGMODEAKBK.PNG", "AA_SP_CGMODEMOBK.PNG", "AA_SP_CGMODEMSBK.PNG",
            "AA_SP_CGMODEMUBK.PNG", "AA_SP_CGMODEMZBK.PNG", "AA_SP_CGMODENNBK.PNG" };

        private static List<String> filesList_AA_CH = new List<String> { "AA_CH_CGMODEAKBK.PNG", "AA_CH_CGMODEMOBK.PNG", "AA_CH_CGMODEMSBK.PNG",
            "AA_CH_CGMODEMUBK.PNG", "AA_CH_CGMODEMZBK.PNG", "AA_CH_CGMODENNBK.PNG" };

        private static List<String> filesList_PS1_AA_JP = new List<String> { "PS1_AA_JP_CGMODEAKBK.PNG", "PS1_AA_JP_CGMODEMOBK.PNG",
            "PS1_AA_JP_CGMODEMSBK.PNG", "PS1_AA_JP_CGMODEMUBK.PNG", "PS1_AA_JP_CGMODEMZBK.PNG", "PS1_AA_JP_CGMODENNBK.PNG" };

        private static List<String> filesList_PS1_AA_EN = new List<String> { "PS1_AA_EN_CGMODEAKBK.PNG", "PS1_AA_EN_CGMODEMOBK.PNG",
            "PS1_AA_EN_CGMODEMSBK.PNG", "PS1_AA_EN_CGMODEMUBK.PNG", "PS1_AA_EN_CGMODEMZBK.PNG", "PS1_AA_EN_CGMODENNBK.PNG" };

        private static List<String> filesList_PS1_AA_SP = new List<String> { "PS1_AA_SP_CGMODEAKBK.PNG", "PS1_AA_SP_CGMODEMOBK.PNG",
            "PS1_AA_SP_CGMODEMSBK.PNG", "PS1_AA_SP_CGMODEMUBK.PNG", "PS1_AA_SP_CGMODEMZBK.PNG", "PS1_AA_SP_CGMODENNBK.PNG" };

        private static List<String> filesList_PS1_AA_CH = new List<String> { "PS1_AA_CH_CGMODEAKBK.PNG", "PS1_AA_CH_CGMODEMOBK.PNG",
            "PS1_AA_CH_CGMODEMSBK.PNG", "PS1_AA_CH_CGMODEMUBK.PNG", "PS1_AA_CH_CGMODEMZBK.PNG", "PS1_AA_CH_CGMODENNBK.PNG" };


        public static void InitializeLists(out List<Entry> patchSNXFilesList, out List<Entry> patchIMGFilesList, out List<Entry> patchSNDFilesList, ArchiveFileSystem afsPatchFiles, string inputEdition, string inputLanguage, string inputPS1, string inputAAContent)
        {
            patchSNXFilesList = new List<Entry>();
            patchIMGFilesList = new List<Entry>();
            patchSNDFilesList = new List<Entry>();

            //Full Voice Edition + H-scenes + No PS1 content + Japanese
            if (inputEdition.Substring(0, 1) == "1" && inputAAContent.Substring(0, 1) == "2" && inputPS1.Substring(0, 1) == "2" && inputLanguage.Substring(0, 1) == "1")
            {
                foreach (String entry in filesList_FV_OG) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_FV_OG_JP) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_OG) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_OG_JP) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
            }

            //Full Voice Edition + H-scenes + No PS1 content + English
            else if (inputEdition.Substring(0, 1) == "1" && inputAAContent.Substring(0, 1) == "2" && inputPS1.Substring(0, 1) == "2" && inputLanguage.Substring(0, 1) == "2")
            {
                foreach (String entry in filesList_FV_OG) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_FV_OG_EN) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_OG) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_OG_EN) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
            }

            //Full Voice Edition + H-scenes + No PS1 content + Spanish
            else if (inputEdition.Substring(0, 1) == "1" && inputAAContent.Substring(0, 1) == "2" && inputPS1.Substring(0, 1) == "2" && inputLanguage.Substring(0, 1) == "3")
            {
                foreach (String entry in filesList_FV_OG_SP) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_OG_SP) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
            }

            //Full Voice Edition + H-scenes + No PS1 content + Chinese
            else if (inputEdition.Substring(0, 1) == "1" && inputAAContent.Substring(0, 1) == "2" && inputPS1.Substring(0, 1) == "2" && inputLanguage.Substring(0, 1) == "4")
            {
                foreach (String entry in filesList_FV_OG) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_FV_OG_CH) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_OG) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_OG_CH) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
            }

            //Full Voice Edition + H-scenes + PS1 content + Japanese
            else if (inputEdition.Substring(0, 1) == "1" && inputAAContent.Substring(0, 1) == "2" && inputPS1.Substring(0, 1) == "1" && inputLanguage.Substring(0, 1) == "1")
            {
                foreach (String entry in filesList_FV_PS1) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_FV_PS1_JP) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_JP_MI26.SNX"));
                foreach (String entry in filesList_OG) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_PS1) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_PS1_JP) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
            }

            //Full Voice Edition + H-scenes + PS1 content + English
            else if (inputEdition.Substring(0, 1) == "1" && inputAAContent.Substring(0, 1) == "2" && inputPS1.Substring(0, 1) == "1" && inputLanguage.Substring(0, 1) == "2")
            {
                foreach (String entry in filesList_FV_PS1) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_FV_PS1_EN) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_EN_MI26.SNX"));
                foreach (String entry in filesList_OG) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_PS1) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_PS1_EN) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
            }

            //Full Voice Edition + H-scenes + PS1 content + Spanish
            else if (inputEdition.Substring(0, 1) == "1" && inputAAContent.Substring(0, 1) == "2" && inputPS1.Substring(0, 1) == "1" && inputLanguage.Substring(0, 1) == "3")
            {
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_CGMODEAK.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_CGMODEMO.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_CGMODEMS.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_CGMODEMU.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_CGMODEMZ.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_CGMODENN.SNX"));
                foreach (String entry in filesList_FV_PS1_SP) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_SP_MI26.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_BG400.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGAK17.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGAK18.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGMI17.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGMI18.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGMI19.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGMS18.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGMS19.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGMY16.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGMY17.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGMZ17.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGMZ18.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGRM16.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGRM17.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGRM18.PNG"));
                foreach (String entry in filesList_PS1_SP) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
            }

            //Full Voice Edition + H-scenes + PS1 content + Chinese
            else if (inputEdition.Substring(0, 1) == "1" && inputAAContent.Substring(0, 1) == "2" && inputPS1.Substring(0, 1) == "1" && inputLanguage.Substring(0, 1) == "4")
            {
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_CGMODEAK.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_CGMODEMO.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_CGMODEMS.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_CGMODEMU.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_CGMODEMZ.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_CGMODENN.SNX"));
                foreach (String entry in filesList_FV_PS1_CH) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_CH_MI26.SNX"));
                foreach (String entry in filesList_OG) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_BG400.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGAK17.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGAK18.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGMI17.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGMI18.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGMI19.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGMS18.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGMS19.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGMY16.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGMY17.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGMZ17.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGMZ18.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGRM16.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGRM17.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGRM18.PNG"));
                foreach (String entry in filesList_PS1_CH) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
            }

            //Full Voice Edition + All Ages + No PS1 content + Japanese
            else if (inputEdition.Substring(0, 1) == "1" && inputAAContent.Substring(0, 1) == "1" && inputPS1.Substring(0, 1) == "2" && inputLanguage.Substring(0, 1) == "1")
            {
                foreach (String entry in filesList_FV_AA) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_FV_AA_JP) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_CGMODE.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_NECEMEM.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_JP_DS01.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_JP_DS05.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_JP_DS07.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_JP_DS09.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_JP_DS10_A.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_JP_DS18.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_JP_DS19.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_JP_DS22.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_JP_DS24.SNX"));
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
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_JP_CGMODETOPMENUAK.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_JP_CGMODETOPMENUBK.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_JP_CGMODETOPMENUCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_JP_CGMODETOPMENUMO.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_JP_CGMODETOPMENUMS.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_JP_CGMODETOPMENUMU.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_JP_CGMODETOPMENUMZ.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_JP_CGMODETOPMENUNN.PNG"));
            }

            //Full Voice Edition + All Ages + No PS1 content + English
            else if (inputEdition.Substring(0, 1) == "1" && inputAAContent.Substring(0, 1) == "1" && inputPS1.Substring(0, 1) == "2" && inputLanguage.Substring(0, 1) == "2")
            {
                foreach (String entry in filesList_FV_AA) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_FV_AA_EN) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_CGMODE.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_NECEMEM.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_EN_DS01.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_EN_DS05.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_EN_DS07.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_EN_DS09.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_EN_DS10_A.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_EN_DS18.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_EN_DS19.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_EN_DS22.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_EN_DS24.SNX"));
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
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_EN_CGMODETOPMENUAK.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_EN_CGMODETOPMENUBK.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_EN_CGMODETOPMENUCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_EN_CGMODETOPMENUMO.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_EN_CGMODETOPMENUMS.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_EN_CGMODETOPMENUMU.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_EN_CGMODETOPMENUMZ.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_EN_CGMODETOPMENUNN.PNG"));
            }

            //Full Voice Edition + All Ages + No PS1 content + Spanish
            else if (inputEdition.Substring(0, 1) == "1" && inputAAContent.Substring(0, 1) == "1" && inputPS1.Substring(0, 1) == "2" && inputLanguage.Substring(0, 1) == "3")
            {
                foreach (String entry in filesList_FV_AA) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_FV_AA_SP) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_SP_DS01.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_SP_DS05.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_SP_DS07.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_SP_DS09.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_SP_DS10_A.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_SP_DS19.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_SP_MS22.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_SP_MS25.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_SP_MS27.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_SP_MY24.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_SP_NV30.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_SP_RM24.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_SP_SBD25N1.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_SP_SBRM14N1.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_SP_SBRM17M1.SNX"));
                foreach (String entry in filesList_AA) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_AA_SP) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_SP_CGMODEAKCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_SP_CGMODEMOCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_SP_CGMODEMSCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_SP_CGMODEMUCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_SP_CGMODEMZCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_SP_CGMODENNCHIP.PNG"));
            }

            //Full Voice Edition + All Ages + No PS1 content + Chinese
            else if (inputEdition.Substring(0, 1) == "1" && inputAAContent.Substring(0, 1) == "1" && inputPS1.Substring(0, 1) == "2" && inputLanguage.Substring(0, 1) == "4")
            {
                foreach (String entry in filesList_FV_AA) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_FV_AA_CH) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_CH_DS01.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_CH_DS05.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_CH_DS07.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_CH_DS09.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_CH_DS10_A.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_CH_DS19.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_CH_MS22.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_CH_MS25.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_CH_MS27.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_CH_MY24.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_CH_NV30.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_CH_RM24.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_CH_SBD25N1.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_CH_SBRM14N1.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_CH_SBRM17M1.SNX"));
                foreach (String entry in filesList_AA) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_AA_CH) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_CH_CGMODEAKCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_CH_CGMODEMOCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_CH_CGMODEMSCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_CH_CGMODEMUCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_CH_CGMODEMZCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_CH_CGMODENNCHIP.PNG"));
            }

            //Full Voice Edition + All Ages + PS1 content + Japanese
            else if (inputEdition.Substring(0, 1) == "1" && inputAAContent.Substring(0, 1) == "1" && inputPS1.Substring(0, 1) == "1" && inputLanguage.Substring(0, 1) == "1")
            {
                foreach (String entry in filesList_FV_PS1_AA) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_FV_PS1_AA_JP) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_CGMODE.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_CGMODENA.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_NECEMEM.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_JP_DS01.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_JP_DS05.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_JP_DS07.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_JP_DS09.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_JP_DS10_A.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_JP_DS18.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_JP_DS19.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_JP_DS22.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_JP_DS24.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_JP_MS22.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_JP_MS25.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_JP_MS27.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_JP_MY24.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_JP_NA18.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_JP_NA22.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_JP_NA24.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_JP_NA25.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_JP_NA27.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_JP_NAE.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_JP_NV30.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_JP_RM24.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_JP_SBD25N1.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_JP_SBRM14N1.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_JP_SBRM17M1.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_AA_JP_MI26.SNX"));
                foreach (String entry in filesList_PS1) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_AA) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_PS1_AA_JP) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_JP_CGMODEAKCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_JP_CGMODEMOCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_JP_CGMODEMSCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_JP_CGMODEMUCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_JP_CGMODEMZCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_JP_CGMODENABK.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_JP_CGMODENACHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_JP_CGMODENNCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_JP_CGMODETOPMENUAK.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_JP_CGMODETOPMENUBK.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_JP_CGMODETOPMENUCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_JP_CGMODETOPMENUMO.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_JP_CGMODETOPMENUMS.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_JP_CGMODETOPMENUMU.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_JP_CGMODETOPMENUMZ.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_JP_CGMODETOPMENUNA.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_JP_CGMODETOPMENUNN.PNG"));
            }

            //Full Voice Edition + All Ages + PS1 content + English
            else if (inputEdition.Substring(0, 1) == "1" && inputAAContent.Substring(0, 1) == "1" && inputPS1.Substring(0, 1) == "1" && inputLanguage.Substring(0, 1) == "2")
            {
                foreach (String entry in filesList_FV_PS1_AA) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_FV_PS1_AA_EN) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_CGMODE.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_CGMODENA.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_NECEMEM.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_EN_DS01.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_EN_DS05.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_EN_DS07.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_EN_DS09.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_EN_DS10_A.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_EN_DS18.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_EN_DS19.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_EN_DS22.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_EN_DS24.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_EN_MS22.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_EN_MS25.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_EN_MS27.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_EN_MY24.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_EN_NA18.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_EN_NA22.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_EN_NA24.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_EN_NA25.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_EN_NA27.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_EN_NAE.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_EN_NV30.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_EN_RM24.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_EN_SBD25N1.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_EN_SBRM14N1.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_EN_SBRM17M1.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_AA_EN_MI26.SNX"));
                foreach (String entry in filesList_PS1) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_AA) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_PS1_AA_EN) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_EN_CGMODEAKCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_EN_CGMODEMOCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_EN_CGMODEMSCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_EN_CGMODEMUCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_EN_CGMODEMZCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_EN_CGMODENABK.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_EN_CGMODENACHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_EN_CGMODENNCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_EN_CGMODETOPMENUAK.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_EN_CGMODETOPMENUBK.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_EN_CGMODETOPMENUCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_EN_CGMODETOPMENUMO.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_EN_CGMODETOPMENUMS.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_EN_CGMODETOPMENUMU.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_EN_CGMODETOPMENUMZ.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_EN_CGMODETOPMENUNA.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_EN_CGMODETOPMENUNN.PNG"));
            }

            //Full Voice Edition + All Ages + PS1 content + Spanish
            else if (inputEdition.Substring(0, 1) == "1" && inputAAContent.Substring(0, 1) == "1" && inputPS1.Substring(0, 1) == "1" && inputLanguage.Substring(0, 1) == "3")
            {
                foreach (String entry in filesList_FV_PS1_AA) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_FV_PS1_AA_SP) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_SP_DS01.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_SP_DS05.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_SP_DS07.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_SP_DS09.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_SP_DS10_A.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_SP_DS19.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_SP_MS22.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_SP_MS25.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_SP_MS27.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_SP_MY24.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_SP_NV30.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_SP_RM24.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_SP_SBD25N1.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_SP_SBRM14N1.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_SP_SBRM17M1.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_AA_SP_MI26.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_BG400.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGAK17.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGAK18.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGMI17.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGMI18.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGMI19.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGMS18.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGMS19.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGMY16.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGMY17.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGMZ17.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGMZ18.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGRM16.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGRM17.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGRM18.PNG"));
                foreach (String entry in filesList_AA) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_PS1_AA_SP) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_SP_CGMODEAKCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_SP_CGMODEMOCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_SP_CGMODEMSCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_SP_CGMODEMUCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_SP_CGMODEMZCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_SP_CGMODENNCHIP.PNG"));
            }

            //Full Voice Edition + All Ages + PS1 content + Chinese
            else if (inputEdition.Substring(0, 1) == "1" && inputAAContent.Substring(0, 1) == "1" && inputPS1.Substring(0, 1) == "1" && inputLanguage.Substring(0, 1) == "4")
            {
                foreach (String entry in filesList_FV_PS1_AA) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_FV_PS1_AA_CH) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_CH_DS01.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_CH_DS05.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_CH_DS07.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_CH_DS09.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_CH_DS10_A.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_CH_DS19.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_CH_MS22.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_CH_MS25.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_CH_MS27.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_CH_MY24.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_CH_NV30.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_CH_RM24.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_CH_SBD25N1.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_CH_SBRM14N1.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_PS1_CH_SBRM17M1.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_AA_CH_MI26.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_BG400.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGAK17.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGAK18.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGMI17.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGMI18.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGMI19.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGMS18.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGMS19.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGMY16.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGMY17.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGMZ17.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGMZ18.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGRM16.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGRM17.PNG"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("PS1_FGRM18.PNG"));
                foreach (String entry in filesList_AA) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_PS1_AA_CH) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_CH_CGMODEAKCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_CH_CGMODEMOCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_CH_CGMODEMSCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_CH_CGMODEMUCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_CH_CGMODEMZCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_CH_CGMODENNCHIP.PNG"));
            }

            //Vista Edition + H-scenes + No PS1 content + Japanese
            else if (inputEdition.Substring(0, 1) == "2" && inputAAContent.Substring(0, 1) == "2" && inputPS1.Substring(0, 1) == "2" && inputLanguage.Substring(0, 1) == "1")
            {
                foreach (String entry in filesList_VI_OG) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_VI_OG_JP) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_OG) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_OG_JP) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
            }

            //Vista Edition + H-scenes + No PS1 content + English
            else if (inputEdition.Substring(0, 1) == "2" && inputAAContent.Substring(0, 1) == "2" && inputPS1.Substring(0, 1) == "2" && inputLanguage.Substring(0, 1) == "2")
            {
                foreach (String entry in filesList_VI_OG) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_VI_OG_EN) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_OG) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_OG_EN) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
            }

            //Vista Edition + H-scenes + PS1 content + Japanese
            else if (inputEdition.Substring(0, 1) == "2" && inputAAContent.Substring(0, 1) == "2" && inputPS1.Substring(0, 1) == "1" && inputLanguage.Substring(0, 1) == "1")
            {
                foreach (String entry in filesList_VI_PS1) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_VI_PS1_JP) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_JP_MI26.SNX"));
                foreach (String entry in filesList_OG) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_PS1) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_PS1_JP) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
            }

            //Vista Edition + H-scenes + PS1 content + English
            else if (inputEdition.Substring(0, 1) == "2" && inputAAContent.Substring(0, 1) == "2" && inputPS1.Substring(0, 1) == "1" && inputLanguage.Substring(0, 1) == "2")
            {
                foreach (String entry in filesList_VI_PS1) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_VI_PS1_EN) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_EN_MI26.SNX"));
                foreach (String entry in filesList_OG) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_PS1) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_PS1_EN) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
            }

            //Vista Edition + All Ages + No PS1 content + Japanese
            else if (inputEdition.Substring(0, 1) == "2" && inputAAContent.Substring(0, 1) == "1" && inputPS1.Substring(0, 1) == "2" && inputLanguage.Substring(0, 1) == "1")
            {
                foreach (String entry in filesList_VI_AA) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_VI_AA_JP) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_CGMODE.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_JP_DS01.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_JP_DS05.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_JP_DS07.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_JP_DS09.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_JP_DS10_A.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_JP_DS18.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_JP_DS19.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_JP_DS22.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_JP_DS24.SNX"));
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
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_JP_CGMODETOPMENUAK.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_JP_CGMODETOPMENUBK.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_JP_CGMODETOPMENUCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_JP_CGMODETOPMENUMO.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_JP_CGMODETOPMENUMS.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_JP_CGMODETOPMENUMU.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_JP_CGMODETOPMENUMZ.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_JP_CGMODETOPMENUNN.PNG"));
            }

            //Vista Edition + All Ages + No PS1 content + English
            else if (inputEdition.Substring(0, 1) == "2" && inputAAContent.Substring(0, 1) == "1" && inputPS1.Substring(0, 1) == "2" && inputLanguage.Substring(0, 1) == "2")
            {
                foreach (String entry in filesList_VI_AA) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_VI_AA_EN) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_CGMODE.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_EN_DS01.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_EN_DS05.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_EN_DS07.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_EN_DS09.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_EN_DS10_A.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_EN_DS18.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_EN_DS19.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_EN_DS22.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_OG_EN_DS24.SNX"));
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
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_EN_CGMODETOPMENUAK.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_EN_CGMODETOPMENUBK.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_EN_CGMODETOPMENUCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_EN_CGMODETOPMENUMO.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_EN_CGMODETOPMENUMS.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_EN_CGMODETOPMENUMU.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_EN_CGMODETOPMENUMZ.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("OG_EN_CGMODETOPMENUNN.PNG"));
            }

            //Vista Edition + All Ages + PS1 content + Japanese
            else if (inputEdition.Substring(0, 1) == "2" && inputAAContent.Substring(0, 1) == "1" && inputPS1.Substring(0, 1) == "1" && inputLanguage.Substring(0, 1) == "1")
            {
                foreach (String entry in filesList_VI_PS1_AA) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_VI_PS1_AA_JP) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_CGMODE.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_CGMODENA.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_JP_DS01.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_JP_DS05.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_JP_DS07.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_JP_DS09.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_JP_DS10_A.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_JP_DS18.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_JP_DS19.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_JP_DS22.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_JP_DS24.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_JP_MS22.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_JP_MS25.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_JP_MS27.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_JP_MY24.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_JP_NA18.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_JP_NA22.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_JP_NA24.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_JP_NA25.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_JP_NA27.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_JP_NAE.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_JP_NV30.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_JP_RM24.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_JP_SBD25N1.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_JP_SBRM14N1.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_JP_SBRM17M1.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_AA_JP_MI26.SNX"));
                foreach (String entry in filesList_PS1) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_AA) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_PS1_AA_JP) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_JP_CGMODEAKCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_JP_CGMODEMOCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_JP_CGMODEMSCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_JP_CGMODEMUCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_JP_CGMODEMZCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_JP_CGMODENABK.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_JP_CGMODENACHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_JP_CGMODENNCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_JP_CGMODETOPMENUAK.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_JP_CGMODETOPMENUBK.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_JP_CGMODETOPMENUCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_JP_CGMODETOPMENUMO.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_JP_CGMODETOPMENUMS.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_JP_CGMODETOPMENUMU.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_JP_CGMODETOPMENUMZ.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_JP_CGMODETOPMENUNA.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_JP_CGMODETOPMENUNN.PNG"));
            }

            //Vista Edition + All Ages + PS1 content + English
            else if (inputEdition.Substring(0, 1) == "2" && inputAAContent.Substring(0, 1) == "1" && inputPS1.Substring(0, 1) == "1" && inputLanguage.Substring(0, 1) == "2")
            {
                foreach (String entry in filesList_VI_PS1_AA) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_VI_PS1_AA_EN) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_CGMODE.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_CGMODENA.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_EN_DS01.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_EN_DS05.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_EN_DS07.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_EN_DS09.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_EN_DS10_A.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_EN_DS18.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_EN_DS19.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_EN_DS22.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_EN_DS24.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_EN_MS22.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_EN_MS25.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_EN_MS27.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_EN_MY24.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_EN_NA18.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_EN_NA22.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_EN_NA24.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_EN_NA25.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_EN_NA27.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_EN_NAE.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_EN_NV30.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_EN_RM24.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_EN_SBD25N1.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_EN_SBRM14N1.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_PS1_EN_SBRM17M1.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("VI_AA_EN_MI26.SNX"));
                foreach (String entry in filesList_PS1) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_AA) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_PS1_AA_EN) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_EN_CGMODEAKCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_EN_CGMODEMOCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_EN_CGMODEMSCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_EN_CGMODEMUCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_EN_CGMODEMZCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_EN_CGMODENABK.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_EN_CGMODENACHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_EN_CGMODENNCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_EN_CGMODETOPMENUAK.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_EN_CGMODETOPMENUBK.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_EN_CGMODETOPMENUCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_EN_CGMODETOPMENUMO.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_EN_CGMODETOPMENUMS.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_EN_CGMODETOPMENUMU.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_EN_CGMODETOPMENUMZ.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_EN_CGMODETOPMENUNA.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("PS1_EN_CGMODETOPMENUNN.PNG"));
            }

            //PS1 content, add the voices to the list
            if (inputPS1.Substring(0, 1) == "1")
            {
                for (int i = 1; i <= 170; i++)
                    patchSNDFilesList.Add(afsPatchFiles.FindFile("PS1_NAT"+ i.ToString().PadLeft(4, '0')+".WAV"));
            }
        }
    }
}
