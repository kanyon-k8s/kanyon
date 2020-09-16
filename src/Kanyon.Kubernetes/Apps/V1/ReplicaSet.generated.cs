using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Apps.V1
{
    public partial class ReplicaSet : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "apps/v1";
        [JsonProperty("kind")]
        public string Kind => "ReplicaSet";

        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>ReplicaSetSpec is the specification of a ReplicaSet.</summary> */
        public Apps.V1.ReplicaSetSpec spec { get; set; }
        /** <summary>ReplicaSetStatus represents the current status of a ReplicaSet.</summary> */
        public Apps.V1.ReplicaSetStatus status { get; set; }
    }
}