using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Apiextensions.V1beta1
{
    public partial class ExternalDocumentation
    {
        /** <summary></summary> */
        public string description { get; set; }
        /** <summary></summary> */
        public string url { get; set; }
    }
}