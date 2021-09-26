using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Autoscaling.V2beta2
{
    public partial class ContainerResourceMetricSource
    {
        /** <summary>container is the name of the container in the pods of the scaling target</summary> */
        public string container { get; set; }
        /** <summary>name is the name of the resource in question.</summary> */
        public string name { get; set; }
        /** <summary>MetricTarget defines the target value, average value, or average utilization of a specific metric</summary> */
        public Autoscaling.V2beta2.MetricTarget target { get; set; }
    }
}