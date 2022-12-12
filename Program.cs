using System;
using System.Windows.Forms;

namespace ONE_Eternal_Patch
{
    static class Program
    {
        /// <summary>
        /// Entry Point of the program.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ONE_Eternal_Patch_Gui());
        }
    }
}
