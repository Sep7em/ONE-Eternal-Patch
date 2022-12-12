using System;
using System.Collections.Generic;
using GameRes;

namespace ONE_Eternal_Patch
{
    public class Files_Lists
    {
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

        private static List<String> filesList_FV_OG_SP = new List<String> { "FV_OG_SP_AK26.SNX", "FV_OG_SP_DS01.SNX", "FV_OG_SP_DS05.SNX",
            "FV_OG_SP_DS07.SNX", "FV_OG_SP_DS09.SNX", "FV_OG_SP_DS10_A.SNX", "FV_OG_SP_DS19.SNX", "FV_OG_SP_MI26.SNX",
            "FV_OG_SP_MS22.SNX", "FV_OG_SP_MS25.SNX", "FV_OG_SP_MS27.SNX", "FV_OG_SP_MY24.SNX", "FV_OG_SP_NV30.SNX",
            "FV_OG_SP_RM24.SNX", "FV_OG_SP_SBD25N1.SNX", "FV_OG_SP_SBRM14N1.SNX", "FV_OG_SP_SBRM17M1.SNX" };

        private static List<String> filesList_FV_OG_CH = new List<String> { "FV_OG_CH_AK26.SNX", "FV_OG_CH_DS01.SNX", "FV_OG_CH_DS05.SNX",
            "FV_OG_CH_DS07.SNX", "FV_OG_CH_DS09.SNX", "FV_OG_CH_DS10_A.SNX", "FV_OG_CH_DS19.SNX", "FV_OG_CH_MI26.SNX",
            "FV_OG_CH_MS22.SNX", "FV_OG_CH_MS25.SNX", "FV_OG_CH_MS27.SNX", "FV_OG_CH_MY24.SNX", "FV_OG_CH_NV30.SNX",
            "FV_OG_CH_RM24.SNX", "FV_OG_CH_SBD25N1.SNX", "FV_OG_CH_SBRM14N1.SNX", "FV_OG_CH_SBRM17M1.SNX" };

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

        private static List<String> filesList_FV_BCG_SP = new List<String> { "FV_BCG_SP_AK26.SNX", "FV_BCG_SP_DS01.SNX", "FV_BCG_SP_DS05.SNX",
            "FV_BCG_SP_DS07.SNX", "FV_BCG_SP_DS09.SNX", "FV_BCG_SP_DS10_A.SNX", "FV_BCG_SP_DS19.SNX", "FV_BCG_SP_MS22.SNX",
            "FV_BCG_SP_MS25.SNX", "FV_BCG_SP_MS27.SNX", "FV_BCG_SP_MY24.SNX", "FV_BCG_SP_NV30.SNX", "FV_BCG_SP_RM24.SNX",
            "FV_BCG_SP_SBD25N1.SNX", "FV_BCG_SP_SBRM14N1.SNX", "FV_BCG_SP_SBRM17M1.SNX" };

        private static List<String> filesList_FV_BCG_CH = new List<String> { "FV_BCG_CH_AK26.SNX", "FV_BCG_CH_DS01.SNX", "FV_BCG_CH_DS05.SNX",
            "FV_BCG_CH_DS07.SNX", "FV_BCG_CH_DS09.SNX", "FV_BCG_CH_DS10_A.SNX", "FV_BCG_CH_DS19.SNX", "FV_BCG_CH_MS22.SNX",
            "FV_BCG_CH_MS25.SNX", "FV_BCG_CH_MS27.SNX", "FV_BCG_CH_MY24.SNX", "FV_BCG_CH_NV30.SNX", "FV_BCG_CH_RM24.SNX",
            "FV_BCG_CH_SBD25N1.SNX", "FV_BCG_CH_SBRM14N1.SNX", "FV_BCG_CH_SBRM17M1.SNX" };

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

        private static List<String> filesList_FV_AA_SP = new List<String> { "FV_AA_SP_AK26.SNX", "FV_AA_SP_MI26.SNX" };

        private static List<String> filesList_FV_AA_CH = new List<String> { "FV_AA_CH_AK26.SNX", "FV_AA_CH_MI26.SNX" };

        private static List<String> filesList_VI_AA_JP = new List<String> { "VI_AA_JP_AK26.SNX", "VI_AA_JP_MI26.SNX" };

        private static List<String> filesList_VI_AA_EN = new List<String> { "VI_AA_EN_AK26.SNX", "VI_AA_EN_MI26.SNX" };

