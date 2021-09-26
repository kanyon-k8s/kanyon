using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Storage.V1
{
    public partial class TokenRequest
    {
        /** <summary>Audience is the intended audience of the token in "TokenRequestSpec". It will default to the audiences of kube apiserver.</summary> */
        public string audience { get; set; }
        /** <summary>ExpirationSeconds is the duration of validity of the token in "TokenRequestSpec". It has the same default value of "ExpirationSeconds" in "TokenRequestSpec".</summary> */
        public int expirationSeconds { get; set; }
    }
}