using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1
{
    public partial class IngressServiceBackend
    {
        /** <summary>Name is the referenced service. The service must exist in the same namespace as the Ingress object.</summary> */
        public string name { get; set; }
        /** <summary>ServiceBackendPort is the service port being referenced.</summary> */
        public Networking.V1.ServiceBackendPort port { get; set; }
    }
}