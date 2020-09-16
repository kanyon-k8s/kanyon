using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Certificates.V1beta1
{
    public partial class CertificateSigningRequestCondition
    {
        /** <summary>Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers.</summary> */
        public Core.V1.Time lastTransitionTime { get; set; }
        /** <summary>Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers.</summary> */
        public Core.V1.Time lastUpdateTime { get; set; }
        /** <summary>human readable message with details about the request state</summary> */
        public string message { get; set; }
        /** <summary>brief reason for the request state</summary> */
        public string reason { get; set; }
        /** <summary>Status of the condition, one of True, False, Unknown. Approved, Denied, and Failed conditions may not be "False" or "Unknown". Defaults to "True". If unset, should be treated as "True".</summary> */
        public string status { get; set; }
        /** <summary>type of the condition. Known conditions include "Approved", "Denied", and "Failed".</summary> */
        public string type { get; set; }
    }
}