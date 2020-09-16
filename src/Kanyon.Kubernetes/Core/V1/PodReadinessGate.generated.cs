using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class PodReadinessGate
    {
        /** <summary>ConditionType refers to a condition in the pod's condition list with matching type.</summary> */
        public string conditionType { get; set; }
    }
}