using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Apiextensions.V1beta1
{
    public partial class ExternalDocumentation
    {
        /** <summary></summary> */
        public string description { get; set; }
        /** <summary></summary> */
        public string url { get; set; }
    }
}