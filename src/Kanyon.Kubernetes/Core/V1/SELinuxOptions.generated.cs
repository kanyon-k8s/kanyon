using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class SELinuxOptions
    {
        /** <summary>Level is SELinux level label that applies to the container.</summary> */
        public string level { get; set; }
        /** <summary>Role is a SELinux role label that applies to the container.</summary> */
        public string role { get; set; }
        /** <summary>Type is a SELinux type label that applies to the container.</summary> */
        public string type { get; set; }
        /** <summary>User is a SELinux user label that applies to the container.</summary> */
        public string user { get; set; }
    }
}