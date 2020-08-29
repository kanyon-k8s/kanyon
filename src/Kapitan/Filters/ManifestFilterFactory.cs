using System;
using System.Collections.Generic;
using System.Text;

namespace Kapitan.Filters
{
    public static class ManifestFilterFactory
    {
        public static IManifestFilter BuildManifestFilter(CrdEmitOptions options)
        {
            switch (options)
            {
                case CrdEmitOptions.CrdsOnly: return new CrdsOnlyManifestFilter();
                case CrdEmitOptions.NoCrds: return new NoCrdsManifestFilter();
                default: return new NoOpManifestFilter();
            }
        }
    }
}
