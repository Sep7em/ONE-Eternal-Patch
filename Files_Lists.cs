using System.Collections.Generic;
using GameRes;

namespace ONE_Eternal_Patch
{
    public class Files_Lists
    {
        private static List<string> prefixList = new List<string> {
            "FV_OG_JP_", "FV_OG_EN_", "FV_OG_SP_", "FV_OG_CH_", "FV_OG_KR_", "FV_OG_",
            "FV_PS1_AA_JP_", "FV_PS1_AA_EN_", "FV_PS1_AA_SP_", "FV_PS1_AA_CH_", "FV_PS1_AA_",
            "FV_PS1_JP_", "FV_PS1_EN_", "FV_PS1_SP_", "FV_PS1_CH_", "FV_PS1_KR_", "FV_PS1_",
            "FV_AA_JP_", "FV_AA_EN_", "FV_AA_SP_", "FV_AA_CH_", "FV_AA_",
            "FV_MIS_JP_", "FV_MIS_EN_", "FV_MIS_SP_", "FV_MIS_CH_", "FV_MIS_KR_", "FV_MIS_",
            "VI_OG_JP_", "VI_OG_EN_", "VI_OG_",
            "VI_PS1_AA_JP_", "VI_PS1_AA_EN_", "VI_PS1_AA_",
            "VI_PS1_JP_", "VI_PS1_EN_", "VI_PS1_",
            "VI_AA_JP_", "VI_AA_EN_", "VI_AA_",
            "VI_MIS_JP_", "VI_MIS_EN_", "VI_MIS_",
            "OG_JP_", "OG_EN_", "OG_SP_", "OG_CH_", "OG_KR_", "OG_",
            "PS1_AA_JP_", "PS1_AA_EN_", "PS1_AA_SP_", "PS1_AA_CH_", "PS1_AA_KR_",
            "PS1_JP_", "PS1_EN_", "PS1_SP_", "PS1_CH_", "PS1_KR_", "PS1_",
            "AA_JP_", "AA_EN_", "AA_SP_", "AA_CH_", "AA_",
            "MIS_JP_", "MIS_EN_", "MIS_SP_", "MIS_CH_", "MIS_KR_", "MIS_",
            "EP_JP_", "EP_EN_", "EP_SP_", "EP_CH_", "EP_KR_" };

        //Scripts lists
        private static List<string> filesList_FV_OG = new List<string> { "FV_OG_AP00.SNX", "FV_OG_CALCNUMBERSRCYGRID.SNX",
            "FV_OG_CGMODE.SNX", "FV_OG_CGMODEAK.SNX", "FV_OG_CGMODEMO.SNX", "FV_OG_CGMODEMS.SNX", "FV_OG_CGMODEMU.SNX",
            "FV_OG_CGMODEMZ.SNX", "FV_OG_CGMODENN.SNX", "FV_OG_NECEMEM.SNX" };

        private static List<string> filesList_VI_OG = new List<string> { "VI_OG_AP00.SNX", "VI_OG_CALCNUMBERSRCYGRID.SNX",
            "VI_OG_CGMODE.SNX", "VI_OG_CGMODEAK.SNX", "VI_OG_CGMODEMO.SNX", "VI_OG_CGMODEMS.SNX", "VI_OG_CGMODEMU.SNX",
            "VI_OG_CGMODEMZ.SNX", "VI_OG_CGMODENN.SNX" };

        private static List<string> filesList_FV_OG_JP = new List<string> { "FV_OG_JP_AK26.SNX", "FV_OG_JP_DS01.SNX", "FV_OG_JP_DS05.SNX",
            "FV_OG_JP_DS07.SNX", "FV_OG_JP_DS09.SNX", "FV_OG_JP_DS10_A.SNX", "FV_OG_JP_DS18.SNX", "FV_OG_JP_DS19.SNX",
            "FV_OG_JP_DS22.SNX", "FV_OG_JP_DS24.SNX", "FV_OG_JP_MI26.SNX", "FV_OG_JP_MS22.SNX", "FV_OG_JP_MS25.SNX",
            "FV_OG_JP_MS27.SNX", "FV_OG_JP_MY24.SNX", "FV_OG_JP_NV30.SNX", "FV_OG_JP_RCLICK.SNX", "FV_OG_JP_RM24.SNX",
            "FV_OG_JP_SBD25N1.SNX", "FV_OG_JP_SBRM14N1.SNX", "FV_OG_JP_SBRM17M1.SNX" };

        private static List<string> filesList_FV_OG_EN = new List<string> { "FV_OG_EN_AK26.SNX", "FV_OG_EN_DS01.SNX", "FV_OG_EN_DS05.SNX",
            "FV_OG_EN_DS07.SNX", "FV_OG_EN_DS09.SNX", "FV_OG_EN_DS10_A.SNX", "FV_OG_EN_DS18.SNX", "FV_OG_EN_DS19.SNX",
            "FV_OG_EN_DS22.SNX", "FV_OG_EN_DS24.SNX", "FV_OG_EN_MI26.SNX", "FV_OG_EN_MS22.SNX", "FV_OG_EN_MS25.SNX",
            "FV_OG_EN_MS27.SNX", "FV_OG_EN_MY24.SNX", "FV_OG_EN_NV30.SNX", "FV_OG_EN_RCLICK.SNX", "FV_OG_EN_RM24.SNX",
            "FV_OG_EN_SBD25N1.SNX", "FV_OG_EN_SBRM14N1.SNX", "FV_OG_EN_SBRM17M1.SNX" };

        private static List<string> filesList_FV_OG_SP = new List<string> { "FV_OG_SP_AK26.SNX", "FV_OG_SP_DS01.SNX", "FV_OG_SP_DS05.SNX",
            "FV_OG_SP_DS07.SNX", "FV_OG_SP_DS09.SNX", "FV_OG_SP_DS10_A.SNX", "FV_OG_SP_DS18.SNX", "FV_OG_SP_DS19.SNX",
            "FV_OG_SP_DS22.SNX", "FV_OG_SP_DS24.SNX", "FV_OG_SP_MI26.SNX", "FV_OG_SP_MS22.SNX", "FV_OG_SP_MS25.SNX",
            "FV_OG_SP_MS27.SNX", "FV_OG_SP_MY24.SNX", "FV_OG_SP_NV30.SNX", "FV_OG_SP_RCLICK.SNX", "FV_OG_SP_RM24.SNX",
            "FV_OG_SP_SBD25N1.SNX", "FV_OG_SP_SBRM14N1.SNX", "FV_OG_SP_SBRM17M1.SNX" };

        private static List<string> filesList_FV_OG_CH = new List<string> { "FV_OG_CH_AK26.SNX", "FV_OG_CH_DS01.SNX", "FV_OG_CH_DS05.SNX",
            "FV_OG_CH_DS07.SNX", "FV_OG_CH_DS09.SNX", "FV_OG_CH_DS10_A.SNX", "FV_OG_CH_DS18.SNX", "FV_OG_CH_DS19.SNX",
            "FV_OG_CH_DS22.SNX", "FV_OG_CH_DS24.SNX", "FV_OG_CH_MI26.SNX", "FV_OG_CH_MS22.SNX", "FV_OG_CH_MS25.SNX",
            "FV_OG_CH_MS27.SNX", "FV_OG_CH_MY24.SNX", "FV_OG_CH_NV30.SNX", "FV_OG_CH_RCLICK.SNX", "FV_OG_CH_RM24.SNX",
            "FV_OG_CH_SBD25N1.SNX", "FV_OG_CH_SBRM14N1.SNX", "FV_OG_CH_SBRM17M1.SNX" };

