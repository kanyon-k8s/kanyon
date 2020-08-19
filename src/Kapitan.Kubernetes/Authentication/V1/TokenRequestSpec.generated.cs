using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Authentication.V1
{
    public partial class TokenRequestSpec
    {
        /** <summary>Audiences are the intendend audiences of the token. A recipient of a token must identitfy themself with an identifier in the list of audiences of the token, and otherwise should reject the token. A token issued for multiple audiences may be used to authenticate against any of the audiences listed but implies a high degree of trust between the target audiences.</summary> */
        public List<string> audiences { get; set; }
        /** <summary>BoundObjectReference is a reference to an object that a token is bound to.</summary> */
        public Authentication.V1.BoundObjectReference boundObjectRef { get; set; }
        /** <summary>ExpirationSeconds is the requested duration of validity of the request. The token issuer may return a token with a different validity duration so a client needs to check the 'expiration' field in a response.</summary> */
        public int expirationSeconds { get; set; }
    }
}