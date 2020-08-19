using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class Node : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "/v1";
        [JsonProperty("kind")]
        public string Kind => "Node";

        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>NodeSpec describes the attributes that a node is created with.</summary> */
        public Core.V1.NodeSpec spec { get; set; }
        /** <summary>NodeStatus is information about the current status of a node.</summary> */
        public Core.V1.NodeStatus status { get; set; }
    }
}