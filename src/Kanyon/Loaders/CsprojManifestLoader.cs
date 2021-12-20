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
            StartBuildProcess(filePath);

            var manifestFile = new FileInfo(Path.Combine(filePath.DirectoryName, "obj", "kanyon_temp", "publish", "manifest.dll"));
            base.FromFile(manifestFile);

            return this;
        }

        private void StartBuildProcess(FileInfo projectFile)
        {
            var psi = new ProcessStartInfo
            {
                FileName = "dotnet",
                Arguments = $"publish \"{projectFile.FullName}\" --nologo -o \"{projectFile.DirectoryName}\\obj\\kanyon_temp\\publish\" -c Release /p:AssemblyName=manifest",
                UseShellExecute = false,
                RedirectStandardOutput = true
            };

            var process = new Process();
            process.StartInfo = psi;
            process.OutputDataReceived += (sender, args ) => { Console.Error.WriteLine(args.Data); };
            process.Start();
            process.BeginOutputReadLine();
            process.WaitForExit();

            if (process.ExitCode != 0) throw new ApplicationException($"MSBuild project failed to build");
        }
    }
}