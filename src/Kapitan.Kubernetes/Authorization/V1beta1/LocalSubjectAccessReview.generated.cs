using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Authorization.V1beta1
{
    public partial class LocalSubjectAccessReview : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "authorization.k8s.io/v1beta1";
        [JsonProperty("kind")]
        public string Kind => "LocalSubjectAccessReview";

        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>SubjectAccessReviewSpec is a description of the access request.  Exactly one of ResourceAuthorizationAttributes and NonResourceAuthorizationAttributes must be set</summary> */
        public Authorization.V1beta1.SubjectAccessReviewSpec spec { get; set; }
        /** <summary>SubjectAccessReviewStatus</summary> */
        public Authorization.V1beta1.SubjectAccessReviewStatus status { get; set; }
    }
}