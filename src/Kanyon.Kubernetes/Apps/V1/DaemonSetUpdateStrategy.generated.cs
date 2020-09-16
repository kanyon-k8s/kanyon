using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Apps.V1
{
    public partial class DaemonSetUpdateStrategy
    {
        /** <summary>Spec to control the desired behavior of daemon set rolling update.</summary> */
        public Apps.V1.RollingUpdateDaemonSet rollingUpdate { get; set; }
        /** <summary>Type of daemon set update. Can be "RollingUpdate" or "OnDelete". Default is RollingUpdate.</summary> */
        public string type { get; set; }
    }
}