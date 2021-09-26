using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Internal.V1alpha1
{
    public partial class StorageVersionCondition
    {
        /** <summary>Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers.</summary> */
        public Core.V1.Time lastTransitionTime { get; set; }
        /** <summary>A human readable message indicating details about the transition.</summary> */
        public string message { get; set; }
        /** <summary>If set, this represents the .metadata.generation that the condition was set based upon.</summary> */
        public int observedGeneration { get; set; }
        /** <summary>The reason for the condition's last transition.</summary> */
        public string reason { get; set; }
        /** <summary>Status of the condition, one of True, False, Unknown.</summary> */
        public string status { get; set; }
        /** <summary>Type of the condition.</summary> */
        public string type { get; set; }
    }
}