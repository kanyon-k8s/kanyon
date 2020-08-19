using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class HostAlias
    {
        /** <summary>Hostnames for the above IP address.</summary> */
        public List<string> hostnames { get; set; }
        /** <summary>IP address of the host file entry.</summary> */
        public string ip { get; set; }
    }
}