using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class PersistentVolumeClaim : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "/v1";
        [JsonProperty("kind")]
        public string Kind => "PersistentVolumeClaim";

        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>PersistentVolumeClaimSpec describes the common attributes of storage devices and allows a Source for provider-specific attributes</summary> */
        public Core.V1.PersistentVolumeClaimSpec spec { get; set; }
        /** <summary>PersistentVolumeClaimStatus is the current status of a persistent volume claim.</summary> */
        public Core.V1.PersistentVolumeClaimStatus status { get; set; }
    }
}