        private static List<string> filesList_FV_OG_KR = new List<string> { "FV_OG_KR_AK26.SNX", "FV_OG_KR_CGMODEAK.SNX",
            "FV_OG_KR_CGMODEMO.SNX", "FV_OG_KR_CGMODEMS.SNX", "FV_OG_KR_CGMODEMU.SNX", "FV_OG_KR_CGMODEMZ.SNX", "FV_OG_KR_CGMODENN.SNX",
            "FV_OG_KR_DS01.SNX", "FV_OG_KR_DS05.SNX", "FV_OG_KR_DS07.SNX", "FV_OG_KR_DS09.SNX", "FV_OG_KR_DS10_A.SNX",
            "FV_OG_KR_DS18.SNX", "FV_OG_KR_DS19.SNX", "FV_OG_KR_DS22.SNX", "FV_OG_KR_DS24.SNX", "FV_OG_KR_MS22.SNX",
            "FV_OG_KR_MS25.SNX", "FV_OG_KR_MS27.SNX", "FV_OG_KR_MY24.SNX", "FV_OG_KR_NV30.SNX", "FV_OG_KR_RCLICK.SNX",
            "FV_OG_KR_RM24.SNX", "FV_OG_KR_SBD25N1.SNX", "FV_OG_KR_SBRM14N1.SNX", "FV_OG_KR_SBRM17M1.SNX" };

        private static List<string> filesList_VI_OG_JP = new List<string> { "VI_OG_JP_AK26.SNX", "VI_OG_JP_DS01.SNX", "VI_OG_JP_DS05.SNX",
            "VI_OG_JP_DS07.SNX", "VI_OG_JP_DS09.SNX", "VI_OG_JP_DS10_A.SNX", "VI_OG_JP_DS18.SNX", "VI_OG_JP_DS19.SNX",
            "VI_OG_JP_DS22.SNX", "VI_OG_JP_DS24.SNX", "VI_OG_JP_MI26.SNX", "VI_OG_JP_MS22.SNX", "VI_OG_JP_MS25.SNX",
            "VI_OG_JP_MS27.SNX", "VI_OG_JP_MY24.SNX", "VI_OG_JP_NV30.SNX", "VI_OG_JP_RCLICK.SNX", "VI_OG_JP_RM24.SNX",
            "VI_OG_JP_SBD25N1.SNX", "VI_OG_JP_SBRM14N1.SNX", "VI_OG_JP_SBRM17M1.SNX" };

        private static List<string> filesList_VI_OG_EN = new List<string> { "VI_OG_EN_AK26.SNX", "VI_OG_EN_DS01.SNX", "VI_OG_EN_DS05.SNX",
            "VI_OG_EN_DS07.SNX", "VI_OG_EN_DS09.SNX", "VI_OG_EN_DS10_A.SNX", "VI_OG_EN_DS18.SNX", "VI_OG_EN_DS19.SNX",
            "VI_OG_EN_DS22.SNX", "VI_OG_EN_DS24.SNX", "VI_OG_EN_MI26.SNX", "VI_OG_EN_MS22.SNX", "VI_OG_EN_MS25.SNX",
            "VI_OG_EN_MS27.SNX", "VI_OG_EN_MY24.SNX", "VI_OG_EN_NV30.SNX", "VI_OG_EN_RCLICK.SNX", "VI_OG_EN_RM24.SNX",
            "VI_OG_EN_SBD25N1.SNX", "VI_OG_EN_SBRM14N1.SNX", "VI_OG_EN_SBRM17M1.SNX" };

        private static List<string> filesList_FV_PS1_NCG = new List<string> { "FV_PS1_CGMODEAK.SNX", "FV_PS1_CGMODEMO.SNX", "FV_PS1_CGMODEMS.SNX",
            "FV_PS1_CGMODEMU.SNX", "FV_PS1_CGMODEMZ.SNX", "FV_PS1_CGMODENN.SNX" };

        private static List<string> filesList_FV_PS1_NA = new List<string> { "FV_PS1_AP00.SNX", "FV_PS1_CGMODE.SNX", "FV_PS1_CGMODENA.SNX" };

        private static List<string> filesList_FV_PS1_NECEMEM = new List<string> { "FV_PS1_NECEMEM.SNX" };

        private static List<string> filesList_VI_PS1 = new List<string> { "VI_PS1_AP00.SNX", "VI_PS1_CGMODE.SNX", "VI_PS1_CGMODEAK.SNX",
            "VI_PS1_CGMODEMO.SNX", "VI_PS1_CGMODEMS.SNX", "VI_PS1_CGMODEMU.SNX", "VI_PS1_CGMODEMZ.SNX", "VI_PS1_CGMODENA.SNX",
            "VI_PS1_CGMODENN.SNX" };

        private static List<string> filesList_FV_PS1_JP = new List<string> { "FV_PS1_JP_AK26.SNX", "FV_PS1_JP_DS01.SNX", "FV_PS1_JP_DS05.SNX",
            "FV_PS1_JP_DS07.SNX", "FV_PS1_JP_DS09.SNX", "FV_PS1_JP_DS10_A.SNX", "FV_PS1_JP_DS18.SNX", "FV_PS1_JP_DS19.SNX",
            "FV_PS1_JP_DS22.SNX", "FV_PS1_JP_DS24.SNX", "FV_PS1_JP_MS22.SNX", "FV_PS1_JP_MS25.SNX", "FV_PS1_JP_MS27.SNX",
            "FV_PS1_JP_MY24.SNX", "FV_PS1_JP_NA18.SNX", "FV_PS1_JP_NA22.SNX", "FV_PS1_JP_NA24.SNX", "FV_PS1_JP_NA25.SNX",
            "FV_PS1_JP_NA27.SNX", "FV_PS1_JP_NAE.SNX", "FV_PS1_JP_NV30.SNX", "FV_PS1_JP_RM24.SNX", "FV_PS1_JP_SBD25N1.SNX",
            "FV_PS1_JP_SBRM14N1.SNX", "FV_PS1_JP_SBRM17M1.SNX" };

        private static List<string> filesList_FV_PS1_EN = new List<string> { "FV_PS1_EN_AK26.SNX", "FV_PS1_EN_DS01.SNX", "FV_PS1_EN_DS05.SNX",
            "FV_PS1_EN_DS07.SNX", "FV_PS1_EN_DS09.SNX", "FV_PS1_EN_DS10_A.SNX", "FV_PS1_EN_DS18.SNX", "FV_PS1_EN_DS19.SNX",
            "FV_PS1_EN_DS22.SNX", "FV_PS1_EN_DS24.SNX", "FV_PS1_EN_MS22.SNX", "FV_PS1_EN_MS25.SNX", "FV_PS1_EN_MS27.SNX",
            "FV_PS1_EN_MY24.SNX", "FV_PS1_EN_NA18.SNX", "FV_PS1_EN_NA22.SNX", "FV_PS1_EN_NA24.SNX", "FV_PS1_EN_NA25.SNX",
            "FV_PS1_EN_NA27.SNX", "FV_PS1_EN_NAE.SNX", "FV_PS1_EN_NV30.SNX", "FV_PS1_EN_RM24.SNX", "FV_PS1_EN_SBD25N1.SNX",
            "FV_PS1_EN_SBRM14N1.SNX", "FV_PS1_EN_SBRM17M1.SNX" };

