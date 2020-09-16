using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class DaemonEndpoint
    {
        /** <summary>Port number of the given endpoint.</summary> */
        public int Port { get; set; }
    }
}