using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Autoscaling.V1
{
    public partial class ScaleSpec
    {
        /** <summary>desired number of instances for the scaled object.</summary> */
        public int replicas { get; set; }
    }
}