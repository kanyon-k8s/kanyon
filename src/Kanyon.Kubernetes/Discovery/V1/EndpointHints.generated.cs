using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Discovery.V1
{
    public partial class EndpointHints
    {
        /** <summary>forZones indicates the zone(s) this endpoint should be consumed by to enable topology aware routing.</summary> */
        public IEnumerable<Discovery.V1.ForZone> forZones { get; set; }
    }
}