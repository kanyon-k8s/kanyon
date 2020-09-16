using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Autoscaling.V2beta2
{
    public partial class ResourceMetricStatus
    {
        /** <summary>MetricValueStatus holds the current value for a metric</summary> */
        public Autoscaling.V2beta2.MetricValueStatus current { get; set; }
        /** <summary>Name is the name of the resource in question.</summary> */
        public string name { get; set; }
    }
}