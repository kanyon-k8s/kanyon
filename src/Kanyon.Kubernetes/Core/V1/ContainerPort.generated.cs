using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class ContainerPort
    {
        /** <summary>Number of port to expose on the pod's IP address. This must be a valid port number, 0 < x < 65536.</summary> */
        public int containerPort { get; set; }
        /** <summary>What host IP to bind the external port to.</summary> */
        public string hostIP { get; set; }
        /** <summary>Number of port to expose on the host. If specified, this must be a valid port number, 0 < x < 65536. If HostNetwork is specified, this must match ContainerPort. Most containers do not need this.</summary> */
        public int hostPort { get; set; }
        /** <summary>If specified, this must be an IANA_SVC_NAME and unique within the pod. Each named port in a pod must have a unique name. Name for the port that can be referred to by services.</summary> */
        public string name { get; set; }
        /** <summary>Protocol for port. Must be UDP, TCP, or SCTP. Defaults to "TCP".</summary> */
        public string protocol { get; set; }
    }
}