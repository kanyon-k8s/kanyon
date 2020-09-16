using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class Affinity
    {
        /** <summary>Node affinity is a group of node affinity scheduling rules.</summary> */
        public Core.V1.NodeAffinity nodeAffinity { get; set; }
        /** <summary>Pod affinity is a group of inter pod affinity scheduling rules.</summary> */
        public Core.V1.PodAffinity podAffinity { get; set; }
        /** <summary>Pod anti affinity is a group of inter pod anti affinity scheduling rules.</summary> */
        public Core.V1.PodAntiAffinity podAntiAffinity { get; set; }
    }
}