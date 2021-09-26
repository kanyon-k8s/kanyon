using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class Condition
    {
        /** <summary>Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers.</summary> */
        public Core.V1.Time lastTransitionTime { get; set; }
        /** <summary>message is a human readable message indicating details about the transition. This may be an empty string.</summary> */
        public string message { get; set; }
        /** <summary>observedGeneration represents the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date with respect to the current state of the instance.</summary> */
        public int observedGeneration { get; set; }
        /** <summary>reason contains a programmatic identifier indicating the reason for the condition's last transition. Producers of specific condition types may define expected values and meanings for this field, and whether the values are considered a guaranteed API. The value should be a CamelCase string. This field may not be empty.</summary> */
        public string reason { get; set; }
        /** <summary>status of the condition, one of True, False, Unknown.</summary> */
        public string status { get; set; }
        /** <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary> */
        public string type { get; set; }
    }
}