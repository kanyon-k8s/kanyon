using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Autoscaling.V2beta1
{
    public partial class HorizontalPodAutoscalerSpec
    {
        /** <summary>maxReplicas is the upper limit for the number of replicas to which the autoscaler can scale up. It cannot be less that minReplicas.</summary> */
        public int maxReplicas { get; set; }
        /** <summary>metrics contains the specifications for which to use to calculate the desired replica count (the maximum replica count across all metrics will be used).  The desired replica count is calculated multiplying the ratio between the target value and the current value by the current number of pods.  Ergo, metrics used must decrease as the pod count is increased, and vice-versa.  See the individual metric source types for more information about how each type of metric must respond.</summary> */
        public IEnumerable<Autoscaling.V2beta1.MetricSpec> metrics { get; set; }
        /** <summary>minReplicas is the lower limit for the number of replicas to which the autoscaler can scale down.  It defaults to 1 pod.  minReplicas is allowed to be 0 if the alpha feature gate HPAScaleToZero is enabled and at least one Object or External metric is configured.  Scaling is active as long as at least one metric value is available.</summary> */
        public int minReplicas { get; set; }
        /** <summary>CrossVersionObjectReference contains enough information to let you identify the referred resource.</summary> */
        public Autoscaling.V2beta1.CrossVersionObjectReference scaleTargetRef { get; set; }
    }
}