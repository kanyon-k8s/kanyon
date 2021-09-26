using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class SecurityContext
    {
        /** <summary>AllowPrivilegeEscalation controls whether a process can gain more privileges than its parent process. This bool directly controls if the no_new_privs flag will be set on the container process. AllowPrivilegeEscalation is true always when the container is: 1) run as Privileged 2) has CAP_SYS_ADMIN</summary> */
        public bool? allowPrivilegeEscalation { get; set; }
        /** <summary>Adds and removes POSIX capabilities from running containers.</summary> */
        public Core.V1.Capabilities capabilities { get; set; }
        /** <summary>Run container in privileged mode. Processes in privileged containers are essentially equivalent to root on the host. Defaults to false.</summary> */
        public bool? privileged { get; set; }
        /** <summary>procMount denotes the type of proc mount to use for the containers. The default is DefaultProcMount which uses the container runtime defaults for readonly paths and masked paths. This requires the ProcMountType feature flag to be enabled.</summary> */
        public string procMount { get; set; }
        /** <summary>Whether this container has a read-only root filesystem. Default is false.</summary> */
        public bool? readOnlyRootFilesystem { get; set; }
        /** <summary>The GID to run the entrypoint of the container process. Uses runtime default if unset. May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.</summary> */
        public int runAsGroup { get; set; }
        /** <summary>Indicates that the container must run as a non-root user. If true, the Kubelet will validate the image at runtime to ensure that it does not run as UID 0 (root) and fail to start the container if it does. If unset or false, no such validation will be performed. May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.</summary> */
        public bool? runAsNonRoot { get; set; }
        /** <summary>The UID to run the entrypoint of the container process. Defaults to user specified in image metadata if unspecified. May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.</summary> */
        public int runAsUser { get; set; }
        /** <summary>SELinuxOptions are the labels to be applied to the container</summary> */
        public Core.V1.SELinuxOptions seLinuxOptions { get; set; }
        /** <summary>SeccompProfile defines a pod/container's seccomp profile settings. Only one profile source may be set.</summary> */
        public Core.V1.SeccompProfile seccompProfile { get; set; }
        /** <summary>WindowsSecurityContextOptions contain Windows-specific options and credentials.</summary> */
        public Core.V1.WindowsSecurityContextOptions windowsOptions { get; set; }
    }
}