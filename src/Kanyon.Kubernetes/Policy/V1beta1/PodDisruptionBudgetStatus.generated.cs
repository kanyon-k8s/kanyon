using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Policy.V1beta1
{
    public partial class PodDisruptionBudgetStatus
    {
        /** <summary>current number of healthy pods</summary> */
        public int currentHealthy { get; set; }
        /** <summary>minimum desired number of healthy pods</summary> */
        public int desiredHealthy { get; set; }
        /** <summary>DisruptedPods contains information about pods whose eviction was processed by the API server eviction subresource handler but has not yet been observed by the PodDisruptionBudget controller. A pod will be in this map from the time when the API server processed the eviction request to the time when the pod is seen by PDB controller as having been marked for deletion (or after a timeout). The key in the map is the name of the pod and the value is the time when the API server processed the eviction request. If the deletion didn't occur and a pod is still there it will be removed from the list automatically by PodDisruptionBudget controller after some time. If everything goes smooth this map should be empty for the most of the time. Large number of entries in the map may indicate problems with pod deletions.</summary> */
        public object disruptedPods { get; set; }
        /** <summary>Number of pod disruptions that are currently allowed.</summary> */
        public int disruptionsAllowed { get; set; }
        /** <summary>total number of pods counted by this disruption budget</summary> */
        public int expectedPods { get; set; }
        /** <summary>Most recent generation observed when updating this PDB status. DisruptionsAllowed and other status information is valid only if observedGeneration equals to PDB's object generation.</summary> */
        public int observedGeneration { get; set; }
    }
}