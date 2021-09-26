using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class LoadBalancerIngress
    {
        /** <summary>Hostname is set for load-balancer ingress points that are DNS based (typically AWS load-balancers)</summary> */
        public string hostname { get; set; }
        /** <summary>IP is set for load-balancer ingress points that are IP based (typically GCE or OpenStack load-balancers)</summary> */
        public string ip { get; set; }
        /** <summary>Ports is a list of records of service ports If used, every port defined in the service should have an entry in it</summary> */
        public IEnumerable<Core.V1.PortStatus> ports { get; set; }
    }
}