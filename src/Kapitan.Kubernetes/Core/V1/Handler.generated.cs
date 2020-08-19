using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class Handler
    {
        /** <summary>ExecAction describes a "run in container" action.</summary> */
        public Core.V1.ExecAction exec { get; set; }
        /** <summary>HTTPGetAction describes an action based on HTTP Get requests.</summary> */
        public Core.V1.HTTPGetAction httpGet { get; set; }
        /** <summary>TCPSocketAction describes an action based on opening a socket</summary> */
        public Core.V1.TCPSocketAction tcpSocket { get; set; }
    }
}