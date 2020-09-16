using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class NamespaceCondition
    {
        /** <summary>Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers.</summary> */
        public Core.V1.Time lastTransitionTime { get; set; }
        /** <summary></summary> */
        public string message { get; set; }
        /** <summary></summary> */
        public string reason { get; set; }
        /** <summary>Status of the condition, one of True, False, Unknown.</summary> */
        public string status { get; set; }
        /** <summary>Type of namespace controller condition.</summary> */
        public string type { get; set; }
    }
}