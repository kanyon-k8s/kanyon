using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Autoscaling.V2beta2
{
    public partial class PodsMetricStatus
    {
        /** <summary>MetricValueStatus holds the current value for a metric</summary> */
        public Autoscaling.V2beta2.MetricValueStatus current { get; set; }
        /** <summary>MetricIdentifier defines the name and optionally selector for a metric</summary> */
        public Autoscaling.V2beta2.MetricIdentifier metric { get; set; }
    }
}