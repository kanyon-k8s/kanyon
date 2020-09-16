using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Core;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Extensions.V1beta1
{
    public partial class Ingress : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "extensions/v1beta1";
        [JsonProperty("kind")]
        public string Kind => "Ingress";

        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>IngressSpec describes the Ingress the user wishes to exist.</summary> */
        public Extensions.V1beta1.IngressSpec spec { get; set; }
        /** <summary>IngressStatus describe the current state of the Ingress.</summary> */
        public Extensions.V1beta1.IngressStatus status { get; set; }
    }
}