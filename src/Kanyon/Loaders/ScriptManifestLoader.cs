using Dotnet.Script;
using Dotnet.Script.Core;
using Dotnet.Script.Core.Commands;
using Dotnet.Script.DependencyModel.Logging;
using Kanyon.Core;
using Kanyon.Engine.Loaders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Kanyon.Loaders
{
    public class ScriptManifestLoader : ScriptLoader<Manifest>, IManifestLoader
    {
        public async Task<Manifest> LoadManifest()
        {
            return await Load(Source);
        }
    }
}
