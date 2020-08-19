using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1
{
    public partial class NetworkPolicyEgressRule
    {
        /** <summary>List of destination ports for outgoing traffic. Each item in this list is combined using a logical OR. If this field is empty or missing, this rule matches all ports (traffic not restricted by port). If this field is present and contains at least one item, then this rule allows traffic only if the traffic matches at least one port in the list.</summary> */
        public List<Networking.V1.NetworkPolicyPort> ports { get; set; }
        /** <summary>List of destinations for outgoing traffic of pods selected for this rule. Items in this list are combined using a logical OR operation. If this field is empty or missing, this rule matches all destinations (traffic not restricted by destination). If this field is present and contains at least one item, this rule allows traffic only if the traffic matches at least one item in the to list.</summary> */
        public List<Networking.V1.NetworkPolicyPeer> to { get; set; }
    }
}