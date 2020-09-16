using Kanyon.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kanyon.Filters
{
    public class NoCrdsManifestFilter : IManifestFilter
    {
        public bool Filter(IManifestObject manifestObject)
        {
            return !manifestObject.Kind.Equals("CustomResourceDefinition", StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
