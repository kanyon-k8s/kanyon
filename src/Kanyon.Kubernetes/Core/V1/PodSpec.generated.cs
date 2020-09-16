using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class PodSpec
    {
        /** <summary>Optional duration in seconds the pod may be active on the node relative to StartTime before the system will actively try to mark it failed and kill associated containers. Value must be a positive integer.</summary> */
        public int activeDeadlineSeconds { get; set; }
        /** <summary>Affinity is a group of affinity scheduling rules.</summary> */
        public Core.V1.Affinity affinity { get; set; }
        /** <summary>AutomountServiceAccountToken indicates whether a service account token should be automatically mounted.</summary> */
        public bool automountServiceAccountToken { get; set; }
        /** <summary>List of containers belonging to the pod. Containers cannot currently be added or removed. There must be at least one container in a Pod. Cannot be updated.</summary> */
        public IEnumerable<Core.V1.Container> containers { get; set; }
        /** <summary>PodDNSConfig defines the DNS parameters of a pod in addition to those generated from DNSPolicy.</summary> */
        public Core.V1.PodDNSConfig dnsConfig { get; set; }
        /** <summary>Set DNS policy for the pod. Defaults to "ClusterFirst". Valid values are 'ClusterFirstWithHostNet', 'ClusterFirst', 'Default' or 'None'. DNS parameters given in DNSConfig will be merged with the policy selected with DNSPolicy. To have DNS options set along with hostNetwork, you have to specify DNS policy explicitly to 'ClusterFirstWithHostNet'.</summary> */
        public string dnsPolicy { get; set; }
        /** <summary>EnableServiceLinks indicates whether information about services should be injected into pod's environment variables, matching the syntax of Docker links. Optional: Defaults to true.</summary> */
        public bool enableServiceLinks { get; set; }
        /** <summary>List of ephemeral containers run in this pod. Ephemeral containers may be run in an existing pod to perform user-initiated actions such as debugging. This list cannot be specified when creating a pod, and it cannot be modified by updating the pod spec. In order to add an ephemeral container to an existing pod, use the pod's ephemeralcontainers subresource. This field is alpha-level and is only honored by servers that enable the EphemeralContainers feature.</summary> */
        public IEnumerable<Core.V1.EphemeralContainer> ephemeralContainers { get; set; }
        /** <summary>HostAliases is an optional list of hosts and IPs that will be injected into the pod's hosts file if specified. This is only valid for non-hostNetwork pods.</summary> */
        public IEnumerable<Core.V1.HostAlias> hostAliases { get; set; }
        /** <summary>Use the host's ipc namespace. Optional: Default to false.</summary> */
        public bool hostIPC { get; set; }
        /** <summary>Host networking requested for this pod. Use the host's network namespace. If this option is set, the ports that will be used must be specified. Default to false.</summary> */
        public bool hostNetwork { get; set; }
        /** <summary>Use the host's pid namespace. Optional: Default to false.</summary> */
        public bool hostPID { get; set; }
        /** <summary>Specifies the hostname of the Pod If not specified, the pod's hostname will be set to a system-defined value.</summary> */
        public string hostname { get; set; }
        /** <summary>ImagePullSecrets is an optional list of references to secrets in the same namespace to use for pulling any of the images used by this PodSpec. If specified, these secrets will be passed to individual puller implementations for them to use. For example, in the case of docker, only DockerConfig type secrets are honored. More info: https://kubernetes.io/docs/concepts/containers/images#specifying-imagepullsecrets-on-a-pod</summary> */
        public IEnumerable<Core.V1.LocalObjectReference> imagePullSecrets { get; set; }
        /** <summary>List of initialization containers belonging to the pod. Init containers are executed in order prior to containers being started. If any init container fails, the pod is considered to have failed and is handled according to its restartPolicy. The name for an init container or normal container must be unique among all containers. Init containers may not have Lifecycle actions, Readiness probes, Liveness probes, or Startup probes. The resourceRequirements of an init container are taken into account during scheduling by finding the highest request/limit for each resource type, and then using the max of of that value or the sum of the normal containers. Limits are applied to init containers in a similar fashion. Init containers cannot currently be added or removed. Cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/init-containers/</summary> */
        public IEnumerable<Core.V1.Container> initContainers { get; set; }
        /** <summary>NodeName is a request to schedule this pod onto a specific node. If it is non-empty, the scheduler simply schedules this pod onto that node, assuming that it fits resource requirements.</summary> */
        public string nodeName { get; set; }
        /** <summary>NodeSelector is a selector which must be true for the pod to fit on a node. Selector which must match a node's labels for the pod to be scheduled on that node. More info: https://kubernetes.io/docs/concepts/configuration/assign-pod-node/</summary> */
        public object nodeSelector { get; set; }
        /** <summary>Overhead represents the resource overhead associated with running a pod for a given RuntimeClass. This field will be autopopulated at admission time by the RuntimeClass admission controller. If the RuntimeClass admission controller is enabled, overhead must not be set in Pod create requests. The RuntimeClass admission controller will reject Pod create requests which have the overhead already set. If RuntimeClass is configured and selected in the PodSpec, Overhead will be set to the value defined in the corresponding RuntimeClass, otherwise it will remain unset and treated as zero. More info: https://git.k8s.io/enhancements/keps/sig-node/20190226-pod-overhead.md This field is alpha-level as of Kubernetes v1.16, and is only honored by servers that enable the PodOverhead feature.</summary> */
        public object overhead { get; set; }
        /** <summary>PreemptionPolicy is the Policy for preempting pods with lower priority. One of Never, PreemptLowerPriority. Defaults to PreemptLowerPriority if unset. This field is beta-level, gated by the NonPreemptingPriority feature-gate.</summary> */
        public string preemptionPolicy { get; set; }
        /** <summary>The priority value. Various system components use this field to find the priority of the pod. When Priority Admission Controller is enabled, it prevents users from setting this field. The admission controller populates this field from PriorityClassName. The higher the value, the higher the priority.</summary> */
        public int priority { get; set; }
        /** <summary>If specified, indicates the pod's priority. "system-node-critical" and "system-cluster-critical" are two special keywords which indicate the highest priorities with the former being the highest priority. Any other name must be defined by creating a PriorityClass object with that name. If not specified, the pod priority will be default or zero if there is no default.</summary> */
        public string priorityClassName { get; set; }
        /** <summary>If specified, all readiness gates will be evaluated for pod readiness. A pod is ready when all its containers are ready AND all conditions specified in the readiness gates have status equal to "True" More info: https://git.k8s.io/enhancements/keps/sig-network/0007-pod-ready%2B%2B.md</summary> */
        public IEnumerable<Core.V1.PodReadinessGate> readinessGates { get; set; }
        /** <summary>Restart policy for all containers within the pod. One of Always, OnFailure, Never. Default to Always. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle/#restart-policy</summary> */
        public string restartPolicy { get; set; }
        /** <summary>RuntimeClassName refers to a RuntimeClass object in the node.k8s.io group, which should be used to run this pod.  If no RuntimeClass resource matches the named class, the pod will not be run. If unset or empty, the "legacy" RuntimeClass will be used, which is an implicit class with an empty definition that uses the default runtime handler. More info: https://git.k8s.io/enhancements/keps/sig-node/runtime-class.md This is a beta feature as of Kubernetes v1.14.</summary> */
        public string runtimeClassName { get; set; }
        /** <summary>If specified, the pod will be dispatched by specified scheduler. If not specified, the pod will be dispatched by default scheduler.</summary> */
        public string schedulerName { get; set; }
        /** <summary>PodSecurityContext holds pod-level security attributes and common container settings. Some fields are also present in container.securityContext.  Field values of container.securityContext take precedence over field values of PodSecurityContext.</summary> */
        public Core.V1.PodSecurityContext securityContext { get; set; }
        /** <summary>DeprecatedServiceAccount is a depreciated alias for ServiceAccountName. Deprecated: Use serviceAccountName instead.</summary> */
        public string serviceAccount { get; set; }
        /** <summary>ServiceAccountName is the name of the ServiceAccount to use to run this pod. More info: https://kubernetes.io/docs/tasks/configure-pod-container/configure-service-account/</summary> */
        public string serviceAccountName { get; set; }
        /** <summary>If true the pod's hostname will be configured as the pod's FQDN, rather than the leaf name (the default). In Linux containers, this means setting the FQDN in the hostname field of the kernel (the nodename field of struct utsname). In Windows containers, this means setting the registry value of hostname for the registry key HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters to FQDN. If a pod does not have FQDN, this has no effect. Default to false.</summary> */
        public bool setHostnameAsFQDN { get; set; }
        /** <summary>Share a single process namespace between all of the containers in a pod. When this is set containers will be able to view and signal processes from other containers in the same pod, and the first process in each container will not be assigned PID 1. HostPID and ShareProcessNamespace cannot both be set. Optional: Default to false.</summary> */
        public bool shareProcessNamespace { get; set; }
        /** <summary>If specified, the fully qualified Pod hostname will be "<hostname>.<subdomain>.<pod namespace>.svc.<cluster domain>". If not specified, the pod will not have a domainname at all.</summary> */
        public string subdomain { get; set; }
        /** <summary>Optional duration in seconds the pod needs to terminate gracefully. May be decreased in delete request. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period will be used instead. The grace period is the duration in seconds after the processes running in the pod are sent a termination signal and the time when the processes are forcibly halted with a kill signal. Set this value longer than the expected cleanup time for your process. Defaults to 30 seconds.</summary> */
        public int terminationGracePeriodSeconds { get; set; }
        /** <summary>If specified, the pod's tolerations.</summary> */
        public IEnumerable<Core.V1.Toleration> tolerations { get; set; }
        /** <summary>TopologySpreadConstraints describes how a group of pods ought to spread across topology domains. Scheduler will schedule pods in a way which abides by the constraints. All topologySpreadConstraints are ANDed.</summary> */
        public IEnumerable<Core.V1.TopologySpreadConstraint> topologySpreadConstraints { get; set; }
        /** <summary>List of volumes that can be mounted by containers belonging to the pod. More info: https://kubernetes.io/docs/concepts/storage/volumes</summary> */
        public IEnumerable<Core.V1.Volume> volumes { get; set; }
    }
}