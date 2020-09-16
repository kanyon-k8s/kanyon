using Kapitan.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Kapitan.Loaders
{
    public class ScriptPolicySetLoader : ScriptLoader<IEnumerable<IPolicy>>, IPolicySetLoader
    {
        public FileInfo Source { get; set; }

        public async Task<IEnumerable<IPolicy>> Load()
        {
            return await Load(Source);
        }
    }
}
