using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kapitan.ResourceGenerator.Heuristics
{
    public class KubernetesExtensionManifestObjectHeuristic : IManifestObjectHeuristic
    {
        public bool Detect(OpenApiSchema schema)
        {
            return schema.Extensions.ContainsKey("x-kubernetes-group-version-kind");
        }
    }
}
