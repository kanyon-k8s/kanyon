using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1
{
    public partial class HTTPIngressRuleValue
    {
        /** <summary>A collection of paths that map requests to backends.</summary> */
        public List<Networking.V1.HTTPIngressPath> paths { get; set; }
    }
}