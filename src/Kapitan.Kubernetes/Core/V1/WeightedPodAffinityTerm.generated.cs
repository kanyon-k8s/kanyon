using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class WeightedPodAffinityTerm
    {
        /** <summary>Defines a set of pods (namely those matching the labelSelector relative to the given namespace(s)) that this pod should be co-located (affinity) or not co-located (anti-affinity) with, where co-located is defined as running on a node whose value of the label with key <topologyKey> matches that of any node on which a pod of the set of pods is running</summary> */
        public Core.V1.PodAffinityTerm podAffinityTerm { get; set; }
        /** <summary>weight associated with matching the corresponding podAffinityTerm, in the range 1-100.</summary> */
        public int weight { get; set; }
    }
}