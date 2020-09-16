using Microsoft.OpenApi.Models;
using System.Collections.Generic;

namespace Kanyon.ResourceGenerator
{
    public class ApiTypeDefinition
    {
        public ApiVersion ApiVersion { get; set; }

        public string Namespace { get; set; }

        public string TypeName { get; set; }

        public OpenApiSchema Schema { get; set; }

        public string Directory { get; set; }
        public IEnumerable<PropertyDefinition> PropertyDefinitions { get; set; }
        public IEnumerable<string> EnumValues { get; set; }
        public bool IsManifestObject { get; internal set; }
        public bool IsEnumObject { get; set; }
    }
}