using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kapitan.ResourceGenerator.Heuristics
{
    public interface IManifestObjectHeuristic
    {
        bool Detect(OpenApiSchema schema);
    }
}
