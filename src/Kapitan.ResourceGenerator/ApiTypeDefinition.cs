﻿using Microsoft.OpenApi.Models;
using System.Collections.Generic;

namespace Kapitan.ResourceGenerator
{
    public class ApiTypeDefinition
    {
        public ApiVersion ApiVersion { get; set; }

        public string Namespace { get; set; }

        public string TypeName { get; set; }

        public OpenApiSchema Schema { get; set; }

        public string Directory { get; set; }
        public IEnumerable<PropertyDefinition> PropertyDefinitions { get; set; }
    }
}