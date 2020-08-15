using k8s;
using Kapitan.Core;
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
        public string ProcessManifest(Manifest manifest)
        {
            var processedObjects = manifest.Select(iko => YamlConverter.SerializeObject(iko));
            return String.Join("\n---\n", processedObjects);
        }
    }
}
