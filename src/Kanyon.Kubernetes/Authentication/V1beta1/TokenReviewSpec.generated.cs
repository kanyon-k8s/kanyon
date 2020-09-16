using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Authentication.V1beta1
{
    public partial class TokenReviewSpec
    {
        /** <summary>Audiences is a list of the identifiers that the resource server presented with the token identifies as. Audience-aware token authenticators will verify that the token was intended for at least one of the audiences in this list. If no audiences are provided, the audience will default to the audience of the Kubernetes apiserver.</summary> */
        public IEnumerable<string> audiences { get; set; }
        /** <summary>Token is the opaque bearer token.</summary> */
        public string token { get; set; }
    }
}