        private static List<String> filesList_FV_BCG_AA = new List<String> { "FV_BCG_AA_CGMODEAK.SNX", "FV_BCG_AA_CGMODEMO.SNX", "FV_BCG_AA_CGMODEMS.SNX",
            "FV_BCG_AA_CGMODEMU.SNX", "FV_BCG_AA_CGMODEMZ.SNX", "FV_BCG_AA_CGMODENN.SNX" };

        private static List<String> filesList_VI_BCG_AA = new List<String> { "VI_BCG_AA_CGMODEAK.SNX", "VI_BCG_AA_CGMODEMO.SNX", "VI_BCG_AA_CGMODEMS.SNX",
            "VI_BCG_AA_CGMODEMU.SNX", "VI_BCG_AA_CGMODEMZ.SNX", "VI_BCG_AA_CGMODENN.SNX" };

        private static List<String> filesList_FV_BCG_AA_JP = new List<String> { "FV_BCG_AA_JP_AK26.SNX" };

        private static List<String> filesList_FV_BCG_AA_EN = new List<String> { "FV_BCG_AA_EN_AK26.SNX" };

        private static List<String> filesList_FV_BCG_AA_SP = new List<String> { "FV_BCG_AA_SP_AK26.SNX" };

        private static List<String> filesList_FV_BCG_AA_CH = new List<String> { "FV_BCG_AA_CH_AK26.SNX" };

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

        private static List<String> filesList_OG_SP = new List<String> { "OG_SP_CGMODEAKBK.PNG", "OG_SP_CGMODEAKCHIP.PNG", "OG_SP_CGMODEMOBK.PNG",
            "OG_SP_CGMODEMOCHIP.PNG", "OG_SP_CGMODEMSBK.PNG", "OG_SP_CGMODEMSCHIP.PNG", "OG_SP_CGMODEMUBK.PNG", "OG_SP_CGMODEMUCHIP.PNG",
            "OG_SP_CGMODEMZBK.PNG", "OG_SP_CGMODEMZCHIP.PNG", "OG_SP_CGMODENNBK.PNG", "OG_SP_CGMODENNCHIP.PNG" };

        private static List<String> filesList_OG_CH = new List<String> { "OG_CH_CGMODEAKBK.PNG", "OG_CH_CGMODEAKCHIP.PNG", "OG_CH_CGMODEMOBK.PNG",
            "OG_CH_CGMODEMOCHIP.PNG", "OG_CH_CGMODEMSBK.PNG", "OG_CH_CGMODEMSCHIP.PNG", "OG_CH_CGMODEMUBK.PNG", "OG_CH_CGMODEMUCHIP.PNG",
            "OG_CH_CGMODEMZBK.PNG", "OG_CH_CGMODEMZCHIP.PNG", "OG_CH_CGMODENNBK.PNG", "OG_CH_CGMODENNCHIP.PNG" };

        private static List<String> filesList_BCG = new List<String> { "BCG_BG400.PNG", "BCG_FGAK17.PNG", "BCG_FGAK18.PNG", "BCG_FGMI17.PNG", "BCG_FGMI18.PNG",
            "BCG_FGMI19.PNG", "BCG_FGMS18.PNG", "BCG_FGMS19.PNG", "BCG_FGMY16.PNG", "BCG_FGMY17.PNG", "BCG_FGMZ17.PNG", "BCG_FGMZ18.PNG",
            "BCG_FGRM16.PNG", "BCG_FGRM17.PNG", "BCG_FGRM18.PNG" };

        private static List<String> filesList_BCG_JP = new List<String> { "BCG_JP_CGMODEAKBK.PNG", "BCG_JP_CGMODEAKCHIP.PNG", "BCG_JP_CGMODEMOBK.PNG",
            "BCG_JP_CGMODEMOCHIP.PNG", "BCG_JP_CGMODEMSBK.PNG", "BCG_JP_CGMODEMSCHIP.PNG", "BCG_JP_CGMODEMUBK.PNG", "BCG_JP_CGMODEMUCHIP.PNG",
            "BCG_JP_CGMODEMZBK.PNG", "BCG_JP_CGMODEMZCHIP.PNG", "BCG_JP_CGMODENNBK.PNG", "BCG_JP_CGMODENNCHIP.PNG" };

