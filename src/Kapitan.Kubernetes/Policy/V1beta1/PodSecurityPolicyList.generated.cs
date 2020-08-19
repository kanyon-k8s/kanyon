using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Policy.V1beta1
{
    public partial class PodSecurityPolicyList : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "policy/v1beta1";
        [JsonProperty("kind")]
        public string Kind => "PodSecurityPolicyList";

        /** <summary>items is a list of schema objects.</summary> */
        public List<Policy.V1beta1.PodSecurityPolicy> items { get; set; }
        /** <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary> */
        public string kind { get; set; }
        /** <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary> */
        public Core.V1.ListMeta metadata { get; set; }
    }
}