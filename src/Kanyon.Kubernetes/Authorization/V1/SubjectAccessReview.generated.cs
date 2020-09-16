using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Core;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Authorization.V1
{
    public partial class SubjectAccessReview : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "authorization.k8s.io/v1";
        [JsonProperty("kind")]
        public string Kind => "SubjectAccessReview";

        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>SubjectAccessReviewSpec is a description of the access request.  Exactly one of ResourceAuthorizationAttributes and NonResourceAuthorizationAttributes must be set</summary> */
        public Authorization.V1.SubjectAccessReviewSpec spec { get; set; }
        /** <summary>SubjectAccessReviewStatus</summary> */
        public Authorization.V1.SubjectAccessReviewStatus status { get; set; }
    }
}