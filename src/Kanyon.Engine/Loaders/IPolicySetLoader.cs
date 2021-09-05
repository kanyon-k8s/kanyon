using Kanyon.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Kanyon.Engine.Loaders
{
    public interface IPolicySetLoader
    {
        Task<IEnumerable<IPolicy>> Load();

        FileInfo Source { get; set; }
    }
}
