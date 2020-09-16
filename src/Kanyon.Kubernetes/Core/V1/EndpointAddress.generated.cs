using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class EndpointAddress
    {
        /** <summary>The Hostname of this endpoint</summary> */
        public string hostname { get; set; }
        /** <summary>The IP of this endpoint. May not be loopback (127.0.0.0/8), link-local (169.254.0.0/16), or link-local multicast ((224.0.0.0/24). IPv6 is also accepted but not fully supported on all platforms. Also, certain kubernetes components, like kube-proxy, are not IPv6 ready.</summary> */
        public string ip { get; set; }
        /** <summary>Optional: Node hosting this endpoint. This can be used to determine endpoints local to a node.</summary> */
        public string nodeName { get; set; }
        /** <summary>ObjectReference contains enough information to let you inspect or modify the referred object.</summary> */
        public Core.V1.ObjectReference targetRef { get; set; }
    }
}