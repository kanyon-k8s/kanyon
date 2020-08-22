using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Policy.V1beta1
{
    public partial class SupplementalGroupsStrategyOptions
    {
        /** <summary>ranges are the allowed ranges of supplemental groups.  If you would like to force a single supplemental group then supply a single range with the same start and end. Required for MustRunAs.</summary> */
        public IEnumerable<Policy.V1beta1.IDRange> ranges { get; set; }
        /** <summary>rule is the strategy that will dictate what supplemental groups is used in the SecurityContext.</summary> */
        public string rule { get; set; }
    }
}