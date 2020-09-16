using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class ScopeSelector
    {
        /** <summary>A list of scope selector requirements by scope of the resources.</summary> */
        public IEnumerable<Core.V1.ScopedResourceSelectorRequirement> matchExpressions { get; set; }
    }
}