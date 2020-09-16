using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Core;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Coordination.V1
{
    public partial class Lease : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "coordination.k8s.io/v1";
        [JsonProperty("kind")]
        public string Kind => "Lease";

        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>LeaseSpec is a specification of a Lease.</summary> */
        public Coordination.V1.LeaseSpec spec { get; set; }
    }
}