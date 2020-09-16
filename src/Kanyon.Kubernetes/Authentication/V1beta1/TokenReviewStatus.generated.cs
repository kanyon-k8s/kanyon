using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Authentication.V1beta1
{
    public partial class TokenReviewStatus
    {
        /** <summary>Audiences are audience identifiers chosen by the authenticator that are compatible with both the TokenReview and token. An identifier is any identifier in the intersection of the TokenReviewSpec audiences and the token's audiences. A client of the TokenReview API that sets the spec.audiences field should validate that a compatible audience identifier is returned in the status.audiences field to ensure that the TokenReview server is audience aware. If a TokenReview returns an empty status.audience field where status.authenticated is "true", the token is valid against the audience of the Kubernetes API server.</summary> */
        public IEnumerable<string> audiences { get; set; }
        /** <summary>Authenticated indicates that the token was associated with a known user.</summary> */
        public bool authenticated { get; set; }
        /** <summary>Error indicates that the token couldn't be checked</summary> */
        public string error { get; set; }
        /** <summary>UserInfo holds the information about the user needed to implement the user.Info interface.</summary> */
        public Authentication.V1beta1.UserInfo user { get; set; }
    }
}