using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONE_Eternal_Patch_GUI
{
    public class StandardSave
    {
        public string name { get; set; }
        public int size { get; set; }
        public int id { get; set; }
        public string scriptName { get; set; }
        public string subScriptName { get; set; }
        public int choiceFlagsNumber { get; set; }
        public int CGFlagsNumber { get; set; }
        public int textFlagsNumber { get; set; }

        public StandardSave()
        {
            name = "";
            size = -1;
            id = -1;
            scriptName = "";
            subScriptName = "";
            choiceFlagsNumber = -1;
            CGFlagsNumber = -1;
            textFlagsNumber = -1;
        }

    }
}
