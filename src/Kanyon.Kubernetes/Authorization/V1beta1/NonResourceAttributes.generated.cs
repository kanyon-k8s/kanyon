using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Authorization.V1beta1
{
    public partial class NonResourceAttributes
    {
        /** <summary>Path is the URL path of the request</summary> */
        public string path { get; set; }
        /** <summary>Verb is the standard HTTP verb</summary> */
        public string verb { get; set; }
    }
}