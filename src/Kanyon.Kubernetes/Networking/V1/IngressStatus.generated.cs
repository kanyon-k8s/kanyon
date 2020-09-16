using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Networking.V1
{
    public partial class IngressStatus
    {
        /** <summary>LoadBalancerStatus represents the status of a load-balancer.</summary> */
        public Core.V1.LoadBalancerStatus loadBalancer { get; set; }
    }
}