        private static List<string> filesList_FV_PS1_SP = new List<string> { "FV_PS1_SP_AK26.SNX", "FV_PS1_SP_DS01.SNX", "FV_PS1_SP_DS05.SNX",
            "FV_PS1_SP_DS07.SNX", "FV_PS1_SP_DS09.SNX", "FV_PS1_SP_DS10_A.SNX", "FV_PS1_SP_DS18.SNX", "FV_PS1_SP_DS19.SNX",
            "FV_PS1_SP_DS22.SNX", "FV_PS1_SP_DS24.SNX", "FV_PS1_SP_MS22.SNX", "FV_PS1_SP_MS25.SNX", "FV_PS1_SP_MS27.SNX",
            "FV_PS1_SP_MY24.SNX", "FV_PS1_SP_NA18.SNX", "FV_PS1_SP_NA22.SNX", "FV_PS1_SP_NA24.SNX", "FV_PS1_SP_NA25.SNX",
            "FV_PS1_SP_NA27.SNX", "FV_PS1_SP_NAE.SNX", "FV_PS1_SP_NV30.SNX", "FV_PS1_SP_RM24.SNX", "FV_PS1_SP_SBD25N1.SNX",
            "FV_PS1_SP_SBRM14N1.SNX", "FV_PS1_SP_SBRM17M1.SNX" };

        private static List<string> filesList_FV_PS1_CH = new List<string> { "FV_PS1_CH_AK26.SNX", "FV_PS1_CH_DS01.SNX", "FV_PS1_CH_DS05.SNX",
            "FV_PS1_CH_DS07.SNX", "FV_PS1_CH_DS09.SNX", "FV_PS1_CH_DS10_A.SNX", "FV_PS1_CH_DS19.SNX", "FV_PS1_CH_MS22.SNX",
            "FV_PS1_CH_MS25.SNX", "FV_PS1_CH_MS27.SNX", "FV_PS1_CH_MY24.SNX", "FV_PS1_CH_NV30.SNX", "FV_PS1_CH_RM24.SNX",
            "FV_PS1_CH_SBD25N1.SNX", "FV_PS1_CH_SBRM14N1.SNX", "FV_PS1_CH_SBRM17M1.SNX" };

        private static List<string> filesList_FV_PS1_KR = new List<string> { "FV_PS1_KR_AK26.SNX", "FV_PS1_KR_DS01.SNX", "FV_PS1_KR_DS05.SNX",
            "FV_PS1_KR_DS07.SNX", "FV_PS1_KR_DS09.SNX", "FV_PS1_KR_DS10_A.SNX", "FV_PS1_KR_DS19.SNX", "FV_PS1_KR_MS22.SNX",
            "FV_PS1_KR_MS25.SNX", "FV_PS1_KR_MS27.SNX", "FV_PS1_KR_MY24.SNX", "FV_PS1_KR_NV30.SNX", "FV_PS1_KR_RM24.SNX",
            "FV_PS1_KR_SBD25N1.SNX", "FV_PS1_KR_SBRM14N1.SNX", "FV_PS1_KR_SBRM17M1.SNX" };

        private static List<string> filesList_VI_PS1_JP = new List<string> { "VI_PS1_JP_AK26.SNX", "VI_PS1_JP_DS01.SNX", "VI_PS1_JP_DS05.SNX",
            "VI_PS1_JP_DS07.SNX", "VI_PS1_JP_DS09.SNX", "VI_PS1_JP_DS10_A.SNX", "VI_PS1_JP_DS18.SNX", "VI_PS1_JP_DS19.SNX",
            "VI_PS1_JP_DS22.SNX", "VI_PS1_JP_DS24.SNX", "VI_PS1_JP_MS22.SNX", "VI_PS1_JP_MS25.SNX", "VI_PS1_JP_MS27.SNX",
            "VI_PS1_JP_MY24.SNX", "VI_PS1_JP_NA18.SNX", "VI_PS1_JP_NA22.SNX", "VI_PS1_JP_NA24.SNX", "VI_PS1_JP_NA25.SNX",
            "VI_PS1_JP_NA27.SNX", "VI_PS1_JP_NAE.SNX", "VI_PS1_JP_NV30.SNX", "VI_PS1_JP_RM24.SNX", "VI_PS1_JP_SBD25N1.SNX",
            "VI_PS1_JP_SBRM14N1.SNX", "VI_PS1_JP_SBRM17M1.SNX" };

        private static List<string> filesList_VI_PS1_EN = new List<string> { "VI_PS1_EN_AK26.SNX", "VI_PS1_EN_DS01.SNX", "VI_PS1_EN_DS05.SNX",
            "VI_PS1_EN_DS07.SNX", "VI_PS1_EN_DS09.SNX", "VI_PS1_EN_DS10_A.SNX", "VI_PS1_EN_DS18.SNX", "VI_PS1_EN_DS19.SNX",
            "VI_PS1_EN_DS22.SNX", "VI_PS1_EN_DS24.SNX", "VI_PS1_EN_MS22.SNX", "VI_PS1_EN_MS25.SNX", "VI_PS1_EN_MS27.SNX",
            "VI_PS1_EN_MY24.SNX", "VI_PS1_EN_NA18.SNX", "VI_PS1_EN_NA22.SNX", "VI_PS1_EN_NA24.SNX", "VI_PS1_EN_NA25.SNX",
            "VI_PS1_EN_NA27.SNX", "VI_PS1_EN_NAE.SNX", "VI_PS1_EN_NV30.SNX", "VI_PS1_EN_RM24.SNX", "VI_PS1_EN_SBD25N1.SNX",
            "VI_PS1_EN_SBRM14N1.SNX", "VI_PS1_EN_SBRM17M1.SNX" };

        private static List<string> filesList_FV_AA = new List<string> { "FV_AA_CGMODEAK.SNX", "FV_AA_CGMODEMO.SNX", "FV_AA_CGMODEMS.SNX",
            "FV_AA_CGMODEMU.SNX", "FV_AA_CGMODEMZ.SNX", "FV_AA_CGMODENN.SNX" };

        private static List<string> filesList_VI_AA = new List<string> { "VI_AA_CGMODEAK.SNX", "VI_AA_CGMODEMO.SNX", "VI_AA_CGMODEMS.SNX",
            "VI_AA_CGMODEMU.SNX", "VI_AA_CGMODEMZ.SNX", "VI_AA_CGMODENN.SNX" };

        private static List<string> filesList_FV_AA_JP = new List<string> { "FV_AA_JP_AK26.SNX", "FV_AA_JP_MI26.SNX" };

        private static List<string> filesList_FV_AA_EN = new List<string> { "FV_AA_EN_AK26.SNX", "FV_AA_EN_MI26.SNX" };

        private static List<string> filesList_FV_AA_SP = new List<string> { "FV_AA_SP_AK26.SNX", "FV_AA_SP_MI26.SNX" };

        private static List<string> filesList_FV_AA_CH = new List<string> { "FV_AA_CH_AK26.SNX", "FV_AA_CH_MI26.SNX" };

        private static List<string> filesList_VI_AA_JP = new List<string> { "VI_AA_JP_AK26.SNX", "VI_AA_JP_MI26.SNX" };

        private static List<string> filesList_VI_AA_EN = new List<string> { "VI_AA_EN_AK26.SNX", "VI_AA_EN_MI26.SNX" };

