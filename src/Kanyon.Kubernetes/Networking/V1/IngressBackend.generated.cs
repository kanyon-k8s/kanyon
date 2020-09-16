using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1
{
    public partial class IngressBackend
    {
        /** <summary>TypedLocalObjectReference contains enough information to let you locate the typed referenced object inside the same namespace.</summary> */
        public Core.V1.TypedLocalObjectReference resource { get; set; }
        /** <summary>IngressServiceBackend references a Kubernetes Service as a Backend.</summary> */
        public Networking.V1.IngressServiceBackend service { get; set; }
    }
}