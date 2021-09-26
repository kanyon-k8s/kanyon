using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Discovery.V1beta1
{
    public partial class EndpointHints
    {
        /** <summary>forZones indicates the zone(s) this endpoint should be consumed by to enable topology aware routing. May contain a maximum of 8 entries.</summary> */
        public IEnumerable<Discovery.V1beta1.ForZone> forZones { get; set; }
    }
}