        private static List<string> filesList_FV_PS1_AA = new List<string> { "FV_PS1_AA_CGMODEAK.SNX", "FV_PS1_AA_CGMODEMO.SNX", "FV_PS1_AA_CGMODEMS.SNX",
            "FV_PS1_AA_CGMODEMU.SNX", "FV_PS1_AA_CGMODEMZ.SNX", "FV_PS1_AA_CGMODENN.SNX" };

        private static List<string> filesList_VI_PS1_AA = new List<string> { "VI_PS1_AA_CGMODEAK.SNX", "VI_PS1_AA_CGMODEMO.SNX", "VI_PS1_AA_CGMODEMS.SNX",
            "VI_PS1_AA_CGMODEMU.SNX", "VI_PS1_AA_CGMODEMZ.SNX", "VI_PS1_AA_CGMODENN.SNX" };

        private static List<string> filesList_FV_PS1_AA_JP = new List<string> { "FV_PS1_AA_JP_AK26.SNX" };

        private static List<string> filesList_FV_PS1_AA_EN = new List<string> { "FV_PS1_AA_EN_AK26.SNX" };

        private static List<string> filesList_FV_PS1_AA_SP = new List<string> { "FV_PS1_AA_SP_AK26.SNX" };

        private static List<string> filesList_FV_PS1_AA_CH = new List<string> { "FV_PS1_AA_CH_AK26.SNX" };

        private static List<string> filesList_VI_PS1_AA_JP = new List<string> { "VI_PS1_AA_JP_AK26.SNX" };

        private static List<string> filesList_VI_PS1_AA_EN = new List<string> { "VI_PS1_AA_EN_AK26.SNX" };

        private static List<string> filesList_FV_MIS = new List<string> { "FV_MIS_CALCNUMBERSRCYGRID.SNX" };

        private static List<string> filesList_FV_MIS_JP = new List<string> { "FV_MIS_JP_RCLICK.SNX" };

        private static List<string> filesList_FV_MIS_EN = new List<string> { "FV_MIS_EN_RCLICK.SNX" };

        private static List<string> filesList_FV_MIS_SP = new List<string> { "FV_MIS_SP_RCLICK.SNX" };

        private static List<string> filesList_FV_MIS_CH = new List<string> { "FV_MIS_CH_RCLICK.SNX" };

        private static List<string> filesList_FV_MIS_KR = new List<string> { "FV_MIS_KR_RCLICK.SNX" };

        private static List<string> filesList_VI_MIS = new List<string> { "VI_MIS_CALCNUMBERSRCYGRID.SNX" };

        private static List<string> filesList_VI_MIS_JP = new List<string> { "VI_MIS_JP_RCLICK.SNX" };

        private static List<string> filesList_VI_MIS_EN = new List<string> { "VI_MIS_EN_RCLICK.SNX" };


        //Images Lists
        private static List<string> filesList_OG = new List<string> { "OG_FGAK12.PNG", "OG_FGAK13.PNG", "OG_FGAK14.PNG", "OG_FGAK15.PNG", 
            "OG_FGMI03.PNG", "OG_FGMI04.PNG", "OG_FGMI05.PNG", "OG_FGMI06.PNG", "OG_FGMS07.PNG", "OG_FGMS08.PNG", "OG_FGMS09.PNG", "OG_FGMS10.PNG", 
            "OG_FGMY11.PNG", "OG_FGMY12.PNG", "OG_FGMY13.PNG", "OG_FGMY14.PNG", "OG_FGMZ12.PNG", "OG_FGMZ13.PNG", "OG_FGMZ14.PNG", "OG_FGMZ15.PNG",
            "OG_FGRM07.PNG", "OG_FGRM12.PNG", "OG_FGRM13.PNG", "OG_FGRM14.PNG", "OG_FGRM15.PNG" };

        private static List<string> filesList_OG_JP = new List<string> { "OG_JP_CGMODEAKBK.PNG", "OG_JP_CGMODEAKCHIP.PNG", "OG_JP_CGMODEMOBK.PNG",
            "OG_JP_CGMODEMOCHIP.PNG", "OG_JP_CGMODEMSBK.PNG", "OG_JP_CGMODEMSCHIP.PNG", "OG_JP_CGMODEMUBK.PNG", "OG_JP_CGMODEMUCHIP.PNG",
            "OG_JP_CGMODEMZBK.PNG", "OG_JP_CGMODEMZCHIP.PNG", "OG_JP_CGMODENNBK.PNG", "OG_JP_CGMODENNCHIP.PNG", "OG_JP_CGMODETOPMENUAK.PNG",
            "OG_JP_CGMODETOPMENUBK.PNG", "OG_JP_CGMODETOPMENUCHIP.PNG", "OG_JP_CGMODETOPMENUMO.PNG", "OG_JP_CGMODETOPMENUMS.PNG",
            "OG_JP_CGMODETOPMENUMU.PNG", "OG_JP_CGMODETOPMENUMZ.PNG", "OG_JP_CGMODETOPMENUNN.PNG", "OG_JP_RCCHIP.PNG", "OG_JP_RCMENUBK.PNG",
            "OG_JP_タイトル背景.PNG" };

        private static List<string> filesList_OG_EN = new List<string> { "OG_EN_CGMODEAKBK.PNG", "OG_EN_CGMODEAKCHIP.PNG", "OG_EN_CGMODEMOBK.PNG",
            "OG_EN_CGMODEMOCHIP.PNG", "OG_EN_CGMODEMSBK.PNG", "OG_EN_CGMODEMSCHIP.PNG", "OG_EN_CGMODEMUBK.PNG", "OG_EN_CGMODEMUCHIP.PNG",
            "OG_EN_CGMODEMZBK.PNG", "OG_EN_CGMODEMZCHIP.PNG", "OG_EN_CGMODENNBK.PNG", "OG_EN_CGMODENNCHIP.PNG", "OG_EN_CGMODETOPMENUAK.PNG",
            "OG_EN_CGMODETOPMENUBK.PNG", "OG_EN_CGMODETOPMENUCHIP.PNG", "OG_EN_CGMODETOPMENUMO.PNG", "OG_EN_CGMODETOPMENUMS.PNG",
            "OG_EN_CGMODETOPMENUMU.PNG", "OG_EN_CGMODETOPMENUMZ.PNG", "OG_EN_CGMODETOPMENUNN.PNG", "OG_EN_RCCHIP.PNG", "OG_EN_RCMENUBK.PNG",
            "OG_EN_タイトル背景.PNG" };

        private static List<string> filesList_OG_SP = new List<string> { "OG_SP_CGMODEAKBK.PNG", "OG_SP_CGMODEAKCHIP.PNG", "OG_SP_CGMODEMOBK.PNG",
            "OG_SP_CGMODEMOCHIP.PNG", "OG_SP_CGMODEMSBK.PNG", "OG_SP_CGMODEMSCHIP.PNG", "OG_SP_CGMODEMUBK.PNG", "OG_SP_CGMODEMUCHIP.PNG",
            "OG_SP_CGMODEMZBK.PNG", "OG_SP_CGMODEMZCHIP.PNG", "OG_SP_CGMODENNBK.PNG", "OG_SP_CGMODENNCHIP.PNG", "OG_SP_CGMODETOPMENUAK.PNG",
            "OG_SP_CGMODETOPMENUBK.PNG", "OG_SP_CGMODETOPMENUCHIP.PNG", "OG_SP_CGMODETOPMENUMO.PNG", "OG_SP_CGMODETOPMENUMS.PNG",
            "OG_SP_CGMODETOPMENUMU.PNG", "OG_SP_CGMODETOPMENUMZ.PNG", "OG_SP_CGMODETOPMENUNN.PNG", "OG_SP_RCCHIP.PNG",
            "OG_SP_RCMENUBK.PNG", "OG_SP_タイトル背景.PNG" };

