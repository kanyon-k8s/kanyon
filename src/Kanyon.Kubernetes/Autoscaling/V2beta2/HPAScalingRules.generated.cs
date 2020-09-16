using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Autoscaling.V2beta2
{
    public partial class HPAScalingRules
    {
        /** <summary>policies is a list of potential scaling polices which can be used during scaling. At least one policy must be specified, otherwise the HPAScalingRules will be discarded as invalid</summary> */
        public IEnumerable<Autoscaling.V2beta2.HPAScalingPolicy> policies { get; set; }
        /** <summary>selectPolicy is used to specify which policy should be used. If not set, the default value MaxPolicySelect is used.</summary> */
        public string selectPolicy { get; set; }
        /** <summary>StabilizationWindowSeconds is the number of seconds for which past recommendations should be considered while scaling up or scaling down. StabilizationWindowSeconds must be greater than or equal to zero and less than or equal to 3600 (one hour). If not set, use the default values: - For scale up: 0 (i.e. no stabilization is done). - For scale down: 300 (i.e. the stabilization window is 300 seconds long).</summary> */
        public int stabilizationWindowSeconds { get; set; }
    }
}