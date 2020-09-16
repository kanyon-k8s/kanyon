using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class TopologySelectorTerm
    {
        /** <summary>A list of topology selector requirements by labels.</summary> */
        public IEnumerable<Core.V1.TopologySelectorLabelRequirement> matchLabelExpressions { get; set; }
    }
}