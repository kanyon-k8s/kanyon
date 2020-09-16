using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Kanyon.Loaders
{
    public static class ManifestLoaderFactory
    {
        public static IManifestLoader BuildManifestLoader(FileInfo file, bool isVerbose)
        {
            try
            {
                AssemblyName.GetAssemblyName(file.FullName);
                return new CompiledManifestLoader();
            }
            catch (BadImageFormatException)
            {
                return new ScriptManifestLoader() { Verbose = isVerbose };
            }
        }
    }
}
