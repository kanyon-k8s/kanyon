using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Autoscaling.V2beta2
{
    public partial class ObjectMetricStatus
    {
        /** <summary>MetricValueStatus holds the current value for a metric</summary> */
        public Autoscaling.V2beta2.MetricValueStatus current { get; set; }
        /** <summary>CrossVersionObjectReference contains enough information to let you identify the referred resource.</summary> */
        public Autoscaling.V2beta2.CrossVersionObjectReference describedObject { get; set; }
        /** <summary>MetricIdentifier defines the name and optionally selector for a metric</summary> */
        public Autoscaling.V2beta2.MetricIdentifier metric { get; set; }
    }
}