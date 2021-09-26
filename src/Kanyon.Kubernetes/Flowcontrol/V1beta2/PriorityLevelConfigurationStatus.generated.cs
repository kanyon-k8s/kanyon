using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Flowcontrol.V1beta2
{
    public partial class PriorityLevelConfigurationStatus
    {
        /** <summary>`conditions` is the current state of "request-priority".</summary> */
        public IEnumerable<Flowcontrol.V1beta2.PriorityLevelConfigurationCondition> conditions { get; set; }
    }
}