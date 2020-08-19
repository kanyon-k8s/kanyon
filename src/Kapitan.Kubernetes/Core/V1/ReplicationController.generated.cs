using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class ReplicationController : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "/v1";
        [JsonProperty("kind")]
        public string Kind => "ReplicationController";

        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>ReplicationControllerSpec is the specification of a replication controller.</summary> */
        public Core.V1.ReplicationControllerSpec spec { get; set; }
        /** <summary>ReplicationControllerStatus represents the current status of a replication controller.</summary> */
        public Core.V1.ReplicationControllerStatus status { get; set; }
    }
}