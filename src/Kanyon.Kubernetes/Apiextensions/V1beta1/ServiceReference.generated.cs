using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Apiextensions.V1beta1
{
    public partial class ServiceReference
    {
        /** <summary>name is the name of the service. Required</summary> */
        public string name { get; set; }
        /** <summary>namespace is the namespace of the service. Required</summary> */
        public string @namespace { get; set; }
        /** <summary>path is an optional URL path at which the webhook will be contacted.</summary> */
        public string path { get; set; }
        /** <summary>port is an optional service port at which the webhook will be contacted. `port` should be a valid port number (1-65535, inclusive). Defaults to 443 for backward compatibility.</summary> */
        public int port { get; set; }
    }
}