using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class Capabilities
    {
        /** <summary>Added capabilities</summary> */
        public IEnumerable<string> add { get; set; }
        /** <summary>Removed capabilities</summary> */
        public IEnumerable<string> drop { get; set; }
    }
}