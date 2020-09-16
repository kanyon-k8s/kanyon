using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Autoscaling.V2beta1
{
    public partial class HorizontalPodAutoscalerCondition
    {
        /** <summary>Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers.</summary> */
        public Core.V1.Time lastTransitionTime { get; set; }
        /** <summary>message is a human-readable explanation containing details about the transition</summary> */
        public string message { get; set; }
        /** <summary>reason is the reason for the condition's last transition.</summary> */
        public string reason { get; set; }
        /** <summary>status is the status of the condition (True, False, Unknown)</summary> */
        public string status { get; set; }
        /** <summary>type describes the current condition</summary> */
        public string type { get; set; }
    }
}