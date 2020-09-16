using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Apps.V1
{
    public partial class StatefulSetUpdateStrategy
    {
        /** <summary>RollingUpdateStatefulSetStrategy is used to communicate parameter for RollingUpdateStatefulSetStrategyType.</summary> */
        public Apps.V1.RollingUpdateStatefulSetStrategy rollingUpdate { get; set; }
        /** <summary>Type indicates the type of the StatefulSetUpdateStrategy. Default is RollingUpdate.</summary> */
        public string type { get; set; }
    }
}