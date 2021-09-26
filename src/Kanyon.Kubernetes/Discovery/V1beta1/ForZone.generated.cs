using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Discovery.V1beta1
{
    public partial class ForZone
    {
        /** <summary>name represents the name of the zone.</summary> */
        public string name { get; set; }
    }
}