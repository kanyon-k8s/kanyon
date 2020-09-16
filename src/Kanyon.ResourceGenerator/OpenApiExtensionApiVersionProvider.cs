using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kanyon.ResourceGenerator
{
    public class OpenApiExtensionApiVersionProvider : IApiVersionProvider
    {
        public ApiVersion GetApiVersion(OpenApiSchema schema)
        {
            return new ApiVersion(schema.Extensions["x-kubernetes-group-version-kind"]);
        }
    }
}
