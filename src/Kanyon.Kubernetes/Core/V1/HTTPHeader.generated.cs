using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class HTTPHeader
    {
        /** <summary>The header field name</summary> */
        public string name { get; set; }
        /** <summary>The header field value</summary> */
        public string value { get; set; }
    }
}