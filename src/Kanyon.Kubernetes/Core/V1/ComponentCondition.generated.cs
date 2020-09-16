using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class ComponentCondition
    {
        /** <summary>Condition error code for a component. For example, a health check error code.</summary> */
        public string error { get; set; }
        /** <summary>Message about the condition for a component. For example, information about a health check.</summary> */
        public string message { get; set; }
        /** <summary>Status of the condition for a component. Valid values for "Healthy": "True", "False", or "Unknown".</summary> */
        public string status { get; set; }
        /** <summary>Type of condition for a component. Valid value: "Healthy"</summary> */
        public string type { get; set; }
    }
}