using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class PodSecurityContext
    {
        /** <summary>A special supplemental group that applies to all containers in a pod. Some volume types allow the Kubelet to change the ownership of that volume to be owned by the pod:

1. The owning GID will be the FSGroup 2. The setgid bit is set (new files created in the volume will be owned by FSGroup) 3. The permission bits are OR'd with rw-rw----

If unset, the Kubelet will not modify the ownership and permissions of any volume.</summary> */
        public int fsGroup { get; set; }
        /** <summary>fsGroupChangePolicy defines behavior of changing ownership and permission of the volume before being exposed inside Pod. This field will only apply to volume types which support fsGroup based ownership(and permissions). It will have no effect on ephemeral volume types such as: secret, configmaps and emptydir. Valid values are "OnRootMismatch" and "Always". If not specified, "Always" is used.</summary> */
        public string fsGroupChangePolicy { get; set; }
        /** <summary>The GID to run the entrypoint of the container process. Uses runtime default if unset. May also be set in SecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence for that container.</summary> */
        public int runAsGroup { get; set; }
        /** <summary>Indicates that the container must run as a non-root user. If true, the Kubelet will validate the image at runtime to ensure that it does not run as UID 0 (root) and fail to start the container if it does. If unset or false, no such validation will be performed. May also be set in SecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.</summary> */
        public bool? runAsNonRoot { get; set; }
        /** <summary>The UID to run the entrypoint of the container process. Defaults to user specified in image metadata if unspecified. May also be set in SecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence for that container.</summary> */
        public int runAsUser { get; set; }
        /** <summary>SELinuxOptions are the labels to be applied to the container</summary> */
        public Core.V1.SELinuxOptions seLinuxOptions { get; set; }
        /** <summary>SeccompProfile defines a pod/container's seccomp profile settings. Only one profile source may be set.</summary> */
        public Core.V1.SeccompProfile seccompProfile { get; set; }
        /** <summary>A list of groups applied to the first process run in each container, in addition to the container's primary GID.  If unspecified, no groups will be added to any container.</summary> */
        public IEnumerable<int> supplementalGroups { get; set; }
        /** <summary>Sysctls hold a list of namespaced sysctls used for the pod. Pods with unsupported sysctls (by the container runtime) might fail to launch.</summary> */
        public IEnumerable<Core.V1.Sysctl> sysctls { get; set; }
        /** <summary>WindowsSecurityContextOptions contain Windows-specific options and credentials.</summary> */
        public Core.V1.WindowsSecurityContextOptions windowsOptions { get; set; }
    }
}