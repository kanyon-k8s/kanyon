using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class Namespace : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "v1";
        [JsonProperty("kind")]
        public string Kind => "Namespace";

        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>NamespaceSpec describes the attributes on a Namespace.</summary> */
        public Core.V1.NamespaceSpec spec { get; set; }
        /** <summary>NamespaceStatus is information about the current status of a Namespace.</summary> */
        public Core.V1.NamespaceStatus status { get; set; }
    }
}