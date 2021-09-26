using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class EphemeralContainer
    {
        /** <summary>Arguments to the entrypoint. The docker image's CMD is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. Double $$ are reduced to a single $, which allows for escaping the $(VAR_NAME) syntax: i.e. "$$(VAR_NAME)" will produce the string literal "$(VAR_NAME)". Escaped references will never be expanded, regardless of whether the variable exists or not. Cannot be updated. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell</summary> */
        public IEnumerable<string> args { get; set; }
        /** <summary>Entrypoint array. Not executed within a shell. The docker image's ENTRYPOINT is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. Double $$ are reduced to a single $, which allows for escaping the $(VAR_NAME) syntax: i.e. "$$(VAR_NAME)" will produce the string literal "$(VAR_NAME)". Escaped references will never be expanded, regardless of whether the variable exists or not. Cannot be updated. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell</summary> */
        public IEnumerable<string> command { get; set; }
        /** <summary>List of environment variables to set in the container. Cannot be updated.</summary> */
        public IEnumerable<Core.V1.EnvVar> env { get; set; }
        /** <summary>List of sources to populate environment variables in the container. The keys defined within a source must be a C_IDENTIFIER. All invalid keys will be reported as an event when the container is starting. When a key exists in multiple sources, the value associated with the last source will take precedence. Values defined by an Env with a duplicate key will take precedence. Cannot be updated.</summary> */
        public IEnumerable<Core.V1.EnvFromSource> envFrom { get; set; }
        /** <summary>Docker image name. More info: https://kubernetes.io/docs/concepts/containers/images</summary> */
        public string image { get; set; }
        /** <summary>Image pull policy. One of Always, Never, IfNotPresent. Defaults to Always if :latest tag is specified, or IfNotPresent otherwise. Cannot be updated. More info: https://kubernetes.io/docs/concepts/containers/images#updating-images</summary> */
        public string imagePullPolicy { get; set; }
        /** <summary>Lifecycle describes actions that the management system should take in response to container lifecycle events. For the PostStart and PreStop lifecycle handlers, management of the container blocks until the action is complete, unless the container process fails, in which case the handler is aborted.</summary> */
        public Core.V1.Lifecycle lifecycle { get; set; }
        /** <summary>Probe describes a health check to be performed against a container to determine whether it is alive or ready to receive traffic.</summary> */
        public Core.V1.Probe livenessProbe { get; set; }
        /** <summary>Name of the ephemeral container specified as a DNS_LABEL. This name must be unique among all containers, init containers and ephemeral containers.</summary> */
        public string name { get; set; }
        /** <summary>Ports are not allowed for ephemeral containers.</summary> */
        public IEnumerable<Core.V1.ContainerPort> ports { get; set; }
        /** <summary>Probe describes a health check to be performed against a container to determine whether it is alive or ready to receive traffic.</summary> */
        public Core.V1.Probe readinessProbe { get; set; }
        /** <summary>ResourceRequirements describes the compute resource requirements.</summary> */
        public Core.V1.ResourceRequirements resources { get; set; }
        /** <summary>SecurityContext holds security configuration that will be applied to a container. Some fields are present in both SecurityContext and PodSecurityContext.  When both are set, the values in SecurityContext take precedence.</summary> */
        public Core.V1.SecurityContext securityContext { get; set; }
        /** <summary>Probe describes a health check to be performed against a container to determine whether it is alive or ready to receive traffic.</summary> */
        public Core.V1.Probe startupProbe { get; set; }
        /** <summary>Whether this container should allocate a buffer for stdin in the container runtime. If this is not set, reads from stdin in the container will always result in EOF. Default is false.</summary> */
        public bool? stdin { get; set; }
        /** <summary>Whether the container runtime should close the stdin channel after it has been opened by a single attach. When stdin is true the stdin stream will remain open across multiple attach sessions. If stdinOnce is set to true, stdin is opened on container start, is empty until the first client attaches to stdin, and then remains open and accepts data until the client disconnects, at which time stdin is closed and remains closed until the container is restarted. If this flag is false, a container processes that reads from stdin will never receive an EOF. Default is false</summary> */
        public bool? stdinOnce { get; set; }
        /** <summary>If set, the name of the container from PodSpec that this ephemeral container targets. The ephemeral container will be run in the namespaces (IPC, PID, etc) of this container. If not set then the ephemeral container is run in whatever namespaces are shared for the pod. Note that the container runtime must support this feature.</summary> */
        public string targetContainerName { get; set; }
        /** <summary>Optional: Path at which the file to which the container's termination message will be written is mounted into the container's filesystem. Message written is intended to be brief final status, such as an assertion failure message. Will be truncated by the node if greater than 4096 bytes. The total message length across all containers will be limited to 12kb. Defaults to /dev/termination-log. Cannot be updated.</summary> */
        public string terminationMessagePath { get; set; }
        /** <summary>Indicate how the termination message should be populated. File will use the contents of terminationMessagePath to populate the container status message on both success and failure. FallbackToLogsOnError will use the last chunk of container log output if the termination message file is empty and the container exited with an error. The log output is limited to 2048 bytes or 80 lines, whichever is smaller. Defaults to File. Cannot be updated.</summary> */
        public string terminationMessagePolicy { get; set; }
        /** <summary>Whether this container should allocate a TTY for itself, also requires 'stdin' to be true. Default is false.</summary> */
        public bool? tty { get; set; }
        /** <summary>volumeDevices is the list of block devices to be used by the container.</summary> */
        public IEnumerable<Core.V1.VolumeDevice> volumeDevices { get; set; }
        /** <summary>Pod volumes to mount into the container's filesystem. Cannot be updated.</summary> */
        public IEnumerable<Core.V1.VolumeMount> volumeMounts { get; set; }
        /** <summary>Container's working directory. If not specified, the container runtime's default will be used, which might be configured in the container image. Cannot be updated.</summary> */
        public string workingDir { get; set; }
    }
}