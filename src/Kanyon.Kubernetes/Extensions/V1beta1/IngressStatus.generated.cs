using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Extensions.V1beta1
{
    public partial class IngressStatus
    {
        /** <summary>LoadBalancerStatus represents the status of a load-balancer.</summary> */
        public Core.V1.LoadBalancerStatus loadBalancer { get; set; }
    }
}