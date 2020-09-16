using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class HostAlias
    {
        /** <summary>Hostnames for the above IP address.</summary> */
        public IEnumerable<string> hostnames { get; set; }
        /** <summary>IP address of the host file entry.</summary> */
        public string ip { get; set; }
    }
}