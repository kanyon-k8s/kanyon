using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Autoscaling.V1
{
    public partial class ScaleStatus
    {
        /** <summary>actual number of observed instances of the scaled object.</summary> */
        public int replicas { get; set; }
        /** <summary>label query over pods that should match the replicas count. This is same as the label selector but in the string format to avoid introspection by clients. The string will be in the same format as the query-param syntax. More info about label selectors: http://kubernetes.io/docs/user-guide/labels#label-selectors</summary> */
        public string selector { get; set; }
    }
}