using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class ServiceStatus
    {
        /** <summary>LoadBalancerStatus represents the status of a load-balancer.</summary> */
        public Core.V1.LoadBalancerStatus loadBalancer { get; set; }
    }
}