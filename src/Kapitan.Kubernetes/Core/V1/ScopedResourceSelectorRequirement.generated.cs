using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class ScopedResourceSelectorRequirement
    {
        /** <summary>Represents a scope's relationship to a set of values. Valid operators are In, NotIn, Exists, DoesNotExist.</summary> */
        public string @operator { get; set; }
        /** <summary>The name of the scope that the selector applies to.</summary> */
        public string scopeName { get; set; }
        /** <summary>An array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary> */
        public IEnumerable<string> values { get; set; }
    }
}