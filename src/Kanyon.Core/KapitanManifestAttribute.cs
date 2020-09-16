using System;
using System.Collections.Generic;
using System.Text;

namespace Kanyon.Core
{
    [AttributeUsage(AttributeTargets.Assembly)]
    public class KanyonManifestAttribute : Attribute
    {
        public Type ManifestType { get; set; }

        public KanyonManifestAttribute(Type manifestType)
        {
            ManifestType = manifestType;
        }
    }
}
