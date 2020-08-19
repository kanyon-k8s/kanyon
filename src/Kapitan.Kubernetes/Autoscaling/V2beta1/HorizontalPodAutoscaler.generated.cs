using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Autoscaling.V2beta1
{
    public partial class HorizontalPodAutoscaler : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "autoscaling/v2beta1";
        [JsonProperty("kind")]
        public string Kind => "HorizontalPodAutoscaler";

        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>HorizontalPodAutoscalerSpec describes the desired functionality of the HorizontalPodAutoscaler.</summary> */
        public Autoscaling.V2beta1.HorizontalPodAutoscalerSpec spec { get; set; }
        /** <summary>HorizontalPodAutoscalerStatus describes the current status of a horizontal pod autoscaler.</summary> */
        public Autoscaling.V2beta1.HorizontalPodAutoscalerStatus status { get; set; }
    }
}