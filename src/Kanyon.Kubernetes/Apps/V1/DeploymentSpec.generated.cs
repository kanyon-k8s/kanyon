using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Apps.V1
{
    public partial class DeploymentSpec
    {
        /** <summary>Minimum number of seconds for which a newly created pod should be ready without any of its container crashing, for it to be considered available. Defaults to 0 (pod will be considered available as soon as it is ready)</summary> */
        public int minReadySeconds { get; set; }
        /** <summary>Indicates that the deployment is paused.</summary> */
        public bool paused { get; set; }
        /** <summary>The maximum time in seconds for a deployment to make progress before it is considered to be failed. The deployment controller will continue to process failed deployments and a condition with a ProgressDeadlineExceeded reason will be surfaced in the deployment status. Note that progress will not be estimated during the time a deployment is paused. Defaults to 600s.</summary> */
        public int progressDeadlineSeconds { get; set; }
        /** <summary>Number of desired pods. This is a pointer to distinguish between explicit zero and not specified. Defaults to 1.</summary> */
        public int replicas { get; set; }
        /** <summary>The number of old ReplicaSets to retain to allow rollback. This is a pointer to distinguish between explicit zero and not specified. Defaults to 10.</summary> */
        public int revisionHistoryLimit { get; set; }
        /** <summary>A label selector is a label query over a set of resources. The result of matchLabels and matchExpressions are ANDed. An empty label selector matches all objects. A null label selector matches no objects.</summary> */
        public Core.V1.LabelSelector selector { get; set; }
        /** <summary>DeploymentStrategy describes how to replace existing pods with new ones.</summary> */
        public Apps.V1.DeploymentStrategy strategy { get; set; }
        /** <summary>PodTemplateSpec describes the data a pod should have when created from a template</summary> */
        public Core.V1.PodTemplateSpec template { get; set; }
    }
}