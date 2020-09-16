using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class LimitRangeItem
    {
        /** <summary>Default resource requirement limit value by resource name if resource limit is omitted.</summary> */
        public object @default { get; set; }
        /** <summary>DefaultRequest is the default resource requirement request value by resource name if resource request is omitted.</summary> */
        public object defaultRequest { get; set; }
        /** <summary>Max usage constraints on this kind by resource name.</summary> */
        public object max { get; set; }
        /** <summary>MaxLimitRequestRatio if specified, the named resource must have a request and limit that are both non-zero where limit divided by request is less than or equal to the enumerated value; this represents the max burst for the named resource.</summary> */
        public object maxLimitRequestRatio { get; set; }
        /** <summary>Min usage constraints on this kind by resource name.</summary> */
        public object min { get; set; }
        /** <summary>Type of resource that this limit applies to.</summary> */
        public string type { get; set; }
    }
}