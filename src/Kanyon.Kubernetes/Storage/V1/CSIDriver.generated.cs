using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Storage.V1
{
    public partial class CSIDriver : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "storage.k8s.io/v1";
        [JsonProperty("kind")]
        public string Kind => "CSIDriver";

        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>CSIDriverSpec is the specification of a CSIDriver.</summary> */
        public Storage.V1.CSIDriverSpec spec { get; set; }
    }
}