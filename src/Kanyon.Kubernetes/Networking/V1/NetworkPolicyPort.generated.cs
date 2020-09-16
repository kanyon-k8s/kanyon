using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1
{
    public partial class NetworkPolicyPort
    {
        /** <summary>IntOrString is a type that can hold an int32 or a string.  When used in JSON or YAML marshalling and unmarshalling, it produces or consumes the inner type.  This allows you to have, for example, a JSON field that can accept a name or number.</summary> */
        public IntOrString port { get; set; }
        /** <summary>The protocol (TCP, UDP, or SCTP) which traffic must match. If not specified, this field defaults to TCP.</summary> */
        public string protocol { get; set; }
    }
}