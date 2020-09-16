using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class PreferredSchedulingTerm
    {
        /** <summary>A null or empty node selector term matches no objects. The requirements of them are ANDed. The TopologySelectorTerm type implements a subset of the NodeSelectorTerm.</summary> */
        public Core.V1.NodeSelectorTerm preference { get; set; }
        /** <summary>Weight associated with matching the corresponding nodeSelectorTerm, in the range 1-100.</summary> */
        public int weight { get; set; }
    }
}