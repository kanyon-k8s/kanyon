using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Autoscaling.V2beta2
{
    public partial class HorizontalPodAutoscalerStatus
    {
        /** <summary>conditions is the set of conditions required for this autoscaler to scale its target, and indicates whether or not those conditions are met.</summary> */
        public IEnumerable<Autoscaling.V2beta2.HorizontalPodAutoscalerCondition> conditions { get; set; }
        /** <summary>currentMetrics is the last read state of the metrics used by this autoscaler.</summary> */
        public IEnumerable<Autoscaling.V2beta2.MetricStatus> currentMetrics { get; set; }
        /** <summary>currentReplicas is current number of replicas of pods managed by this autoscaler, as last seen by the autoscaler.</summary> */
        public int currentReplicas { get; set; }
        /** <summary>desiredReplicas is the desired number of replicas of pods managed by this autoscaler, as last calculated by the autoscaler.</summary> */
        public int desiredReplicas { get; set; }
        /** <summary>Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers.</summary> */
        public Core.V1.Time lastScaleTime { get; set; }
        /** <summary>observedGeneration is the most recent generation observed by this autoscaler.</summary> */
        public int observedGeneration { get; set; }
    }
}