using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Autoscaling.V2beta2
{
    public partial class MetricStatus
    {
        /** <summary>ContainerResourceMetricStatus indicates the current value of a resource metric known to Kubernetes, as specified in requests and limits, describing a single container in each pod in the current scale target (e.g. CPU or memory).  Such metrics are built in to Kubernetes, and have special scaling options on top of those available to normal per-pod metrics using the "pods" source.</summary> */
        public Autoscaling.V2beta2.ContainerResourceMetricStatus containerResource { get; set; }
        /** <summary>ExternalMetricStatus indicates the current value of a global metric not associated with any Kubernetes object.</summary> */
        public Autoscaling.V2beta2.ExternalMetricStatus external { get; set; }
        /** <summary>ObjectMetricStatus indicates the current value of a metric describing a kubernetes object (for example, hits-per-second on an Ingress object).</summary> */
        public Autoscaling.V2beta2.ObjectMetricStatus @object { get; set; }
        /** <summary>PodsMetricStatus indicates the current value of a metric describing each pod in the current scale target (for example, transactions-processed-per-second).</summary> */
        public Autoscaling.V2beta2.PodsMetricStatus pods { get; set; }
        /** <summary>ResourceMetricStatus indicates the current value of a resource metric known to Kubernetes, as specified in requests and limits, describing each pod in the current scale target (e.g. CPU or memory).  Such metrics are built in to Kubernetes, and have special scaling options on top of those available to normal per-pod metrics using the "pods" source.</summary> */
        public Autoscaling.V2beta2.ResourceMetricStatus resource { get; set; }
        /** <summary>type is the type of metric source.  It will be one of "ContainerResource", "External", "Object", "Pods" or "Resource", each corresponds to a matching field in the object. Note: "ContainerResource" type is available on when the feature-gate HPAContainerMetrics is enabled</summary> */
        public string type { get; set; }
    }
}