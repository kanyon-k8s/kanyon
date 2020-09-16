using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class EndpointSubset
    {
        /** <summary>IP addresses which offer the related ports that are marked as ready. These endpoints should be considered safe for load balancers and clients to utilize.</summary> */
        public IEnumerable<Core.V1.EndpointAddress> addresses { get; set; }
        /** <summary>IP addresses which offer the related ports but are not currently marked as ready because they have not yet finished starting, have recently failed a readiness check, or have recently failed a liveness check.</summary> */
        public IEnumerable<Core.V1.EndpointAddress> notReadyAddresses { get; set; }
        /** <summary>Port numbers available on the related IP addresses.</summary> */
        public IEnumerable<Core.V1.EndpointPort> ports { get; set; }
    }
}