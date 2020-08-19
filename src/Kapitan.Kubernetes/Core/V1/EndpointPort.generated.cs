using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class EndpointPort
    {
        /** <summary>The application protocol for this port. This field follows standard Kubernetes label syntax. Un-prefixed names are reserved for IANA standard service names (as per RFC-6335 and http://www.iana.org/assignments/service-names). Non-standard protocols should use prefixed names such as mycompany.com/my-custom-protocol. This is a beta field that is guarded by the ServiceAppProtocol feature gate and enabled by default.</summary> */
        public string appProtocol { get; set; }
        /** <summary>The name of this port.  This must match the 'name' field in the corresponding ServicePort. Must be a DNS_LABEL. Optional only if one port is defined.</summary> */
        public string name { get; set; }
        /** <summary>The port number of the endpoint.</summary> */
        public int port { get; set; }
        /** <summary>The IP protocol for this port. Must be UDP, TCP, or SCTP. Default is TCP.</summary> */
        public string protocol { get; set; }
    }
}