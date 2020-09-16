using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class PodIP
    {
        /** <summary>ip is an IP address (IPv4 or IPv6) assigned to the pod</summary> */
        public string ip { get; set; }
    }
}