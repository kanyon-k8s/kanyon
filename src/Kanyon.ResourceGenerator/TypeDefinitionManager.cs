using Humanizer;
using Kanyon.ResourceGenerator.Heuristics;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Kanyon.ResourceGenerator
{
    public class TypeDefinitionManager
    {
        private readonly IManifestObjectHeuristic heuristic;
        private readonly IApiVersionProvider apiVersionProvider;

        public TypeDefinitionManager(IManifestObjectHeuristic heuristic, IApiVersionProvider apiVersionProvider)
        {
            this.heuristic = heuristic;
            this.apiVersionProvider = apiVersionProvider;
        }

        public TypeMapper GetTypeMapper(Dictionary<string, OpenApiSchema> types)
        {
            var namespaceInfo = types.GroupBy(s => TypeMapper.StripPrefix(s.Key)).ToDictionary(
                g => g.Key,
                g => apiVersionProvider.GetApiVersion(g.First().Value)
            );

            return new TypeMapper(namespaceInfo, heuristic);
        }

        public List<ApiTypeDefinition> BuildTypeDefinitions(OpenApiDocument spec)
        {
            var rootTypes = spec.Components.Schemas.Where(s => heuristic.Detect(s.Value, s.Key)).ToDictionary(s => s.Key, s => s.Value);
            var typeMapper = GetTypeMapper(rootTypes);

            return spec.Components.Schemas.Select(kvp => typeMapper.BuildTypeDefinition(kvp.Key, kvp.Value)).ToList();
        }
    }
}
