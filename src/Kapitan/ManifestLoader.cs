using Dotnet.Script;
using Dotnet.Script.Core;
using Dotnet.Script.Core.Commands;
using Dotnet.Script.DependencyModel.Logging;
using Kapitan.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Kapitan
{
    public class ManifestLoader
    {
        public async Task<Manifest> LoadManifest(FileInfo file)
        {
            var console = new ScriptConsole(Console.Error, Console.In, Console.Error);
            var logger = LogHelper.CreateLogFactory("debug");

            var manifestSource = File.ReadAllText(file.FullName);

            var command = new ExecuteCodeCommand(console, logger);
            var options = new ExecuteCodeCommandOptions(manifestSource, file.DirectoryName, new string[] { }, Microsoft.CodeAnalysis.OptimizationLevel.Debug, true, null);

            var manifest = await command.Execute<Manifest>(options);

            return manifest;
        }
    }
}
