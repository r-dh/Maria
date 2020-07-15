using System.Collections.Generic;
using Maria.IO;

namespace Maria.Editor
{
    public class PluginAssociations
    {
        //--------------------------------------------------------------------------------------
        // Properties
        public Dictionary<PluginType, List<FileExtension>> Extensions { get; } = new Dictionary<PluginType, List<FileExtension>>()
        {
            { PluginType.DEBUG,   new List<FileExtension>() { FileExtension.DLL, FileExtension.PDB, FileExtension.META} },
            { PluginType.RELEASE, new List<FileExtension>() { FileExtension.DLL, FileExtension.META } }
        };

        //--------------------------------------------------------------------------------------
        public PluginAssociations()
        { }
    }
}
