using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class LabelSelector
    {
        /** <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary> */
        public IEnumerable<Core.V1.LabelSelectorRequirement> matchExpressions { get; set; }
        /** <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary> */
        public object matchLabels { get; set; }
    }
}