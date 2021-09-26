using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Discovery.V1
{
    public partial class EndpointPort
    {
        /** <summary>The application protocol for this port. This field follows standard Kubernetes label syntax. Un-prefixed names are reserved for IANA standard service names (as per RFC-6335 and http://www.iana.org/assignments/service-names). Non-standard protocols should use prefixed names such as mycompany.com/my-custom-protocol.</summary> */
        public string appProtocol { get; set; }
        /** <summary>The name of this port. All ports in an EndpointSlice must have a unique name. If the EndpointSlice is dervied from a Kubernetes service, this corresponds to the Service.ports[].name. Name must either be an empty string or pass DNS_LABEL validation: &#42; must be no more than 63 characters long. &#42; must consist of lower case alphanumeric characters or '-'. &#42; must start and end with an alphanumeric character. Default is empty string.</summary> */
        public string name { get; set; }
        /** <summary>The port number of the endpoint. If this is not specified, ports are not restricted and must be interpreted in the context of the specific consumer.</summary> */
        public int port { get; set; }
        /** <summary>The IP protocol for this port. Must be UDP, TCP, or SCTP. Default is TCP.</summary> */
        public string protocol { get; set; }
    }
}