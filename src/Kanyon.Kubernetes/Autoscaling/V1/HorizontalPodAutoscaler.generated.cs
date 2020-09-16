using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Core;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Autoscaling.V1
{
    public partial class HorizontalPodAutoscaler : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "autoscaling/v1";
        [JsonProperty("kind")]
        public string Kind => "HorizontalPodAutoscaler";

        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>specification of a horizontal pod autoscaler.</summary> */
        public Autoscaling.V1.HorizontalPodAutoscalerSpec spec { get; set; }
        /** <summary>current status of a horizontal pod autoscaler</summary> */
        public Autoscaling.V1.HorizontalPodAutoscalerStatus status { get; set; }
    }
}