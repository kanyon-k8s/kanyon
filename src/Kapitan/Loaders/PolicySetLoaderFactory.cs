using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Kapitan.Loaders
{
    public static class PolicySetLoaderFactory
    {
        public static IPolicySetLoader BuildPolicySetLoader(FileInfo file, bool isVerbose, string policySetName)
        {
            try
            {
                AssemblyName.GetAssemblyName(file.FullName);
                return new CompiledPolicySetLoader() { Source = file, PolicySetName = policySetName };
            }
            catch (BadImageFormatException)
            {
                return new ScriptPolicySetLoader() { Source = file, Verbose = isVerbose };
            }
        }
    }
}
