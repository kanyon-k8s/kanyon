using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class LoadBalancerStatus
    {
        /** <summary>Ingress is a list containing ingress points for the load-balancer. Traffic intended for the service should be sent to these ingress points.</summary> */
        public IEnumerable<Core.V1.LoadBalancerIngress> ingress { get; set; }
    }
}