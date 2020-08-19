using Humanizer;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Kapitan.ResourceGenerator
{
    public class TypeDefinitionManager
    {
        public TypeMapper GetTypeMapper(Dictionary<string, OpenApiSchema> types)
        {
            var namespaceInfo = types.GroupBy(s => TypeMapper.StripPrefix(s.Key)).ToDictionary(
                g => g.Key,
                g => new ApiVersion(g.First().Value.Extensions["x-kubernetes-group-version-kind"])
            );

            return new TypeMapper(namespaceInfo);
        }

        public List<ApiTypeDefinition> BuildTypeDefinitions(OpenApiDocument spec)
        {
            var rootTypes = spec.Components.Schemas.Where(s => s.Value.Extensions.ContainsKey("x-kubernetes-group-version-kind")).ToDictionary(s => s.Key, s => s.Value);
            var typeMapper = GetTypeMapper(rootTypes);

            return spec.Components.Schemas.Select(kvp => typeMapper.BuildTypeDefinition(kvp.Key, kvp.Value)).ToList();
        }

        
    }
}
