using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class VolumeNodeAffinity
    {
        /** <summary>A node selector represents the union of the results of one or more label queries over a set of nodes; that is, it represents the OR of the selectors represented by the node selector terms.</summary> */
        public Core.V1.NodeSelector required { get; set; }
    }
}