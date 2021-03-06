using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Policy.V1beta1
{
    public partial class IDRange
    {
        /** <summary>max is the end of the range, inclusive.</summary> */
        public int max { get; set; }
        /** <summary>min is the start of the range, inclusive.</summary> */
        public int min { get; set; }
    }
}