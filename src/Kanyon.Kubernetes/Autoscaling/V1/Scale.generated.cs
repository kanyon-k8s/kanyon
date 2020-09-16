using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Core;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Autoscaling.V1
{
    public partial class Scale : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "autoscaling/v1";
        [JsonProperty("kind")]
        public string Kind => "Scale";

        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>ScaleSpec describes the attributes of a scale subresource.</summary> */
        public Autoscaling.V1.ScaleSpec spec { get; set; }
        /** <summary>ScaleStatus represents the current status of a scale subresource.</summary> */
        public Autoscaling.V1.ScaleStatus status { get; set; }
    }
}