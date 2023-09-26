
namespace ONE_Eternal_Patch_GUI
{
    public class StandardSave
    {
        public string Name { get; set; }
        public int Size { get; set; }
        public int Id { get; set; }
        public string ScriptName { get; set; }
        public string SubScriptName { get; set; }
        public int ChoiceFlagsNumber { get; set; }
        public int CGFlagsNumber { get; set; }
        public int TextFlagsNumber { get; set; }

        public StandardSave()
        {
            Name = "";
            Size = -1;
            Id = -1;
            ScriptName = "";
            SubScriptName = "";
            ChoiceFlagsNumber = -1;
            CGFlagsNumber = -1;
            TextFlagsNumber = -1;
        }

    }
}
