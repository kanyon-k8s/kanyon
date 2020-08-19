using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class Capabilities
    {
        /** <summary>Added capabilities</summary> */
        public List<string> add { get; set; }
        /** <summary>Removed capabilities</summary> */
        public List<string> drop { get; set; }
    }
}