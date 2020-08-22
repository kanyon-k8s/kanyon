using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1
{
    public partial class IngressSpec
    {
        /** <summary>IngressBackend describes all endpoints for a given service and port.</summary> */
        public Networking.V1.IngressBackend defaultBackend { get; set; }
        /** <summary>IngressClassName is the name of the IngressClass cluster resource. The associated IngressClass defines which controller will implement the resource. This replaces the deprecated `kubernetes.io/ingress.class` annotation. For backwards compatibility, when that annotation is set, it must be given precedence over this field. The controller may emit a warning if the field and annotation have different values. Implementations of this API should ignore Ingresses without a class specified. An IngressClass resource may be marked as default, which can be used to set a default value for this field. For more information, refer to the IngressClass documentation.</summary> */
        public string ingressClassName { get; set; }
        /** <summary>A list of host rules used to configure the Ingress. If unspecified, or no rule matches, all traffic is sent to the default backend.</summary> */
        public IEnumerable<Networking.V1.IngressRule> rules { get; set; }
        /** <summary>TLS configuration. Currently the Ingress only supports a single TLS port, 443. If multiple members of this list specify different hosts, they will be multiplexed on the same port according to the hostname specified through the SNI TLS extension, if the ingress controller fulfilling the ingress supports SNI.</summary> */
        public IEnumerable<Networking.V1.IngressTLS> tls { get; set; }
    }
}