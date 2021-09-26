using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class Probe
    {
        /** <summary>ExecAction describes a "run in container" action.</summary> */
        public Core.V1.ExecAction exec { get; set; }
        /** <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary> */
        public int failureThreshold { get; set; }
        /** <summary>HTTPGetAction describes an action based on HTTP Get requests.</summary> */
        public Core.V1.HTTPGetAction httpGet { get; set; }
        /** <summary>Number of seconds after the container has started before liveness probes are initiated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary> */
        public int initialDelaySeconds { get; set; }
        /** <summary>How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1.</summary> */
        public int periodSeconds { get; set; }
        /** <summary>Minimum consecutive successes for the probe to be considered successful after having failed. Defaults to 1. Must be 1 for liveness and startup. Minimum value is 1.</summary> */
        public int successThreshold { get; set; }
        /** <summary>TCPSocketAction describes an action based on opening a socket</summary> */
        public Core.V1.TCPSocketAction tcpSocket { get; set; }
        /** <summary>Optional duration in seconds the pod needs to terminate gracefully upon probe failure. The grace period is the duration in seconds after the processes running in the pod are sent a termination signal and the time when the processes are forcibly halted with a kill signal. Set this value longer than the expected cleanup time for your process. If this value is nil, the pod's terminationGracePeriodSeconds will be used. Otherwise, this value overrides the value provided by the pod spec. Value must be non-negative integer. The value zero indicates stop immediately via the kill signal (no opportunity to shut down). This is a beta field and requires enabling ProbeTerminationGracePeriod feature gate. Minimum value is 1. spec.terminationGracePeriodSeconds is used if unset.</summary> */
        public int terminationGracePeriodSeconds { get; set; }
        /** <summary>Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary> */
        public int timeoutSeconds { get; set; }
    }
}