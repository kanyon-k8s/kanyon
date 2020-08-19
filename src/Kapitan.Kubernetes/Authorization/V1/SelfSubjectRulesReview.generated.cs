using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Authorization.V1
{
    public partial class SelfSubjectRulesReview : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "authorization.k8s.io/v1";
        [JsonProperty("kind")]
        public string Kind => "SelfSubjectRulesReview";

        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary></summary> */
        public Authorization.V1.SelfSubjectRulesReviewSpec spec { get; set; }
        /** <summary>SubjectRulesReviewStatus contains the result of a rules check. This check can be incomplete depending on the set of authorizers the server is configured with and any errors experienced during evaluation. Because authorization rules are additive, if a rule appears in a list it's safe to assume the subject has that permission, even if that list is incomplete.</summary> */
        public Authorization.V1.SubjectRulesReviewStatus status { get; set; }
    }
}