using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class LoadBalancerIngress
    {
        /** <summary>Hostname is set for load-balancer ingress points that are DNS based (typically AWS load-balancers)</summary> */
        public string hostname { get; set; }
        /** <summary>IP is set for load-balancer ingress points that are IP based (typically GCE or OpenStack load-balancers)</summary> */
        public string ip { get; set; }
    }
}