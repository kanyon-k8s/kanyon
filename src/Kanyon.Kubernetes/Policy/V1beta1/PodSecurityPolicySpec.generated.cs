using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Policy.V1beta1
{
    public partial class PodSecurityPolicySpec
    {
        /** <summary>allowPrivilegeEscalation determines if a pod can request to allow privilege escalation. If unspecified, defaults to true.</summary> */
        public bool? allowPrivilegeEscalation { get; set; }
        /** <summary>AllowedCSIDrivers is an allowlist of inline CSI drivers that must be explicitly set to be embedded within a pod spec. An empty value indicates that any CSI driver can be used for inline ephemeral volumes. This is a beta field, and is only honored if the API server enables the CSIInlineVolume feature gate.</summary> */
        public IEnumerable<Policy.V1beta1.AllowedCSIDriver> allowedCSIDrivers { get; set; }
        /** <summary>allowedCapabilities is a list of capabilities that can be requested to add to the container. Capabilities in this field may be added at the pod author's discretion. You must not list a capability in both allowedCapabilities and requiredDropCapabilities.</summary> */
        public IEnumerable<string> allowedCapabilities { get; set; }
        /** <summary>allowedFlexVolumes is an allowlist of Flexvolumes.  Empty or nil indicates that all Flexvolumes may be used.  This parameter is effective only when the usage of the Flexvolumes is allowed in the "volumes" field.</summary> */
        public IEnumerable<Policy.V1beta1.AllowedFlexVolume> allowedFlexVolumes { get; set; }
        /** <summary>allowedHostPaths is an allowlist of host paths. Empty indicates that all host paths may be used.</summary> */
        public IEnumerable<Policy.V1beta1.AllowedHostPath> allowedHostPaths { get; set; }
        /** <summary>AllowedProcMountTypes is an allowlist of allowed ProcMountTypes. Empty or nil indicates that only the DefaultProcMountType may be used. This requires the ProcMountType feature flag to be enabled.</summary> */
        public IEnumerable<string> allowedProcMountTypes { get; set; }
        /** <summary>allowedUnsafeSysctls is a list of explicitly allowed unsafe sysctls, defaults to none. Each entry is either a plain sysctl name or ends in "&#42;" in which case it is considered as a prefix of allowed sysctls. Single &#42; means all unsafe sysctls are allowed. Kubelet has to allowlist all allowed unsafe sysctls explicitly to avoid rejection.

Examples: e.g. "foo/&#42;" allows "foo/bar", "foo/baz", etc. e.g. "foo.&#42;" allows "foo.bar", "foo.baz", etc.</summary> */
        public IEnumerable<string> allowedUnsafeSysctls { get; set; }
        /** <summary>defaultAddCapabilities is the default set of capabilities that will be added to the container unless the pod spec specifically drops the capability.  You may not list a capability in both defaultAddCapabilities and requiredDropCapabilities. Capabilities added here are implicitly allowed, and need not be included in the allowedCapabilities list.</summary> */
        public IEnumerable<string> defaultAddCapabilities { get; set; }
        /** <summary>defaultAllowPrivilegeEscalation controls the default setting for whether a process can gain more privileges than its parent process.</summary> */
        public bool? defaultAllowPrivilegeEscalation { get; set; }
        /** <summary>forbiddenSysctls is a list of explicitly forbidden sysctls, defaults to none. Each entry is either a plain sysctl name or ends in "&#42;" in which case it is considered as a prefix of forbidden sysctls. Single &#42; means all sysctls are forbidden.

Examples: e.g. "foo/&#42;" forbids "foo/bar", "foo/baz", etc. e.g. "foo.&#42;" forbids "foo.bar", "foo.baz", etc.</summary> */
        public IEnumerable<string> forbiddenSysctls { get; set; }
        /** <summary>FSGroupStrategyOptions defines the strategy type and options used to create the strategy.</summary> */
        public Policy.V1beta1.FSGroupStrategyOptions fsGroup { get; set; }
        /** <summary>hostIPC determines if the policy allows the use of HostIPC in the pod spec.</summary> */
        public bool? hostIPC { get; set; }
        /** <summary>hostNetwork determines if the policy allows the use of HostNetwork in the pod spec.</summary> */
        public bool? hostNetwork { get; set; }
        /** <summary>hostPID determines if the policy allows the use of HostPID in the pod spec.</summary> */
        public bool? hostPID { get; set; }
        /** <summary>hostPorts determines which host port ranges are allowed to be exposed.</summary> */
        public IEnumerable<Policy.V1beta1.HostPortRange> hostPorts { get; set; }
        /** <summary>privileged determines if a pod can request to be run as privileged.</summary> */
        public bool? privileged { get; set; }
        /** <summary>readOnlyRootFilesystem when set to true will force containers to run with a read only root file system.  If the container specifically requests to run with a non-read only root file system the PSP should deny the pod. If set to false the container may run with a read only root file system if it wishes but it will not be forced to.</summary> */
        public bool? readOnlyRootFilesystem { get; set; }
        /** <summary>requiredDropCapabilities are the capabilities that will be dropped from the container.  These are required to be dropped and cannot be added.</summary> */
        public IEnumerable<string> requiredDropCapabilities { get; set; }
        /** <summary>RunAsGroupStrategyOptions defines the strategy type and any options used to create the strategy.</summary> */
        public Policy.V1beta1.RunAsGroupStrategyOptions runAsGroup { get; set; }
        /** <summary>RunAsUserStrategyOptions defines the strategy type and any options used to create the strategy.</summary> */
        public Policy.V1beta1.RunAsUserStrategyOptions runAsUser { get; set; }
        /** <summary>RuntimeClassStrategyOptions define the strategy that will dictate the allowable RuntimeClasses for a pod.</summary> */
        public Policy.V1beta1.RuntimeClassStrategyOptions runtimeClass { get; set; }
        /** <summary>SELinuxStrategyOptions defines the strategy type and any options used to create the strategy.</summary> */
        public Policy.V1beta1.SELinuxStrategyOptions seLinux { get; set; }
        /** <summary>SupplementalGroupsStrategyOptions defines the strategy type and options used to create the strategy.</summary> */
        public Policy.V1beta1.SupplementalGroupsStrategyOptions supplementalGroups { get; set; }
        /** <summary>volumes is an allowlist of volume plugins. Empty indicates that no volumes may be used. To allow all volumes you may use '&#42;'.</summary> */
        public IEnumerable<string> volumes { get; set; }
    }
}