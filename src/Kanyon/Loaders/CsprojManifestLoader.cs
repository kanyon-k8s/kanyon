using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using Kanyon.Core;

namespace Kanyon.Loaders {
    public class CsprojManifestLoader : Kanyon.Engine.Loaders.CompiledManifestLoader 
    {
        public new CsprojManifestLoader FromFile(FileInfo filePath) 
        {
            StartBuildProcess(filePath.FullName);

            var manifestFile = new FileInfo(Path.Combine("kanyon_temp", "publish", "manifest.dll"));
            base.FromFile(manifestFile);

            return this;
        }

        private void StartBuildProcess(string projectFile)
        {
            var psi = new ProcessStartInfo
            {
                FileName = "dotnet",
                Arguments = $"build \"{projectFile}\" --nologo -o \"kanyon_temp\\publish\" /p:AssemblyName=manifest",
                UseShellExecute = false,
                RedirectStandardOutput = true
            };

            var process = new Process();
            process.StartInfo = psi;
            process.OutputDataReceived += (sender, args ) => { Console.Error.WriteLine(args.Data); };
            process.Start();
            process.BeginOutputReadLine();
            process.WaitForExit();
        }
    }
}