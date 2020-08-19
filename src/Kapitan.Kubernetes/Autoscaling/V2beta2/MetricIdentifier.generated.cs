using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Autoscaling.V2beta2
{
    public partial class MetricIdentifier
    {
        /** <summary>name is the name of the given metric</summary> */
        public string name { get; set; }
        /** <summary>A label selector is a label query over a set of resources. The result of matchLabels and matchExpressions are ANDed. An empty label selector matches all objects. A null label selector matches no objects.</summary> */
        public Core.V1.LabelSelector selector { get; set; }
    }
}