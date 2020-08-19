using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Policy.V1beta1
{
    public partial class SELinuxStrategyOptions
    {
        /** <summary>rule is the strategy that will dictate the allowable labels that may be set.</summary> */
        public string rule { get; set; }
        /** <summary>SELinuxOptions are the labels to be applied to the container</summary> */
        public Core.V1.SELinuxOptions seLinuxOptions { get; set; }
    }
}