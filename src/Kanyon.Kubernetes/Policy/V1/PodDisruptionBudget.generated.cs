using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Core;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Policy.V1
{
    public partial class PodDisruptionBudget : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "policy/v1";
        [JsonProperty("kind")]
        public string Kind => "PodDisruptionBudget";

        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>PodDisruptionBudgetSpec is a description of a PodDisruptionBudget.</summary> */
        public Policy.V1.PodDisruptionBudgetSpec spec { get; set; }
        /** <summary>PodDisruptionBudgetStatus represents information about the status of a PodDisruptionBudget. Status may trail the actual state of a system.</summary> */
        public Policy.V1.PodDisruptionBudgetStatus status { get; set; }
    }
}