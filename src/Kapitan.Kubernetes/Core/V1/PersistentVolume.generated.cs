using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class PersistentVolume : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "/v1";
        [JsonProperty("kind")]
        public string Kind => "PersistentVolume";

        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>PersistentVolumeSpec is the specification of a persistent volume.</summary> */
        public Core.V1.PersistentVolumeSpec spec { get; set; }
        /** <summary>PersistentVolumeStatus is the current status of a persistent volume.</summary> */
        public Core.V1.PersistentVolumeStatus status { get; set; }
    }
}