using Kanyon.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Kanyon.Loaders
{
    public interface IPolicySetLoader
    {
        Task<IEnumerable<IPolicy>> Load();

        public FileInfo Source { get; set; }
    }
}
