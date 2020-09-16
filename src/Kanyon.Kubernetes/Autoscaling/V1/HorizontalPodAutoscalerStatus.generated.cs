using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Autoscaling.V1
{
    public partial class HorizontalPodAutoscalerStatus
    {
        /** <summary>current average CPU utilization over all pods, represented as a percentage of requested CPU, e.g. 70 means that an average pod is using now 70% of its requested CPU.</summary> */
        public int currentCPUUtilizationPercentage { get; set; }
        /** <summary>current number of replicas of pods managed by this autoscaler.</summary> */
        public int currentReplicas { get; set; }
        /** <summary>desired number of replicas of pods managed by this autoscaler.</summary> */
        public int desiredReplicas { get; set; }
        /** <summary>Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers.</summary> */
        public Core.V1.Time lastScaleTime { get; set; }
        /** <summary>most recent generation observed by this autoscaler.</summary> */
        public int observedGeneration { get; set; }
    }
}