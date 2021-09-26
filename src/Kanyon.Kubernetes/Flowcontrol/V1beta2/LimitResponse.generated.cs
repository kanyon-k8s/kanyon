using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Flowcontrol.V1beta2
{
    public partial class LimitResponse
    {
        /** <summary>QueuingConfiguration holds the configuration parameters for queuing</summary> */
        public Flowcontrol.V1beta2.QueuingConfiguration queuing { get; set; }
        /** <summary>`type` is "Queue" or "Reject". "Queue" means that requests that can not be executed upon arrival are held in a queue until they can be executed or a queuing limit is reached. "Reject" means that requests that can not be executed upon arrival are rejected. Required.</summary> */
        public string type { get; set; }
    }
}