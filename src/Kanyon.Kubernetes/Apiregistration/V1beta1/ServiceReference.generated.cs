using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Apiregistration.V1beta1
{
    public partial class ServiceReference
    {
        /** <summary>Name is the name of the service</summary> */
        public string name { get; set; }
        /** <summary>Namespace is the namespace of the service</summary> */
        public string @namespace { get; set; }
        /** <summary>If specified, the port on the service that hosting webhook. Default to 443 for backward compatibility. `port` should be a valid port number (1-65535, inclusive).</summary> */
        public int port { get; set; }
    }
}