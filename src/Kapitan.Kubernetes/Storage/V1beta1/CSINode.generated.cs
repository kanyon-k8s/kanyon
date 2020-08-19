using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Storage.V1beta1
{
    public partial class CSINode : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "storage.k8s.io/v1beta1";
        [JsonProperty("kind")]
        public string Kind => "CSINode";

        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>CSINodeSpec holds information about the specification of all CSI drivers installed on a node</summary> */
        public Storage.V1beta1.CSINodeSpec spec { get; set; }
    }
}