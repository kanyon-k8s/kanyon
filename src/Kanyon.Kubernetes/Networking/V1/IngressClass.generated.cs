using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1
{
    public partial class IngressClass : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "networking.k8s.io/v1";
        [JsonProperty("kind")]
        public string Kind => "IngressClass";

        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>IngressClassSpec provides information about the class of an Ingress.</summary> */
        public Networking.V1.IngressClassSpec spec { get; set; }
    }
}