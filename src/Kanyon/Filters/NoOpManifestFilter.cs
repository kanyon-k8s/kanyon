using Kapitan.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kapitan.Filters
{
    public class NoOpManifestFilter : IManifestFilter
    {
        public bool Filter(IManifestObject manifestObject)
        {
            return true;
        }
    }
}
