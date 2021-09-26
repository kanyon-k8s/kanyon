using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Autoscaling.V2beta2
{
    public partial class MetricSpec
    {
        /** <summary>ContainerResourceMetricSource indicates how to scale on a resource metric known to Kubernetes, as specified in requests and limits, describing each pod in the current scale target (e.g. CPU or memory).  The values will be averaged together before being compared to the target.  Such metrics are built in to Kubernetes, and have special scaling options on top of those available to normal per-pod metrics using the "pods" source.  Only one "target" type should be set.</summary> */
        public Autoscaling.V2beta2.ContainerResourceMetricSource containerResource { get; set; }
        /** <summary>ExternalMetricSource indicates how to scale on a metric not associated with any Kubernetes object (for example length of queue in cloud messaging service, or QPS from loadbalancer running outside of cluster).</summary> */
        public Autoscaling.V2beta2.ExternalMetricSource external { get; set; }
        /** <summary>ObjectMetricSource indicates how to scale on a metric describing a kubernetes object (for example, hits-per-second on an Ingress object).</summary> */
        public Autoscaling.V2beta2.ObjectMetricSource @object { get; set; }
        /** <summary>PodsMetricSource indicates how to scale on a metric describing each pod in the current scale target (for example, transactions-processed-per-second). The values will be averaged together before being compared to the target value.</summary> */
        public Autoscaling.V2beta2.PodsMetricSource pods { get; set; }
        /** <summary>ResourceMetricSource indicates how to scale on a resource metric known to Kubernetes, as specified in requests and limits, describing each pod in the current scale target (e.g. CPU or memory).  The values will be averaged together before being compared to the target.  Such metrics are built in to Kubernetes, and have special scaling options on top of those available to normal per-pod metrics using the "pods" source.  Only one "target" type should be set.</summary> */
        public Autoscaling.V2beta2.ResourceMetricSource resource { get; set; }
        /** <summary>type is the type of metric source.  It should be one of "ContainerResource", "External", "Object", "Pods" or "Resource", each mapping to a matching field in the object. Note: "ContainerResource" type is available on when the feature-gate HPAContainerMetrics is enabled</summary> */
        public string type { get; set; }
    }
}