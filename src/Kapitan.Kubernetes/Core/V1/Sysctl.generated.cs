using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class Sysctl
    {
        /** <summary>Name of a property to set</summary> */
        public string name { get; set; }
        /** <summary>Value of a property to set</summary> */
        public string value { get; set; }
    }
}