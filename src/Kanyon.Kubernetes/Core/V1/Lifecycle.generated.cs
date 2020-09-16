using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class Lifecycle
    {
        /** <summary>Handler defines a specific action that should be taken</summary> */
        public Core.V1.Handler postStart { get; set; }
        /** <summary>Handler defines a specific action that should be taken</summary> */
        public Core.V1.Handler preStop { get; set; }
    }
}