using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class LabelSelectorRequirement
    {
        /** <summary>key is the label key that the selector applies to.</summary> */
        public string key { get; set; }
        /** <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary> */
        public string @operator { get; set; }
        /** <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary> */
        public List<string> values { get; set; }
    }
}