using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class TopologySelectorLabelRequirement
    {
        /** <summary>The label key that the selector applies to.</summary> */
        public string key { get; set; }
        /** <summary>An array of string values. One value must match the label to be selected. Each entry in Values is ORed.</summary> */
        public IEnumerable<string> values { get; set; }
    }
}