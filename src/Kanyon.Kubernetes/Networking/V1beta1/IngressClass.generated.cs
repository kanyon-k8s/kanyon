using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Core;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Networking.V1beta1
{
    public partial class IngressClass : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "networking.k8s.io/v1beta1";
        [JsonProperty("kind")]
        public string Kind => "IngressClass";

        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>IngressClassSpec provides information about the class of an Ingress.</summary> */
        public Networking.V1beta1.IngressClassSpec spec { get; set; }
    }
}