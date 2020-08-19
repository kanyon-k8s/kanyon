using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Autoscaling.V2beta2
{
    public partial class HorizontalPodAutoscalerBehavior
    {
        /** <summary>HPAScalingRules configures the scaling behavior for one direction. These Rules are applied after calculating DesiredReplicas from metrics for the HPA. They can limit the scaling velocity by specifying scaling policies. They can prevent flapping by specifying the stabilization window, so that the number of replicas is not set instantly, instead, the safest value from the stabilization window is chosen.</summary> */
        public Autoscaling.V2beta2.HPAScalingRules scaleDown { get; set; }
        /** <summary>HPAScalingRules configures the scaling behavior for one direction. These Rules are applied after calculating DesiredReplicas from metrics for the HPA. They can limit the scaling velocity by specifying scaling policies. They can prevent flapping by specifying the stabilization window, so that the number of replicas is not set instantly, instead, the safest value from the stabilization window is chosen.</summary> */
        public Autoscaling.V2beta2.HPAScalingRules scaleUp { get; set; }
    }
}