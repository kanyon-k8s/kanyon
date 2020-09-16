using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kanyon.ResourceGenerator.Heuristics
{
    public class RequiredPropertyManifestObjectHeuristic : IManifestObjectHeuristic
    {
        public bool Detect(OpenApiSchema schema, string name)
        {
            var requiredProperties = new[] { "apiVersion", "kind", "spec" };
            return schema.Properties.Select(p => p.Key).Intersect(requiredProperties).Count() == requiredProperties.Length;
        }
    }
}
