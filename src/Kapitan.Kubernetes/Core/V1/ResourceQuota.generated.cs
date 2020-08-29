using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class ResourceQuota : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "v1";
        [JsonProperty("kind")]
        public string Kind => "ResourceQuota";

        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>ResourceQuotaSpec defines the desired hard limits to enforce for Quota.</summary> */
        public Core.V1.ResourceQuotaSpec spec { get; set; }
        /** <summary>ResourceQuotaStatus defines the enforced hard limits and observed use.</summary> */
        public Core.V1.ResourceQuotaStatus status { get; set; }
    }
}