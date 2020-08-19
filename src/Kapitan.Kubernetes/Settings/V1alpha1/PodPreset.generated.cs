using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Settings.V1alpha1
{
    public partial class PodPreset : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "settings.k8s.io/v1alpha1";
        [JsonProperty("kind")]
        public string Kind => "PodPreset";

        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>PodPresetSpec is a description of a pod preset.</summary> */
        public Settings.V1alpha1.PodPresetSpec spec { get; set; }
    }
}