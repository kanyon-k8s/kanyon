using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Authentication.V1
{
    public partial class TokenRequestStatus
    {
        /** <summary>Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers.</summary> */
        public Core.V1.Time expirationTimestamp { get; set; }
        /** <summary>Token is the opaque bearer token.</summary> */
        public string token { get; set; }
    }
}