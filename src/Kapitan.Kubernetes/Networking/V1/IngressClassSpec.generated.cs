using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1
{
    public partial class IngressClassSpec
    {
        /** <summary>Controller refers to the name of the controller that should handle this class. This allows for different "flavors" that are controlled by the same controller. For example, you may have different Parameters for the same implementing controller. This should be specified as a domain-prefixed path no more than 250 characters in length, e.g. "acme.io/ingress-controller". This field is immutable.</summary> */
        public string controller { get; set; }
        /** <summary>TypedLocalObjectReference contains enough information to let you locate the typed referenced object inside the same namespace.</summary> */
        public Core.V1.TypedLocalObjectReference parameters { get; set; }
    }
}