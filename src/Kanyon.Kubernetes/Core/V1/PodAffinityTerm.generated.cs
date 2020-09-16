using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class PodAffinityTerm
    {
        /** <summary>A label selector is a label query over a set of resources. The result of matchLabels and matchExpressions are ANDed. An empty label selector matches all objects. A null label selector matches no objects.</summary> */
        public Core.V1.LabelSelector labelSelector { get; set; }
        /** <summary>namespaces specifies which namespaces the labelSelector applies to (matches against); null or empty list means "this pod's namespace"</summary> */
        public IEnumerable<string> namespaces { get; set; }
        /** <summary>This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching the labelSelector in the specified namespaces, where co-located is defined as running on a node whose value of the label with key topologyKey matches that of any node on which any of the selected pods is running. Empty topologyKey is not allowed.</summary> */
        public string topologyKey { get; set; }
    }
}