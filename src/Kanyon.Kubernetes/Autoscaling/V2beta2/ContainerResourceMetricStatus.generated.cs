using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Autoscaling.V2beta2
{
    public partial class ContainerResourceMetricStatus
    {
        /** <summary>Container is the name of the container in the pods of the scaling target</summary> */
        public string container { get; set; }
        /** <summary>MetricValueStatus holds the current value for a metric</summary> */
        public Autoscaling.V2beta2.MetricValueStatus current { get; set; }
        /** <summary>Name is the name of the resource in question.</summary> */
        public string name { get; set; }
    }
}