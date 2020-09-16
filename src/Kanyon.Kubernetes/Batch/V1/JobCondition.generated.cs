using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Batch.V1
{
    public partial class JobCondition
    {
        /** <summary>Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers.</summary> */
        public Core.V1.Time lastProbeTime { get; set; }
        /** <summary>Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers.</summary> */
        public Core.V1.Time lastTransitionTime { get; set; }
        /** <summary>Human readable message indicating details about last transition.</summary> */
        public string message { get; set; }
        /** <summary>(brief) reason for the condition's last transition.</summary> */
        public string reason { get; set; }
        /** <summary>Status of the condition, one of True, False, Unknown.</summary> */
        public string status { get; set; }
        /** <summary>Type of job condition, Complete or Failed.</summary> */
        public string type { get; set; }
    }
}