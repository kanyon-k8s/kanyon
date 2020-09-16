using Kanyon.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kanyon.Filters
{
    public class NoOpManifestFilter : IManifestFilter
    {
        public bool Filter(IManifestObject manifestObject)
        {
            return true;
        }
    }
}
