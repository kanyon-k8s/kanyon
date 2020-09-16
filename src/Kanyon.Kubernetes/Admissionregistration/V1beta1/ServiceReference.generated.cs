using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Admissionregistration.V1beta1
{
    public partial class ServiceReference
    {
        /** <summary>`name` is the name of the service. Required</summary> */
        public string name { get; set; }
        /** <summary>`namespace` is the namespace of the service. Required</summary> */
        public string @namespace { get; set; }
        /** <summary>`path` is an optional URL path which will be sent in any request to this service.</summary> */
        public string path { get; set; }
        /** <summary>If specified, the port on the service that hosting webhook. Default to 443 for backward compatibility. `port` should be a valid port number (1-65535, inclusive).</summary> */
        public int port { get; set; }
    }
}