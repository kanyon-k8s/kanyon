using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Extensions.V1beta1
{
    public partial class HTTPIngressRuleValue
    {
        /** <summary>A collection of paths that map requests to backends.</summary> */
        public IEnumerable<Extensions.V1beta1.HTTPIngressPath> paths { get; set; }
    }
}