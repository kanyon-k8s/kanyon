using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class NodeSelectorTerm
    {
        /** <summary>A list of node selector requirements by node's labels.</summary> */
        public IEnumerable<Core.V1.NodeSelectorRequirement> matchExpressions { get; set; }
        /** <summary>A list of node selector requirements by node's fields.</summary> */
        public IEnumerable<Core.V1.NodeSelectorRequirement> matchFields { get; set; }
    }
}