using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Flowcontrol.V1beta2
{
    public partial class FlowDistinguisherMethod
    {
        /** <summary>`type` is the type of flow distinguisher method The supported types are "ByUser" and "ByNamespace". Required.</summary> */
        public string type { get; set; }
    }
}