using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kanyon.ResourceGenerator.Heuristics
{
    public interface IManifestObjectHeuristic
    {
        bool Detect(OpenApiSchema schema, string name);
    }
}
