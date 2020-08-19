using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class ServicePort
    {
        /** <summary>The application protocol for this port. This field follows standard Kubernetes label syntax. Un-prefixed names are reserved for IANA standard service names (as per RFC-6335 and http://www.iana.org/assignments/service-names). Non-standard protocols should use prefixed names such as mycompany.com/my-custom-protocol. This is a beta field that is guarded by the ServiceAppProtocol feature gate and enabled by default.</summary> */
        public string appProtocol { get; set; }
        /** <summary>The name of this port within the service. This must be a DNS_LABEL. All ports within a ServiceSpec must have unique names. When considering the endpoints for a Service, this must match the 'name' field in the EndpointPort. Optional if only one ServicePort is defined on this service.</summary> */
        public string name { get; set; }
        /** <summary>The port on each node on which this service is exposed when type=NodePort or LoadBalancer. Usually assigned by the system. If specified, it will be allocated to the service if unused or else creation of the service will fail. Default is to auto-allocate a port if the ServiceType of this Service requires one. More info: https://kubernetes.io/docs/concepts/services-networking/service/#type-nodeport</summary> */
        public int nodePort { get; set; }
        /** <summary>The port that will be exposed by this service.</summary> */
        public int port { get; set; }
        /** <summary>The IP protocol for this port. Supports "TCP", "UDP", and "SCTP". Default is TCP.</summary> */
        public string protocol { get; set; }
        /** <summary>IntOrString is a type that can hold an int32 or a string.  When used in JSON or YAML marshalling and unmarshalling, it produces or consumes the inner type.  This allows you to have, for example, a JSON field that can accept a name or number.</summary> */
        public IntOrString targetPort { get; set; }
    }
}