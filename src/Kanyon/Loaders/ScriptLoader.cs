using Dotnet.Script;
using Dotnet.Script.Core;
using Dotnet.Script.Core.Commands;
using Microsoft.CodeAnalysis.Scripting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Kanyon.Loaders
{
    public class ScriptLoader<T>
    {
        public bool Verbose { get; set; }

        public FileInfo Source { get; set; }


        public async Task<T> Load(FileInfo file)
        {
            Console.Error.WriteLine($"Compiling {file.FullName}");

            var console = new ScriptConsole(Console.Error, Console.In, Console.Error);
            var logger = LogHelper.CreateLogFactory(Verbose ? "debug" : "warning");

            var manifestSource = File.ReadAllText(file.FullName);

            var command = new ExecuteCodeCommand(console, logger);
            var options = new ExecuteCodeCommandOptions(manifestSource, file.DirectoryName, new string[] { }, Microsoft.CodeAnalysis.OptimizationLevel.Debug, true, null);

            return await command.Execute<T>(options);
        }
    }
}
