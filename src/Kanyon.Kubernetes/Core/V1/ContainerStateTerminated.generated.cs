using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class ContainerStateTerminated
    {
        /** <summary>Container's ID in the format 'docker://<container_id>'</summary> */
        public string containerID { get; set; }
        /** <summary>Exit status from the last termination of the container</summary> */
        public int exitCode { get; set; }
        /** <summary>Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers.</summary> */
        public Core.V1.Time finishedAt { get; set; }
        /** <summary>Message regarding the last termination of the container</summary> */
        public string message { get; set; }
        /** <summary>(brief) reason from the last termination of the container</summary> */
        public string reason { get; set; }
        /** <summary>Signal from the last termination of the container</summary> */
        public int signal { get; set; }
        /** <summary>Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers.</summary> */
        public Core.V1.Time startedAt { get; set; }
    }
}