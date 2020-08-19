using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1
{
    public partial class Ingress : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "networking.k8s.io/v1";
        [JsonProperty("kind")]
        public string Kind => "Ingress";

        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>IngressSpec describes the Ingress the user wishes to exist.</summary> */
        public Networking.V1.IngressSpec spec { get; set; }
        /** <summary>IngressStatus describe the current state of the Ingress.</summary> */
        public Networking.V1.IngressStatus status { get; set; }
    }
}