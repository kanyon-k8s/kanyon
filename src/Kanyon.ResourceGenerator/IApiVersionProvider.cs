using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kanyon.ResourceGenerator
{
    public interface IApiVersionProvider
    {
        ApiVersion GetApiVersion(OpenApiSchema schema);
    }
}
