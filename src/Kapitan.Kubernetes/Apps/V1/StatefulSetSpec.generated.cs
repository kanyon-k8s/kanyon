using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Apps.V1
{
    public partial class StatefulSetSpec
    {
        /** <summary>podManagementPolicy controls how pods are created during initial scale up, when replacing pods on nodes, or when scaling down. The default policy is `OrderedReady`, where pods are created in increasing order (pod-0, then pod-1, etc) and the controller will wait until each pod is ready before continuing. When scaling down, the pods are removed in the opposite order. The alternative policy is `Parallel` which will create pods in parallel to match the desired scale without waiting, and on scale down will delete all pods at once.</summary> */
        public string podManagementPolicy { get; set; }
        /** <summary>replicas is the desired number of replicas of the given Template. These are replicas in the sense that they are instantiations of the same Template, but individual replicas also have a consistent identity. If unspecified, defaults to 1.</summary> */
        public int replicas { get; set; }
        /** <summary>revisionHistoryLimit is the maximum number of revisions that will be maintained in the StatefulSet's revision history. The revision history consists of all revisions not represented by a currently applied StatefulSetSpec version. The default value is 10.</summary> */
        public int revisionHistoryLimit { get; set; }
        /** <summary>A label selector is a label query over a set of resources. The result of matchLabels and matchExpressions are ANDed. An empty label selector matches all objects. A null label selector matches no objects.</summary> */
        public Core.V1.LabelSelector selector { get; set; }
        /** <summary>serviceName is the name of the service that governs this StatefulSet. This service must exist before the StatefulSet, and is responsible for the network identity of the set. Pods get DNS/hostnames that follow the pattern: pod-specific-string.serviceName.default.svc.cluster.local where "pod-specific-string" is managed by the StatefulSet controller.</summary> */
        public string serviceName { get; set; }
        /** <summary>PodTemplateSpec describes the data a pod should have when created from a template</summary> */
        public Core.V1.PodTemplateSpec template { get; set; }
        /** <summary>StatefulSetUpdateStrategy indicates the strategy that the StatefulSet controller will use to perform updates. It includes any additional parameters necessary to perform the update for the indicated strategy.</summary> */
        public Apps.V1.StatefulSetUpdateStrategy updateStrategy { get; set; }
        /** <summary>volumeClaimTemplates is a list of claims that pods are allowed to reference. The StatefulSet controller is responsible for mapping network identities to claims in a way that maintains the identity of a pod. Every claim in this list must have at least one matching (by name) volumeMount in one container in the template. A claim in this list takes precedence over any volumes in the template, with the same name.</summary> */
        public IEnumerable<Core.V1.PersistentVolumeClaim> volumeClaimTemplates { get; set; }
    }
}