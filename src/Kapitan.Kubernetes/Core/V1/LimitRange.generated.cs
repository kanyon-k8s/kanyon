using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class LimitRange : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "/v1";
        [JsonProperty("kind")]
        public string Kind => "LimitRange";

        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>LimitRangeSpec defines a min/max usage limit for resources that match on kind.</summary> */
        public Core.V1.LimitRangeSpec spec { get; set; }
    }
}