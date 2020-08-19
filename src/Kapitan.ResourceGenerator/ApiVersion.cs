using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kapitan.ResourceGenerator
{
    public class ApiVersion
    {
        public ApiVersion()
        {

        }

        public ApiVersion(IOpenApiExtension extension)
        {
            if (extension is OpenApiArray array)
            {
                if (array[0] is OpenApiObject obj)
                {
                    Group = ((OpenApiString)obj["group"]).Value;
                    Version = ((OpenApiString)obj["version"]).Value;
                }
            }
        }

        public string Group { get; set; }

        public string Version { get; set; }


        public override string ToString()
        {
            return $"{Group}/{Version}";
        }
    }
}
