using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class NodeStatus
    {
        /** <summary>List of addresses reachable to the node. Queried from cloud provider, if available. More info: https://kubernetes.io/docs/concepts/nodes/node/#addresses Note: This field is declared as mergeable, but the merge key is not sufficiently unique, which can cause data corruption when it is merged. Callers should instead use a full-replacement patch. See http://pr.k8s.io/79391 for an example.</summary> */
        public IEnumerable<Core.V1.NodeAddress> addresses { get; set; }
        /** <summary>Allocatable represents the resources of a node that are available for scheduling. Defaults to Capacity.</summary> */
        public object allocatable { get; set; }
        /** <summary>Capacity represents the total resources of a node. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#capacity</summary> */
        public object capacity { get; set; }
        /** <summary>Conditions is an array of current observed node conditions. More info: https://kubernetes.io/docs/concepts/nodes/node/#condition</summary> */
        public IEnumerable<Core.V1.NodeCondition> conditions { get; set; }
        /** <summary>NodeConfigStatus describes the status of the config assigned by Node.Spec.ConfigSource.</summary> */
        public Core.V1.NodeConfigStatus config { get; set; }
        /** <summary>NodeDaemonEndpoints lists ports opened by daemons running on the Node.</summary> */
        public Core.V1.NodeDaemonEndpoints daemonEndpoints { get; set; }
        /** <summary>List of container images on this node</summary> */
        public IEnumerable<Core.V1.ContainerImage> images { get; set; }
        /** <summary>NodeSystemInfo is a set of ids/uuids to uniquely identify the node.</summary> */
        public Core.V1.NodeSystemInfo nodeInfo { get; set; }
        /** <summary>NodePhase is the recently observed lifecycle phase of the node. More info: https://kubernetes.io/docs/concepts/nodes/node/#phase The field is never populated, and now is deprecated.</summary> */
        public string phase { get; set; }
        /** <summary>List of volumes that are attached to the node.</summary> */
        public IEnumerable<Core.V1.AttachedVolume> volumesAttached { get; set; }
        /** <summary>List of attachable volumes in use (mounted) by the node.</summary> */
        public IEnumerable<string> volumesInUse { get; set; }
    }
}