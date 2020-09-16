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

namespace Kapitan.Loaders
{
    public class ScriptManifestLoader : ScriptLoader<Manifest>, IManifestLoader
    {
        public async Task<Manifest> LoadManifest(FileInfo file)
        {
            return await Load(file);
        }
    }
}
