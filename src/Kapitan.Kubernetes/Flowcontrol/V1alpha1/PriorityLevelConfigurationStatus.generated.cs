using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Flowcontrol.V1alpha1
{
    public partial class PriorityLevelConfigurationStatus
    {
        /** <summary>`conditions` is the current state of "request-priority".</summary> */
        public List<Flowcontrol.V1alpha1.PriorityLevelConfigurationCondition> conditions { get; set; }
    }
}