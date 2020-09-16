using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Core;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Networking.V1
{
    public partial class NetworkPolicy : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "networking.k8s.io/v1";
        [JsonProperty("kind")]
        public string Kind => "NetworkPolicy";

        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>NetworkPolicySpec provides the specification of a NetworkPolicy</summary> */
        public Networking.V1.NetworkPolicySpec spec { get; set; }
    }
}