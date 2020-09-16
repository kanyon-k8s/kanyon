using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Policy.V1beta1
{
    public partial class PodSecurityPolicy : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "policy/v1beta1";
        [JsonProperty("kind")]
        public string Kind => "PodSecurityPolicy";

        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>PodSecurityPolicySpec defines the policy enforced.</summary> */
        public Policy.V1beta1.PodSecurityPolicySpec spec { get; set; }
    }
}