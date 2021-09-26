using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Flowcontrol.V1beta2
{
    public partial class FlowSchemaStatus
    {
        /** <summary>`conditions` is a list of the current states of FlowSchema.</summary> */
        public IEnumerable<Flowcontrol.V1beta2.FlowSchemaCondition> conditions { get; set; }
    }
}