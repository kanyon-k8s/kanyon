using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class SessionAffinityConfig
    {
        /** <summary>ClientIPConfig represents the configurations of Client IP based session affinity.</summary> */
        public Core.V1.ClientIPConfig clientIP { get; set; }
    }
}