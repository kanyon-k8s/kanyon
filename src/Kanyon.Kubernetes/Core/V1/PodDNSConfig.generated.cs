using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class PodDNSConfig
    {
        /** <summary>A list of DNS name server IP addresses. This will be appended to the base nameservers generated from DNSPolicy. Duplicated nameservers will be removed.</summary> */
        public IEnumerable<string> nameservers { get; set; }
        /** <summary>A list of DNS resolver options. This will be merged with the base options generated from DNSPolicy. Duplicated entries will be removed. Resolution options given in Options will override those that appear in the base DNSPolicy.</summary> */
        public IEnumerable<Core.V1.PodDNSConfigOption> options { get; set; }
        /** <summary>A list of DNS search domains for host-name lookup. This will be appended to the base search paths generated from DNSPolicy. Duplicated search paths will be removed.</summary> */
        public IEnumerable<string> searches { get; set; }
    }
}