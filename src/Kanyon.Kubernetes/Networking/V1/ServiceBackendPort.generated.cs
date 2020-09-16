using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Networking.V1
{
    public partial class ServiceBackendPort
    {
        /** <summary>Name is the name of the port on the Service. This is a mutually exclusive setting with "Number".</summary> */
        public string name { get; set; }
        /** <summary>Number is the numerical port number (e.g. 80) on the Service. This is a mutually exclusive setting with "Name".</summary> */
        public int number { get; set; }
    }
}