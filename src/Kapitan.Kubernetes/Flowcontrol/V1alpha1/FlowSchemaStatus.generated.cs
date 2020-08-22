using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Flowcontrol.V1alpha1
{
    public partial class FlowSchemaStatus
    {
        /** <summary>`conditions` is a list of the current states of FlowSchema.</summary> */
        public IEnumerable<Flowcontrol.V1alpha1.FlowSchemaCondition> conditions { get; set; }
    }
}