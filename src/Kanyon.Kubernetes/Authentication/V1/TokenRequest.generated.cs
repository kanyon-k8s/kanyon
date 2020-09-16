using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Core;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Authentication.V1
{
    public partial class TokenRequest : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "authentication.k8s.io/v1";
        [JsonProperty("kind")]
        public string Kind => "TokenRequest";

        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>TokenRequestSpec contains client provided parameters of a token request.</summary> */
        public Authentication.V1.TokenRequestSpec spec { get; set; }
        /** <summary>TokenRequestStatus is the result of a token request.</summary> */
        public Authentication.V1.TokenRequestStatus status { get; set; }
    }
}