        private static List<String> filesList_BCG_EN = new List<String> { "BCG_EN_CGMODEAKBK.PNG", "BCG_EN_CGMODEAKCHIP.PNG", "BCG_EN_CGMODEMOBK.PNG",
            "BCG_EN_CGMODEMOCHIP.PNG", "BCG_EN_CGMODEMSBK.PNG", "BCG_EN_CGMODEMSCHIP.PNG", "BCG_EN_CGMODEMUBK.PNG", "BCG_EN_CGMODEMUCHIP.PNG",
            "BCG_EN_CGMODEMZBK.PNG", "BCG_EN_CGMODEMZCHIP.PNG", "BCG_EN_CGMODENNBK.PNG", "BCG_EN_CGMODENNCHIP.PNG" };

        private static List<String> filesList_BCG_SP = new List<String> { "BCG_SP_CGMODEAKBK.PNG", "BCG_SP_CGMODEAKCHIP.PNG", "BCG_SP_CGMODEMOBK.PNG",
            "BCG_SP_CGMODEMOCHIP.PNG", "BCG_SP_CGMODEMSBK.PNG", "BCG_SP_CGMODEMSCHIP.PNG", "BCG_SP_CGMODEMUBK.PNG", "BCG_SP_CGMODEMUCHIP.PNG",
            "BCG_SP_CGMODEMZBK.PNG", "BCG_SP_CGMODEMZCHIP.PNG", "BCG_SP_CGMODENNBK.PNG", "BCG_SP_CGMODENNCHIP.PNG" };

        private static List<String> filesList_BCG_CH = new List<String> { "BCG_CH_CGMODEAKBK.PNG", "BCG_CH_CGMODEAKCHIP.PNG", "BCG_CH_CGMODEMOBK.PNG",
            "BCG_CH_CGMODEMOCHIP.PNG", "BCG_CH_CGMODEMSBK.PNG", "BCG_CH_CGMODEMSCHIP.PNG", "BCG_CH_CGMODEMUBK.PNG", "BCG_CH_CGMODEMUCHIP.PNG",
            "BCG_CH_CGMODEMZBK.PNG", "BCG_CH_CGMODEMZCHIP.PNG", "BCG_CH_CGMODENNBK.PNG", "BCG_CH_CGMODENNCHIP.PNG" };

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

        private static List<String> filesList_BCG_AA_JP = new List<String> { "BCG_AA_JP_CGMODEAKBK.PNG", "BCG_AA_JP_CGMODEMOBK.PNG",
            "BCG_AA_JP_CGMODEMSBK.PNG", "BCG_AA_JP_CGMODEMUBK.PNG", "BCG_AA_JP_CGMODEMZBK.PNG", "BCG_AA_JP_CGMODENNBK.PNG" };

        private static List<String> filesList_BCG_AA_EN = new List<String> { "BCG_AA_EN_CGMODEAKBK.PNG", "BCG_AA_EN_CGMODEMOBK.PNG",
            "BCG_AA_EN_CGMODEMSBK.PNG", "BCG_AA_EN_CGMODEMUBK.PNG", "BCG_AA_EN_CGMODEMZBK.PNG", "BCG_AA_EN_CGMODENNBK.PNG" };

        private static List<String> filesList_BCG_AA_SP = new List<String> { "BCG_AA_SP_CGMODEAKBK.PNG", "BCG_AA_SP_CGMODEMOBK.PNG",
            "BCG_AA_SP_CGMODEMSBK.PNG", "BCG_AA_SP_CGMODEMUBK.PNG", "BCG_AA_SP_CGMODEMZBK.PNG", "BCG_AA_SP_CGMODENNBK.PNG" };

        private static List<String> filesList_BCG_AA_CH = new List<String> { "BCG_AA_CH_CGMODEAKBK.PNG", "BCG_AA_CH_CGMODEMOBK.PNG",
            "BCG_AA_CH_CGMODEMSBK.PNG", "BCG_AA_CH_CGMODEMUBK.PNG", "BCG_AA_CH_CGMODEMZBK.PNG", "BCG_AA_CH_CGMODENNBK.PNG" };


        public static void InitializeLists(out List<Entry> patchSNXFilesList, out List<Entry> patchIMGFilesList, ArchiveFileSystem afsPatchFiles, string inputEdition, string inputLanguage, string inputBonusCG, string inputAAContent)
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

            //Full Voice Edition + H-scenes + No Bonus CG + Spanish
            else if (inputEdition.Substring(0, 1) == "1" && inputAAContent.Substring(0, 1) == "2" && inputBonusCG.Substring(0, 1) == "2" && inputLanguage.Substring(0, 1) == "3")
            {
                foreach (String entry in filesList_FV_OG_SP) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_OG_SP) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
            }

