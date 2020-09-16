using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Flowcontrol.V1alpha1
{
    public partial class FlowDistinguisherMethod
    {
        /** <summary>`type` is the type of flow distinguisher method The supported types are "ByUser" and "ByNamespace". Required.</summary> */
        public string type { get; set; }
    }
}