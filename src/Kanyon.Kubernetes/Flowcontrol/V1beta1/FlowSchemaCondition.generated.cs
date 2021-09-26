using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Flowcontrol.V1beta1
{
    public partial class FlowSchemaCondition
    {
        /** <summary>Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers.</summary> */
        public Core.V1.Time lastTransitionTime { get; set; }
        /** <summary>`message` is a human-readable message indicating details about last transition.</summary> */
        public string message { get; set; }
        /** <summary>`reason` is a unique, one-word, CamelCase reason for the condition's last transition.</summary> */
        public string reason { get; set; }
        /** <summary>`status` is the status of the condition. Can be True, False, Unknown. Required.</summary> */
        public string status { get; set; }
        /** <summary>`type` is the type of the condition. Required.</summary> */
        public string type { get; set; }
    }
}