        private static List<string> filesList_OG_CH = new List<string> { "OG_CH_CGMODEAKBK.PNG", "OG_CH_CGMODEAKCHIP.PNG", "OG_CH_CGMODEMOBK.PNG",
            "OG_CH_CGMODEMOCHIP.PNG", "OG_CH_CGMODEMSBK.PNG", "OG_CH_CGMODEMSCHIP.PNG", "OG_CH_CGMODEMUBK.PNG", "OG_CH_CGMODEMUCHIP.PNG",
            "OG_CH_CGMODEMZBK.PNG", "OG_CH_CGMODEMZCHIP.PNG", "OG_CH_CGMODENNBK.PNG", "OG_CH_CGMODENNCHIP.PNG", "OG_CH_RCCHIP.PNG",
            "OG_CH_RCMENUBK.PNG", "OG_CH_タイトル背景.PNG" };

        private static List<string> filesList_OG_KR = new List<string> { "OG_KR_CGMODEAKBK.PNG", "OG_KR_CGMODEAKCHIP.PNG", "OG_KR_CGMODEMOBK.PNG",
            "OG_KR_CGMODEMOCHIP.PNG", "OG_KR_CGMODEMSBK.PNG", "OG_KR_CGMODEMSCHIP.PNG", "OG_KR_CGMODEMUBK.PNG", "OG_KR_CGMODEMUCHIP.PNG",
            "OG_KR_CGMODEMZBK.PNG", "OG_KR_CGMODEMZCHIP.PNG", "OG_KR_CGMODENNBK.PNG", "OG_KR_CGMODENNCHIP.PNG", "OG_KR_RCCHIP.PNG",
            "OG_KR_RCMENUBK.PNG", "OG_KR_タイトル背景.PNG" };

        private static List<string> filesList_PS1_NCG = new List<string> { "PS1_BG400.PNG", "PS1_FGAK17.PNG", "PS1_FGAK18.PNG", "PS1_FGMI17.PNG",
            "PS1_FGMI18.PNG", "PS1_FGMI19.PNG", "PS1_FGMS18.PNG", "PS1_FGMS19.PNG", "PS1_FGMY16.PNG", "PS1_FGMY17.PNG", "PS1_FGMZ17.PNG",
            "PS1_FGMZ18.PNG", "PS1_FGRM16.PNG", "PS1_FGRM17.PNG", "PS1_FGRM18.PNG" };

        private static List<string> filesList_PS1_NA = new List<string> { "PS1_CGNA01.PNG", "PS1_CGNA01M.PNG", "PS1_CGNA02.PNG", "PS1_CGNA02M.PNG",
            "PS1_CGNA03.PNG", "PS1_CGNA03M.PNG", "PS1_CGNA04.PNG", "PS1_CGNA04M.PNG", "PS1_CGNA05.PNG", "PS1_CGNA05M.PNG", "PS1_FGNA01A.PNG",
            "PS1_FGNA01B.PNG", "PS1_FGNA02.PNG", "PS1_FGNA03.PNG", "PS1_FGNA04.PNG", "PS1_FGNA05.PNG", "PS1_FGNA06.PNG", "PS1_FGNA07.PNG",
            "PS1_FGNA08.PNG", "PS1_FGNA09.PNG" };

        private static List<string> filesList_PS1_JP = new List<string> { "PS1_JP_BG814.PNG", "PS1_JP_CGMODEAKBK.PNG", "PS1_JP_CGMODEAKCHIP.PNG",
            "PS1_JP_CGMODEMOBK.PNG", "PS1_JP_CGMODEMOCHIP.PNG", "PS1_JP_CGMODEMSBK.PNG", "PS1_JP_CGMODEMSCHIP.PNG", "PS1_JP_CGMODEMUBK.PNG",
            "PS1_JP_CGMODEMUCHIP.PNG", "PS1_JP_CGMODEMZBK.PNG", "PS1_JP_CGMODEMZCHIP.PNG", "PS1_JP_CGMODENABK.PNG", "PS1_JP_CGMODENACHIP.PNG",
            "PS1_JP_CGMODENNBK.PNG", "PS1_JP_CGMODENNCHIP.PNG", "PS1_JP_CGMODETOPMENUAK.PNG", "PS1_JP_CGMODETOPMENUBK.PNG",
            "PS1_JP_CGMODETOPMENUCHIP.PNG", "PS1_JP_CGMODETOPMENUMO.PNG", "PS1_JP_CGMODETOPMENUMS.PNG", "PS1_JP_CGMODETOPMENUMU.PNG",
            "PS1_JP_CGMODETOPMENUMZ.PNG", "PS1_JP_CGMODETOPMENUNA.PNG", "PS1_JP_CGMODETOPMENUNN.PNG" };

        private static List<string> filesList_PS1_EN = new List<string> { "PS1_EN_BG814.PNG", "PS1_EN_CGMODEAKBK.PNG", "PS1_EN_CGMODEAKCHIP.PNG",
            "PS1_EN_CGMODEMOBK.PNG", "PS1_EN_CGMODEMOCHIP.PNG", "PS1_EN_CGMODEMSBK.PNG", "PS1_EN_CGMODEMSCHIP.PNG", "PS1_EN_CGMODEMUBK.PNG",
            "PS1_EN_CGMODEMUCHIP.PNG", "PS1_EN_CGMODEMZBK.PNG", "PS1_EN_CGMODEMZCHIP.PNG", "PS1_EN_CGMODENABK.PNG", "PS1_EN_CGMODENACHIP.PNG",
            "PS1_EN_CGMODENNBK.PNG", "PS1_EN_CGMODENNCHIP.PNG", "PS1_EN_CGMODETOPMENUAK.PNG", "PS1_EN_CGMODETOPMENUBK.PNG",
            "PS1_EN_CGMODETOPMENUCHIP.PNG", "PS1_EN_CGMODETOPMENUMO.PNG", "PS1_EN_CGMODETOPMENUMS.PNG", "PS1_EN_CGMODETOPMENUMU.PNG",
            "PS1_EN_CGMODETOPMENUMZ.PNG", "PS1_EN_CGMODETOPMENUNA.PNG", "PS1_EN_CGMODETOPMENUNN.PNG" };

        private static List<string> filesList_PS1_SP = new List<string> { "PS1_SP_BG814.PNG", "PS1_SP_CGMODEAKBK.PNG", "PS1_SP_CGMODEAKCHIP.PNG",
            "PS1_SP_CGMODEMOBK.PNG", "PS1_SP_CGMODEMOCHIP.PNG", "PS1_SP_CGMODEMSBK.PNG", "PS1_SP_CGMODEMSCHIP.PNG", "PS1_SP_CGMODEMUBK.PNG",
            "PS1_SP_CGMODEMUCHIP.PNG", "PS1_SP_CGMODEMZBK.PNG", "PS1_SP_CGMODEMZCHIP.PNG", "PS1_SP_CGMODENABK.PNG", "PS1_SP_CGMODENACHIP.PNG",
            "PS1_SP_CGMODENNBK.PNG", "PS1_SP_CGMODENNCHIP.PNG", "PS1_SP_CGMODETOPMENUAK.PNG", "PS1_SP_CGMODETOPMENUBK.PNG",
            "PS1_SP_CGMODETOPMENUCHIP.PNG", "PS1_SP_CGMODETOPMENUMO.PNG", "PS1_SP_CGMODETOPMENUMS.PNG", "PS1_SP_CGMODETOPMENUMU.PNG",
            "PS1_SP_CGMODETOPMENUMZ.PNG", "PS1_SP_CGMODETOPMENUNA.PNG", "PS1_SP_CGMODETOPMENUNN.PNG" };

