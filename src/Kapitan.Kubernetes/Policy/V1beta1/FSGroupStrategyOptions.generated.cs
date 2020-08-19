using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Policy.V1beta1
{
    public partial class FSGroupStrategyOptions
    {
        /** <summary>ranges are the allowed ranges of fs groups.  If you would like to force a single fs group then supply a single range with the same start and end. Required for MustRunAs.</summary> */
        public List<Policy.V1beta1.IDRange> ranges { get; set; }
        /** <summary>rule is the strategy that will dictate what FSGroup is used in the SecurityContext.</summary> */
        public string rule { get; set; }
    }
}