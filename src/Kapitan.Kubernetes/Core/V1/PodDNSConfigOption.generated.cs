using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class PodDNSConfigOption
    {
        /** <summary>Required.</summary> */
        public string name { get; set; }
        /** <summary></summary> */
        public string value { get; set; }
    }
}