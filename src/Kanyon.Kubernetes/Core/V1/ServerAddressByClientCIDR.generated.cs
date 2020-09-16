using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class ServerAddressByClientCIDR
    {
        /** <summary>The CIDR with which clients can match their IP to figure out the server address that they should use.</summary> */
        public string clientCIDR { get; set; }
        /** <summary>Address of this server, suitable for a client that matches the above CIDR. This can be a hostname, hostname:port, IP or IP:port.</summary> */
        public string serverAddress { get; set; }
    }
}