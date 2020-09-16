using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Node.V1beta1
{
    public partial class Overhead
    {
        /** <summary>PodFixed represents the fixed resource overhead associated with running a pod.</summary> */
        public object podFixed { get; set; }
    }
}