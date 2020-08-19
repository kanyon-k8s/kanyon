using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class Taint
    {
        /** <summary>Required. The effect of the taint on pods that do not tolerate the taint. Valid effects are NoSchedule, PreferNoSchedule and NoExecute.</summary> */
        public string effect { get; set; }
        /** <summary>Required. The taint key to be applied to a node.</summary> */
        public string key { get; set; }
        /** <summary>Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers.</summary> */
        public Core.V1.Time timeAdded { get; set; }
        /** <summary>The taint value corresponding to the taint key.</summary> */
        public string value { get; set; }
    }
}