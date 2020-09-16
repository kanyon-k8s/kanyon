using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class PodStatus
    {
        /** <summary>Current service state of pod. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-conditions</summary> */
        public IEnumerable<Core.V1.PodCondition> conditions { get; set; }
        /** <summary>The list has one entry per container in the manifest. Each entry is currently the output of `docker inspect`. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-and-container-status</summary> */
        public IEnumerable<Core.V1.ContainerStatus> containerStatuses { get; set; }
        /** <summary>Status for any ephemeral containers that have run in this pod. This field is alpha-level and is only populated by servers that enable the EphemeralContainers feature.</summary> */
        public IEnumerable<Core.V1.ContainerStatus> ephemeralContainerStatuses { get; set; }
        /** <summary>IP address of the host to which the pod is assigned. Empty if not yet scheduled.</summary> */
        public string hostIP { get; set; }
        /** <summary>The list has one entry per init container in the manifest. The most recent successful init container will have ready = true, the most recently started container will have startTime set. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-and-container-status</summary> */
        public IEnumerable<Core.V1.ContainerStatus> initContainerStatuses { get; set; }
        /** <summary>A human readable message indicating details about why the pod is in this condition.</summary> */
        public string message { get; set; }
        /** <summary>nominatedNodeName is set only when this pod preempts other pods on the node, but it cannot be scheduled right away as preemption victims receive their graceful termination periods. This field does not guarantee that the pod will be scheduled on this node. Scheduler may decide to place the pod elsewhere if other nodes become available sooner. Scheduler may also decide to give the resources on this node to a higher priority pod that is created after preemption. As a result, this field may be different than PodSpec.nodeName when the pod is scheduled.</summary> */
        public string nominatedNodeName { get; set; }
        /** <summary>The phase of a Pod is a simple, high-level summary of where the Pod is in its lifecycle. The conditions array, the reason and message fields, and the individual container status arrays contain more detail about the pod's status. There are five possible phase values:

Pending: The pod has been accepted by the Kubernetes system, but one or more of the container images has not been created. This includes time before being scheduled as well as time spent downloading images over the network, which could take a while. Running: The pod has been bound to a node, and all of the containers have been created. At least one container is still running, or is in the process of starting or restarting. Succeeded: All containers in the pod have terminated in success, and will not be restarted. Failed: All containers in the pod have terminated, and at least one container has terminated in failure. The container either exited with non-zero status or was terminated by the system. Unknown: For some reason the state of the pod could not be obtained, typically due to an error in communicating with the host of the pod.

More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-phase</summary> */
        public string phase { get; set; }
        /** <summary>IP address allocated to the pod. Routable at least within the cluster. Empty if not yet allocated.</summary> */
        public string podIP { get; set; }
        /** <summary>podIPs holds the IP addresses allocated to the pod. If this field is specified, the 0th entry must match the podIP field. Pods may be allocated at most 1 value for each of IPv4 and IPv6. This list is empty if no IPs have been allocated yet.</summary> */
        public IEnumerable<Core.V1.PodIP> podIPs { get; set; }
        /** <summary>The Quality of Service (QOS) classification assigned to the pod based on resource requirements See PodQOSClass type for available QOS classes More info: https://git.k8s.io/community/contributors/design-proposals/node/resource-qos.md</summary> */
        public string qosClass { get; set; }
        /** <summary>A brief CamelCase message indicating details about why the pod is in this state. e.g. 'Evicted'</summary> */
        public string reason { get; set; }
        /** <summary>Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers.</summary> */
        public Core.V1.Time startTime { get; set; }
    }
}