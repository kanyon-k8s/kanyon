using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1beta1
{
    public partial class HTTPIngressRuleValue
    {
        /** <summary>A collection of paths that map requests to backends.</summary> */
        public IEnumerable<Networking.V1beta1.HTTPIngressPath> paths { get; set; }
    }
}