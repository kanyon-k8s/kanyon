using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class NodeAddress
    {
        /** <summary>The node address.</summary> */
        public string address { get; set; }
        /** <summary>Node address type, one of Hostname, ExternalIP or InternalIP.</summary> */
        public string type { get; set; }
    }
}