using Kanyon.Engine.Loaders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;

namespace Kanyon.Loaders
{
    public static class PolicySetLoaderFactory
    {
        public static IPolicySetLoader BuildPolicySetLoader(string filePath, bool isVerbose, string policySetName)
        {
            if (Uri.IsWellFormedUriString(filePath, UriKind.Absolute) && Convert.ToBoolean(Environment.GetEnvironmentVariable("KANYON_ALLOWUNSAFECODE")))
            {
                WebClient client = new WebClient();
                var bytes = client.DownloadData(filePath);

                return new CompiledPolicySetLoader { PolicySetName = policySetName }.FromBytes(bytes);
            }
            else
            {
                var file = new FileInfo(filePath);
                try
                {
                    AssemblyName.GetAssemblyName(file.FullName);
                    return new CompiledPolicySetLoader() { PolicySetName = policySetName }.FromFile(file);
                }
                catch (BadImageFormatException)
                {
                    return new ScriptPolicySetLoader() { Source = file, Verbose = isVerbose };
                }
            }
        }
    }
}
