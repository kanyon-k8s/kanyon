using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Apps.V1
{
    public partial class DaemonSetSpec
    {
        /** <summary>The minimum number of seconds for which a newly created DaemonSet pod should be ready without any of its container crashing, for it to be considered available. Defaults to 0 (pod will be considered available as soon as it is ready).</summary> */
        public int minReadySeconds { get; set; }
        /** <summary>The number of old history to retain to allow rollback. This is a pointer to distinguish between explicit zero and not specified. Defaults to 10.</summary> */
        public int revisionHistoryLimit { get; set; }
        /** <summary>A label selector is a label query over a set of resources. The result of matchLabels and matchExpressions are ANDed. An empty label selector matches all objects. A null label selector matches no objects.</summary> */
        public Core.V1.LabelSelector selector { get; set; }
        /** <summary>PodTemplateSpec describes the data a pod should have when created from a template</summary> */
        public Core.V1.PodTemplateSpec template { get; set; }
        /** <summary>DaemonSetUpdateStrategy is a struct used to control the update strategy for a DaemonSet.</summary> */
        public Apps.V1.DaemonSetUpdateStrategy updateStrategy { get; set; }
    }
}