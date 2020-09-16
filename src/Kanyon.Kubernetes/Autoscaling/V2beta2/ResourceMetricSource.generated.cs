using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Autoscaling.V2beta2
{
    public partial class ResourceMetricSource
    {
        /** <summary>name is the name of the resource in question.</summary> */
        public string name { get; set; }
        /** <summary>MetricTarget defines the target value, average value, or average utilization of a specific metric</summary> */
        public Autoscaling.V2beta2.MetricTarget target { get; set; }
    }
}