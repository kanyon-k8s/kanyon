using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Autoscaling.V2beta2
{
    public partial class HPAScalingPolicy
    {
        /** <summary>PeriodSeconds specifies the window of time for which the policy should hold true. PeriodSeconds must be greater than zero and less than or equal to 1800 (30 min).</summary> */
        public int periodSeconds { get; set; }
        /** <summary>Type is used to specify the scaling policy.</summary> */
        public string type { get; set; }
        /** <summary>Value contains the amount of change which is permitted by the policy. It must be greater than zero</summary> */
        public int value { get; set; }
    }
}