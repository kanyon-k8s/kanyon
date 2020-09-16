using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Policy.V1beta1
{
    public partial class Eviction : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "policy/v1beta1";
        [JsonProperty("kind")]
        public string Kind => "Eviction";

        /** <summary>DeleteOptions may be provided when deleting an API object.</summary> */
        public Core.V1.DeleteOptions deleteOptions { get; set; }
        /** <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary> */
        public string kind { get; set; }
        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
    }
}