using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Core;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Storage.V1beta1
{
    public partial class CSIDriver : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "storage.k8s.io/v1beta1";
        [JsonProperty("kind")]
        public string Kind => "CSIDriver";

        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>CSIDriverSpec is the specification of a CSIDriver.</summary> */
        public Storage.V1beta1.CSIDriverSpec spec { get; set; }
    }
}