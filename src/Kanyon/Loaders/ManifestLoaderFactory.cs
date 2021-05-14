using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;

namespace Kanyon.Loaders
{
    public static class ManifestLoaderFactory
    {
        public static IManifestLoader BuildManifestLoader(string file, bool isVerbose)
        {
            IManifestLoader loader = null;
            if (Uri.IsWellFormedUriString(file, UriKind.Absolute))
            {
                WebClient client = new WebClient();
                var assemBytes = client.DownloadData(file);

                loader = new CompiledManifestLoader().FromBytes(assemBytes);
            }
            else
            {
                FileInfo fileInfo = new FileInfo(file);
                try
                {
                    AssemblyName.GetAssemblyName(fileInfo.FullName);
                    loader = new CompiledManifestLoader().FromFile(fileInfo);
                }
                catch (BadImageFormatException)
                {
                    var scriptLoader = new ScriptManifestLoader() { Source = fileInfo, Verbose = isVerbose };

                    loader = scriptLoader;
                }
            }

            return loader;
        }
    }
}
