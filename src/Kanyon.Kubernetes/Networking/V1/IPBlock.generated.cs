using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Networking.V1
{
    public partial class IPBlock
    {
        /** <summary>CIDR is a string representing the IP Block Valid examples are "192.168.1.1/24" or "2001:db9::/64"</summary> */
        public string cidr { get; set; }
        /** <summary>Except is a slice of CIDRs that should not be included within an IP Block Valid examples are "192.168.1.1/24" or "2001:db9::/64" Except values will be rejected if they are outside the CIDR range</summary> */
        public IEnumerable<string> except { get; set; }
    }
}