        private static List<string> filesList_PS1_CH = new List<string> { "PS1_CH_CGMODEAKBK.PNG", "PS1_CH_CGMODEAKCHIP.PNG", "PS1_CH_CGMODEMOBK.PNG",
            "PS1_CH_CGMODEMOCHIP.PNG", "PS1_CH_CGMODEMSBK.PNG", "PS1_CH_CGMODEMSCHIP.PNG", "PS1_CH_CGMODEMUBK.PNG", "PS1_CH_CGMODEMUCHIP.PNG",
            "PS1_CH_CGMODEMZBK.PNG", "PS1_CH_CGMODEMZCHIP.PNG", "PS1_CH_CGMODENNBK.PNG", "PS1_CH_CGMODENNCHIP.PNG" };

        private static List<string> filesList_PS1_KR = new List<string> { "PS1_AA_KR_CGMODEAKBK.PNG", "PS1_KR_CGMODEAKCHIP.PNG", "PS1_AA_KR_CGMODEMOBK.PNG",
            "PS1_KR_CGMODEMOCHIP.PNG", "PS1_AA_KR_CGMODEMSBK.PNG", "PS1_KR_CGMODEMSCHIP.PNG", "PS1_AA_KR_CGMODEMUBK.PNG", "PS1_KR_CGMODEMUCHIP.PNG",
            "PS1_AA_KR_CGMODEMZBK.PNG", "PS1_KR_CGMODEMZCHIP.PNG", "PS1_AA_KR_CGMODENNBK.PNG", "PS1_KR_CGMODENNCHIP.PNG" };

        private static List<string> filesList_AA = new List<string> { "AA_FGAK12.PNG", "AA_FGAK13.PNG", "AA_FGAK14.PNG", "AA_FGAK15.PNG", "AA_FGMI03.PNG",
            "AA_FGMI04.PNG", "AA_FGMI05.PNG", "AA_FGMI06.PNG", "AA_FGMS07.PNG", "AA_FGMS08.PNG", "AA_FGMS09.PNG", "AA_FGMS10.PNG",
            "AA_FGMY11.PNG", "AA_FGMY12.PNG", "AA_FGMY13.PNG", "AA_FGMY14.PNG", "AA_FGMZ12.PNG", "AA_FGMZ13.PNG", "AA_FGMZ14.PNG",
            "AA_FGMZ15.PNG", "AA_FGRM07.PNG", "AA_FGRM12.PNG", "AA_FGRM13.PNG", "AA_FGRM14.PNG", "AA_FGRM15.PNG" };

        private static List<string> filesList_AA_JP = new List<string> { "AA_JP_CGMODEAKBK.PNG", "AA_JP_CGMODEMOBK.PNG", "AA_JP_CGMODEMSBK.PNG",
            "AA_JP_CGMODEMUBK.PNG", "AA_JP_CGMODEMZBK.PNG", "AA_JP_CGMODENNBK.PNG" };

        private static List<string> filesList_AA_EN = new List<string> { "AA_EN_CGMODEAKBK.PNG", "AA_EN_CGMODEMOBK.PNG", "AA_EN_CGMODEMSBK.PNG",
            "AA_EN_CGMODEMUBK.PNG", "AA_EN_CGMODEMZBK.PNG", "AA_EN_CGMODENNBK.PNG" };

        private static List<string> filesList_AA_SP = new List<string> { "AA_SP_CGMODEAKBK.PNG", "AA_SP_CGMODEMOBK.PNG", "AA_SP_CGMODEMSBK.PNG",
            "AA_SP_CGMODEMUBK.PNG", "AA_SP_CGMODEMZBK.PNG", "AA_SP_CGMODENNBK.PNG" };

        private static List<string> filesList_AA_CH = new List<string> { "AA_CH_CGMODEAKBK.PNG", "AA_CH_CGMODEMOBK.PNG", "AA_CH_CGMODEMSBK.PNG",
            "AA_CH_CGMODEMUBK.PNG", "AA_CH_CGMODEMZBK.PNG", "AA_CH_CGMODENNBK.PNG" };

        private static List<string> filesList_PS1_AA_JP = new List<string> { "PS1_AA_JP_CGMODEAKBK.PNG", "PS1_AA_JP_CGMODEMOBK.PNG",
            "PS1_AA_JP_CGMODEMSBK.PNG", "PS1_AA_JP_CGMODEMUBK.PNG", "PS1_AA_JP_CGMODEMZBK.PNG", "PS1_AA_JP_CGMODENNBK.PNG" };

        private static List<string> filesList_PS1_AA_EN = new List<string> { "PS1_AA_EN_CGMODEAKBK.PNG", "PS1_AA_EN_CGMODEMOBK.PNG",
            "PS1_AA_EN_CGMODEMSBK.PNG", "PS1_AA_EN_CGMODEMUBK.PNG", "PS1_AA_EN_CGMODEMZBK.PNG", "PS1_AA_EN_CGMODENNBK.PNG" };

        private static List<string> filesList_PS1_AA_SP = new List<string> { "PS1_AA_SP_CGMODEAKBK.PNG", "PS1_AA_SP_CGMODEMOBK.PNG",
            "PS1_AA_SP_CGMODEMSBK.PNG", "PS1_AA_SP_CGMODEMUBK.PNG", "PS1_AA_SP_CGMODEMZBK.PNG", "PS1_AA_SP_CGMODENNBK.PNG" };

        private static List<string> filesList_PS1_AA_CH = new List<string> { "PS1_AA_CH_CGMODEAKBK.PNG", "PS1_AA_CH_CGMODEMOBK.PNG",
            "PS1_AA_CH_CGMODEMSBK.PNG", "PS1_AA_CH_CGMODEMUBK.PNG", "PS1_AA_CH_CGMODEMZBK.PNG", "PS1_AA_CH_CGMODENNBK.PNG" };

        private static List<string> filesList_MIS_JP = new List<string> { "MIS_JP_RCCHIP.PNG", "MIS_JP_RCMENUBK.PNG" };

        private static List<string> filesList_MIS_EN = new List<string> { "MIS_EN_RCCHIP.PNG", "MIS_EN_RCMENUBK.PNG" };

        private static List<string> filesList_MIS_SP = new List<string> { "MIS_SP_RCCHIP.PNG", "MIS_SP_RCMENUBK.PNG" };

        private static List<string> filesList_MIS_CH = new List<string> { "MIS_CH_RCCHIP.PNG", "MIS_CH_RCMENUBK.PNG" };

        private static List<string> filesList_MIS_KR = new List<string> { "MIS_KR_RCCHIP.PNG", "MIS_KR_RCMENUBK.PNG" };

        private static List<string> filesList_EP_JP = new List<string> { "EP_JP_タイトル背景.PNG" };

