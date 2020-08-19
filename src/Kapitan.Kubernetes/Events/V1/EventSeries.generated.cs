using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Events.V1
{
    public partial class EventSeries
    {
        /** <summary>count is the number of occurrences in this series up to the last heartbeat time.</summary> */
        public int count { get; set; }
        /** <summary>MicroTime is version of Time with microsecond level precision.</summary> */
        public Core.V1.MicroTime lastObservedTime { get; set; }
    }
}