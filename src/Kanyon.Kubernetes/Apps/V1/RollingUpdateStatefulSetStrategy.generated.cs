using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Apps.V1
{
    public partial class RollingUpdateStatefulSetStrategy
    {
        /** <summary>Partition indicates the ordinal at which the StatefulSet should be partitioned. Default value is 0.</summary> */
        public int partition { get; set; }
    }
}