        private static List<string> filesList_EP_EN = new List<string> { "EP_EN_タイトル背景.PNG" };

        private static List<string> filesList_EP_SP = new List<string> { "EP_SP_タイトル背景.PNG" };

        private static List<string> filesList_EP_CH = new List<string> { "EP_CH_タイトル背景.PNG" };

        private static List<string> filesList_EP_KR = new List<string> { "EP_KR_タイトル背景.PNG" };

        public static void InitializeLists(out List<Entry> patchSNXFilesList, out List<Entry> patchIMGFilesList, out List<Entry> patchSNDFilesList, ArchiveFileSystem afsPatchFiles, Edition edition, Language language, bool PS1Content, bool AAContent, bool miscContent)
        {
            patchSNXFilesList = new List<Entry>();
            patchIMGFilesList = new List<Entry>();
            patchSNDFilesList = new List<Entry>();

            List<string> patchSNXFilesListTmp = new List<string>();
            List<string> patchIMGFilesListTmp = new List<string>();


            //////////////////////////////
            //OG SCRIPTS
            //////////////////////////////
            
            //Full Voice Edition
            if (edition == Edition.FV)
            {
                if (language != Language.SP)
                    AddToList(filesList_FV_OG, patchSNXFilesListTmp);

                //Japanese
                if (language == Language.JP)
                    AddToList(filesList_FV_OG_JP, patchSNXFilesListTmp);
                //English
                else if (language == Language.EN)
                    AddToList(filesList_FV_OG_EN, patchSNXFilesListTmp);
                //Spanish
                else if (language == Language.SP)
                    AddToList(filesList_FV_OG_SP, patchSNXFilesListTmp);
                //Chinese
                else if (language == Language.CH)
                    AddToList(filesList_FV_OG_CH, patchSNXFilesListTmp);
                //Korean
                else if (language == Language.KR)
                    AddToList(filesList_FV_OG_KR, patchSNXFilesListTmp);
            }
            //Vista Edition
            else if (edition == Edition.VI)
            {
                AddToList(filesList_VI_OG, patchSNXFilesListTmp);

                //Japanese
                if (language == Language.JP)
                    AddToList(filesList_VI_OG_JP, patchSNXFilesListTmp);
                //English
                else if (language == Language.EN)
                    AddToList(filesList_VI_OG_EN, patchSNXFilesListTmp);
            }


            //////////////////////////////
            //OG IMAGES
            //////////////////////////////

            if (language != Language.SP && language != Language.KR)
                AddToList(filesList_OG, patchIMGFilesListTmp);

            //Japanese
            if (language == Language.JP)
                AddToList(filesList_OG_JP, patchIMGFilesListTmp);

            //English
            else if (language == Language.EN)
                AddToList(filesList_OG_EN, patchIMGFilesListTmp);

            //Spanish
            else if (language == Language.SP)
                AddToList(filesList_OG_SP, patchIMGFilesListTmp);

            //Chinese
            else if (language == Language.CH)
                AddToList(filesList_OG_CH, patchIMGFilesListTmp);

            //Korean
            else if (language == Language.KR)
                AddToList(filesList_OG_KR, patchIMGFilesListTmp);


            //////////////////////////////
            //PS1 CONTENT
            //////////////////////////////

            if (PS1Content)
            {
                //////////////////////////////
                //PS1 SCRIPTS
                //////////////////////////////

                //Full Voice Edition
                if (edition == Edition.FV)
                {
                    //New CGs
                    AddToList(filesList_FV_PS1_NCG, patchSNXFilesListTmp);

                    //Natsuki's route
                    if (language == Language.JP || language == Language.EN || language == Language.SP)
                        AddToList(filesList_FV_PS1_NA, patchSNXFilesListTmp);

                    //The file NECEMEM.SNX absolutely must be put into the one archive to work,
                    //it'll be treated later on in the case of the Spanish translation
                    if (language != Language.SP)
                        AddToList(filesList_FV_PS1_NECEMEM, patchSNXFilesListTmp);

                    //Japanese
                    if (language == Language.JP)
                        AddToList(filesList_FV_PS1_JP, patchSNXFilesListTmp);

                    //English
                    else if (language == Language.EN)
                        AddToList(filesList_FV_PS1_EN, patchSNXFilesListTmp);

                    //Spanish
                    else if (language == Language.SP)
                        AddToList(filesList_FV_PS1_SP, patchSNXFilesListTmp);

                    //Chinese
                    else if (language == Language.CH)
                        AddToList(filesList_FV_PS1_CH, patchSNXFilesListTmp);

                    //Korean
                    else if (language == Language.KR)
                    {
                        AddToList(filesList_FV_PS1_AA, patchSNXFilesListTmp);
                        AddToList(filesList_FV_PS1_KR, patchSNXFilesListTmp);
                    }
                }
                //Vista Edition
                else if (edition == Edition.VI)
                {
                    AddToList(filesList_VI_PS1, patchSNXFilesListTmp);

                    //Japanese
                    if (language == Language.JP)
                        AddToList(filesList_VI_PS1_JP, patchSNXFilesListTmp);
                    //English
                    else if (language == Language.EN)
                        AddToList(filesList_VI_PS1_EN, patchSNXFilesListTmp);
                }

                //////////////////////////////
                //PS1 IMAGES
                //////////////////////////////

                //New CGs
                AddToList(filesList_PS1_NCG, patchIMGFilesListTmp);

                //Natsuki's route
                if (language == Language.JP || language == Language.EN || language == Language.SP)
                    AddToList(filesList_PS1_NA, patchIMGFilesListTmp);

                //Japanese
                if (language == Language.JP)
                    AddToList(filesList_PS1_JP, patchIMGFilesListTmp);

                //English
                else if (language == Language.EN)
                    AddToList(filesList_PS1_EN, patchIMGFilesListTmp);

                //Spanish
                else if (language == Language.SP)
                    AddToList(filesList_PS1_SP, patchIMGFilesListTmp);

                //Chinese
                else if (language == Language.CH)
                    AddToList(filesList_PS1_CH, patchIMGFilesListTmp);

                //Korean
                else if (language == Language.KR)
                    AddToList(filesList_PS1_KR, patchIMGFilesListTmp);
            }


            //////////////////////////////
            //ALL-AGES
            //////////////////////////////

            if (AAContent)
            {
                //////////////////////////////
                //AA SCRIPTS
                //////////////////////////////

                //Full Voice Edition
                if (edition == Edition.FV)
                {
                    AddToList(filesList_FV_AA, patchSNXFilesListTmp);

                    //Japanese
                    if (language == Language.JP)
                        AddToList(filesList_FV_AA_JP, patchSNXFilesListTmp);

                    //English
                    else if (language == Language.EN)
                        AddToList(filesList_FV_AA_EN, patchSNXFilesListTmp);

                    //Spanish
                    else if (language == Language.SP)
                        AddToList(filesList_FV_AA_SP, patchSNXFilesListTmp);

                    //Chinese
                    else if (language == Language.CH)
                        AddToList(filesList_FV_AA_CH, patchSNXFilesListTmp);
                }
                //Vista Edition
                else if (edition == Edition.VI)
                {
                    AddToList(filesList_VI_AA, patchSNXFilesListTmp);

                    //Japanese
                    if (language == Language.JP)
                        AddToList(filesList_VI_AA_JP, patchSNXFilesListTmp);
                    //English
                    else if (language == Language.EN)
                        AddToList(filesList_VI_AA_EN, patchSNXFilesListTmp);
                }

                //////////////////////////////
                //AA IMAGES
                //////////////////////////////

                AddToList(filesList_AA, patchIMGFilesListTmp);

                //Japanese
                if (language == Language.JP)
                    AddToList(filesList_AA_JP, patchIMGFilesListTmp);

                //English
                else if (language == Language.EN)
                    AddToList(filesList_AA_EN, patchIMGFilesListTmp);

                //Spanish
                else if (language == Language.SP)
                    AddToList(filesList_AA_SP, patchIMGFilesListTmp);

                //Chinese
                else if (language == Language.CH)
                    AddToList(filesList_AA_CH, patchIMGFilesListTmp);
            }


            //////////////////////////////
            //PS1 CONTENT + ALL-AGES
            //////////////////////////////

            if (PS1Content && AAContent)
            {
                //////////////////////////////
                //PS1 AA SCRIPTS
                //////////////////////////////

                //Full Voice Edition
                if (edition == Edition.FV)
                {
                    AddToList(filesList_FV_PS1_AA, patchSNXFilesListTmp);

                    //Japanese
                    if (language == Language.JP)
                        AddToList(filesList_FV_PS1_AA_JP, patchSNXFilesListTmp);

                    //English
                    else if (language == Language.EN)
                        AddToList(filesList_FV_PS1_AA_EN, patchSNXFilesListTmp);

                    //Spanish
                    else if (language == Language.SP)
                        AddToList(filesList_FV_PS1_AA_SP, patchSNXFilesListTmp);

                    //Chinese
                    else if (language == Language.CH)
                        AddToList(filesList_FV_PS1_AA_CH, patchSNXFilesListTmp);
                }
                //Vista Edition
                else if (edition == Edition.VI)
                {
                    AddToList(filesList_VI_PS1_AA, patchSNXFilesListTmp);

                    //Japanese
                    if (language == Language.JP)
                        AddToList(filesList_VI_PS1_AA_JP, patchSNXFilesListTmp);
                    //English
                    else if (language == Language.EN)
                        AddToList(filesList_VI_PS1_AA_EN, patchSNXFilesListTmp);
                }

                //////////////////////////////
                //PS1 AA IMAGES
                //////////////////////////////

                //Japanese
                if (language == Language.JP)
                    AddToList(filesList_PS1_AA_JP, patchIMGFilesListTmp);

                //English
                else if (language == Language.EN)
                    AddToList(filesList_PS1_AA_EN, patchIMGFilesListTmp);

                //Spanish
                else if (language == Language.SP)
                    AddToList(filesList_PS1_AA_SP, patchIMGFilesListTmp);

                //Chinese
                else if (language == Language.CH)
                    AddToList(filesList_PS1_AA_CH, patchIMGFilesListTmp);
            }

            //////////////////////////////
            //MISCELLANEOUS
            //////////////////////////////

            if (miscContent)
            {
                //////////////////////////////
                //MISCELLANEOUS SCRIPTS
                //////////////////////////////

                //Full Voice Edition
                if (edition == Edition.FV)
                {
                    AddToList(filesList_FV_MIS, patchSNXFilesListTmp);

                    //Japanese
                    if (language == Language.JP)
                        AddToList(filesList_FV_MIS_JP, patchSNXFilesListTmp);

                    //English
                    else if (language == Language.EN)
                        AddToList(filesList_FV_MIS_EN, patchSNXFilesListTmp);

                    //Spanish
                    else if (language == Language.SP)
                        AddToList(filesList_FV_MIS_SP, patchSNXFilesListTmp);

                    //Chinese
                    else if (language == Language.CH)
                        AddToList(filesList_FV_MIS_CH, patchSNXFilesListTmp);

                    //Korean
                    else if (language == Language.KR)
                        AddToList(filesList_FV_MIS_KR, patchSNXFilesListTmp);
                }
                //Vista Edition
                else if (edition == Edition.VI)
                {
                    AddToList(filesList_VI_MIS, patchSNXFilesListTmp);

                    //Japanese
                    if (language == Language.JP)
                        AddToList(filesList_VI_MIS_JP, patchSNXFilesListTmp);

                    //English and Spanish
                    else if (language == Language.EN)
                        AddToList(filesList_VI_MIS_EN, patchSNXFilesListTmp);
                }

                //////////////////////////////
                //MISCELLANEOUS IMAGES
                //////////////////////////////

                //Japanese
                if (language == Language.JP)
                    AddToList(filesList_MIS_JP, patchIMGFilesListTmp);

                //English
                else if (language == Language.EN)
                    AddToList(filesList_MIS_EN, patchIMGFilesListTmp);

                //Spanish
                else if (language == Language.SP)
                    AddToList(filesList_MIS_SP, patchIMGFilesListTmp);

                //Chinese
                else if (language == Language.CH)
                    AddToList(filesList_MIS_CH, patchIMGFilesListTmp);

                //Korean
                else if (language == Language.KR)
                    AddToList(filesList_MIS_KR, patchIMGFilesListTmp);
            }


            //////////////////////////////
            //ETERNAL PATCH TITLE SCREEN
            //////////////////////////////

            if (PS1Content || AAContent || miscContent)
            {
                //Japanese
                if (language == Language.JP)
                    AddToList(filesList_EP_JP, patchIMGFilesListTmp);

                //English
                else if (language == Language.EN)
                    AddToList(filesList_EP_EN, patchIMGFilesListTmp);

                //Spanish
                else if (language == Language.SP)
                    AddToList(filesList_EP_SP, patchIMGFilesListTmp);

                //Chinese
                else if (language == Language.CH)
                    AddToList(filesList_EP_CH, patchIMGFilesListTmp);

                //Korean
                else if (language == Language.KR)
                    AddToList(filesList_EP_KR, patchIMGFilesListTmp);
            }




            foreach (string entry in patchSNXFilesListTmp) patchSNXFilesList.Add(afsPatchFiles.FindFile(entry));
            foreach (string entry in patchIMGFilesListTmp) patchIMGFilesList.Add(afsPatchFiles.FindFile(entry));

            //PS1 content, add the voices to the list
            if (PS1Content)
            {
                for (int i = 1; i <= 170; i++)
                    patchSNDFilesList.Add(afsPatchFiles.FindFile("PS1_NAT"+ i.ToString().PadLeft(4, '0')+".WAV"));
            }

            RemovePrefix(patchSNXFilesList);
            RemovePrefix(patchIMGFilesList);
            RemovePrefix(patchSNDFilesList);
        }

        //Add new files to a list while removing files that have already the same name (minus the prefix)
        private static void AddToList(List<string> inputList, List<string> outputList)
        {
            foreach (string input in inputList)
            {
                foreach (string inputPrefix in prefixList)
                {
                    if (input.StartsWith(inputPrefix))
                    {
                        foreach (string outputPrefix in prefixList)
                            outputList.Remove(outputPrefix + input.Replace(inputPrefix, ""));

                        outputList.Add(input);
                        break;
                    }
                }
            }
        }

        private static void RemovePrefix(List<Entry> list)
        {
            for (int j = 0; j < list.Count; j++)
            {
                string filename = (list.ToArray()[j]).Name;
                foreach (string prefix in prefixList)
                {
                    //Remove the prefix of the name of the files
                    if (filename.StartsWith(prefix))
                    {
                        (list.ToArray()[j]).Name = filename.Replace(prefix, "");
                        break;
                    }
                }
            }
        }
    }
}
