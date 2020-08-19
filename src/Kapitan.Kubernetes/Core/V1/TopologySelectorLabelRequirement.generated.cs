using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class TopologySelectorLabelRequirement
    {
        /** <summary>The label key that the selector applies to.</summary> */
        public string key { get; set; }
        /** <summary>An array of string values. One value must match the label to be selected. Each entry in Values is ORed.</summary> */
        public List<string> values { get; set; }
    }
}