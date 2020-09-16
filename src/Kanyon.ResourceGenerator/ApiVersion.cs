using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kanyon.ResourceGenerator
{
    public class ApiVersion
    {
        public ApiVersion()
        {

        }

        public ApiVersion(string group, string version)
        {
            Group = group;
            Version = version;
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
            if (!string.IsNullOrEmpty(Group))
            {
                return $"{Group}/{Version}";
            }
            else return Version;
        }
    }
}