            //Full Voice Edition + H-scenes + No Bonus CG + Chinese
            else if (inputEdition.Substring(0, 1) == "1" && inputAAContent.Substring(0, 1) == "2" && inputBonusCG.Substring(0, 1) == "2" && inputLanguage.Substring(0, 1) == "4")
            {
                foreach (String entry in filesList_FV_OG) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_FV_OG_CH) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_OG) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_OG_CH) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
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

            //Full Voice Edition + H-scenes + Bonus CGs + Spanish
            else if (inputEdition.Substring(0, 1) == "1" && inputAAContent.Substring(0, 1) == "2" && inputBonusCG.Substring(0, 1) == "1" && inputLanguage.Substring(0, 1) == "3")
            {
                foreach (String entry in filesList_FV_BCG) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_FV_BCG_SP) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_SP_MI26.SNX"));
                foreach (String entry in filesList_BCG) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_BCG_SP) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
            }

            //Full Voice Edition + H-scenes + Bonus CGs + Chinese
            else if (inputEdition.Substring(0, 1) == "1" && inputAAContent.Substring(0, 1) == "2" && inputBonusCG.Substring(0, 1) == "1" && inputLanguage.Substring(0, 1) == "4")
            {
                foreach (String entry in filesList_FV_BCG) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_FV_BCG_CH) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_OG_CH_MI26.SNX"));
                foreach (String entry in filesList_OG) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_BCG) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_BCG_CH) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
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

            //Full Voice Edition + All Ages + No Bonus CG + Spanish
            else if (inputEdition.Substring(0, 1) == "1" && inputAAContent.Substring(0, 1) == "1" && inputBonusCG.Substring(0, 1) == "2" && inputLanguage.Substring(0, 1) == "3")
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

            //Full Voice Edition + All Ages + No Bonus CG + Chinese
            else if (inputEdition.Substring(0, 1) == "1" && inputAAContent.Substring(0, 1) == "1" && inputBonusCG.Substring(0, 1) == "2" && inputLanguage.Substring(0, 1) == "4")
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

            //Full Voice Edition + All Ages + Bonus CG + Spanish
            else if (inputEdition.Substring(0, 1) == "1" && inputAAContent.Substring(0, 1) == "1" && inputBonusCG.Substring(0, 1) == "1" && inputLanguage.Substring(0, 1) == "3")
            {
                foreach (String entry in filesList_FV_BCG_AA) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_FV_BCG_AA_SP) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_SP_DS01.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_SP_DS05.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_SP_DS07.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_SP_DS09.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_SP_DS10_A.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_SP_DS19.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_SP_MS22.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_SP_MS25.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_SP_MS27.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_SP_MY24.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_SP_NV30.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_SP_RM24.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_SP_SBD25N1.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_SP_SBRM14N1.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_SP_SBRM17M1.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_AA_SP_MI26.SNX"));
                foreach (String entry in filesList_BCG) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_AA) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_BCG_AA_SP) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("BCG_SP_CGMODEAKCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("BCG_SP_CGMODEMOCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("BCG_SP_CGMODEMSCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("BCG_SP_CGMODEMUCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("BCG_SP_CGMODEMZCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("BCG_SP_CGMODENNCHIP.PNG"));
            }

            //Full Voice Edition + All Ages + Bonus CG + Chinese
            else if (inputEdition.Substring(0, 1) == "1" && inputAAContent.Substring(0, 1) == "1" && inputBonusCG.Substring(0, 1) == "1" && inputLanguage.Substring(0, 1) == "4")
            {
                foreach (String entry in filesList_FV_BCG_AA) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_FV_BCG_AA_CH) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_CH_DS01.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_CH_DS05.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_CH_DS07.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_CH_DS09.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_CH_DS10_A.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_CH_DS19.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_CH_MS22.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_CH_MS25.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_CH_MS27.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_CH_MY24.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_CH_NV30.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_CH_RM24.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_CH_SBD25N1.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_CH_SBRM14N1.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_BCG_CH_SBRM17M1.SNX"));
                patchSNXFilesList.Add(afsPatchFiles.FindFile("FV_AA_CH_MI26.SNX"));
                foreach (String entry in filesList_BCG) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_AA) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                foreach (String entry in filesList_BCG_AA_CH) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("BCG_CH_CGMODEAKCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("BCG_CH_CGMODEMOCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("BCG_CH_CGMODEMSCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("BCG_CH_CGMODEMUCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("BCG_CH_CGMODEMZCHIP.PNG"));
                patchIMGFilesList.Add(afsPatchFiles.FindFile("BCG_CH_CGMODENNCHIP.PNG"));
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
    }
}
