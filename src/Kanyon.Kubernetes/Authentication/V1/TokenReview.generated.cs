using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Authentication.V1
{
    public partial class TokenReview : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "authentication.k8s.io/v1";
        [JsonProperty("kind")]
        public string Kind => "TokenReview";

        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>TokenReviewSpec is a description of the token authentication request.</summary> */
        public Authentication.V1.TokenReviewSpec spec { get; set; }
        /** <summary>TokenReviewStatus is the result of the token authentication request.</summary> */
        public Authentication.V1.TokenReviewStatus status { get; set; }
    }
}