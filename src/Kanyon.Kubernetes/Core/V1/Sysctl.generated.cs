using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class Sysctl
    {
        /** <summary>Name of a property to set</summary> */
        public string name { get; set; }
        /** <summary>Value of a property to set</summary> */
        public string value { get; set; }
    }
}