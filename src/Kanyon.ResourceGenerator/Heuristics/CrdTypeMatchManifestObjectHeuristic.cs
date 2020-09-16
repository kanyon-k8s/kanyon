using k8s;
using k8s.Models;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanyon.ResourceGenerator.Heuristics
{
    public class CrdTypeMatchManifestObjectHeuristic : IManifestObjectHeuristic
    {
        IEnumerable<V1CustomResourceDefinition> crds;

        public CrdTypeMatchManifestObjectHeuristic()
        {
            
        }

        public async Task InitializeAsync(string file)
        {
            var typeMap = new Dictionary<string, Type>()
            {
                { "v1/List", typeof(V1CustomResourceDefinitionList) }
            };

            var yaml = await Yaml.LoadAllFromFileAsync(file, typeMap);

            var list = yaml.FirstOrDefault() as V1CustomResourceDefinitionList;
            crds = list.Items;
        }

        public bool Detect(OpenApiSchema schema, string name)
        {
            var matchingCrd = crds.Where(crd => name.EndsWith(crd.Spec.Names.Kind)).FirstOrDefault();
            return matchingCrd != null;
        }
    }
}
