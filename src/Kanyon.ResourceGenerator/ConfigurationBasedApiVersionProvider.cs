using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kanyon.ResourceGenerator
{
    public class ConfigurationBasedApiVersionProvider : IApiVersionProvider
    {
        ApiVersion config;

        public ConfigurationBasedApiVersionProvider(string group, string version) : this(new ApiVersion(group, version)) { }

        public ConfigurationBasedApiVersionProvider(ApiVersion version)
        {
            config = version;
        }

        public ApiVersion GetApiVersion(OpenApiSchema schema)
        {
            return config;
        }
    }
}
