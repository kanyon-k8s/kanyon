using System;
using System.Collections.Generic;
using System.Text;

namespace Kapitan.Core
{
    [AttributeUsage(AttributeTargets.Assembly)]
    public class KapitanManifestAttribute : Attribute
    {
        public Type ManifestType { get; set; }

        public KapitanManifestAttribute(Type manifestType)
        {
            ManifestType = manifestType;
        }
    }
}
