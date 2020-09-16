using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Policy.V1beta1
{
    public partial class RunAsUserStrategyOptions
    {
        /** <summary>ranges are the allowed ranges of uids that may be used. If you would like to force a single uid then supply a single range with the same start and end. Required for MustRunAs.</summary> */
        public IEnumerable<Policy.V1beta1.IDRange> ranges { get; set; }
        /** <summary>rule is the strategy that will dictate the allowable RunAsUser values that may be set.</summary> */
        public string rule { get; set; }
    }
}