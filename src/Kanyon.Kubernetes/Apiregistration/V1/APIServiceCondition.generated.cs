using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Apiregistration.V1
{
    public partial class APIServiceCondition
    {
        /** <summary>Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers.</summary> */
        public Core.V1.Time lastTransitionTime { get; set; }
        /** <summary>Human-readable message indicating details about last transition.</summary> */
        public string message { get; set; }
        /** <summary>Unique, one-word, CamelCase reason for the condition's last transition.</summary> */
        public string reason { get; set; }
        /** <summary>Status is the status of the condition. Can be True, False, Unknown.</summary> */
        public string status { get; set; }
        /** <summary>Type is the type of the condition.</summary> */
        public string type { get; set; }
    }
}