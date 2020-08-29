using k8s;
using Kapitan.Core;
using Kapitan.Filters;
using Kapitan.Yaml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapitan
{
    public class ManifestSerializer
    {
        private readonly IManifestFilter filter;

        public ManifestSerializer(IManifestFilter filter)
        {
            this.filter = filter;
        }

        public string ProcessManifest(Manifest manifest)
        {
            var processedObjects = manifest.Where(manifestObject => filter.Filter(manifestObject)).Select(iko => YamlConverter.SerializeObject(iko));
            return String.Join("\n---\n", processedObjects);
        }
    }
}
