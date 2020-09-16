using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Autoscaling.V1
{
    public partial class HorizontalPodAutoscalerSpec
    {
        /** <summary>upper limit for the number of pods that can be set by the autoscaler; cannot be smaller than MinReplicas.</summary> */
        public int maxReplicas { get; set; }
        /** <summary>minReplicas is the lower limit for the number of replicas to which the autoscaler can scale down.  It defaults to 1 pod.  minReplicas is allowed to be 0 if the alpha feature gate HPAScaleToZero is enabled and at least one Object or External metric is configured.  Scaling is active as long as at least one metric value is available.</summary> */
        public int minReplicas { get; set; }
        /** <summary>CrossVersionObjectReference contains enough information to let you identify the referred resource.</summary> */
        public Autoscaling.V1.CrossVersionObjectReference scaleTargetRef { get; set; }
        /** <summary>target average CPU utilization (represented as a percentage of requested CPU) over all the pods; if not specified the default autoscaling policy will be used.</summary> */
        public int targetCPUUtilizationPercentage { get; set; }
    }
}