using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class Binding : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "/v1";
        [JsonProperty("kind")]
        public string Kind => "Binding";

        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>ObjectReference contains enough information to let you inspect or modify the referred object.</summary> */
        public Core.V1.ObjectReference target { get; set; }
    }
}