using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kanyon.ResourceGenerator.Heuristics
{
    public class KubernetesExtensionManifestObjectHeuristic : IManifestObjectHeuristic
    {
        public bool Detect(OpenApiSchema schema, string name)
        {
            return schema.Extensions.ContainsKey("x-kubernetes-group-version-kind");
        }
    }
}
