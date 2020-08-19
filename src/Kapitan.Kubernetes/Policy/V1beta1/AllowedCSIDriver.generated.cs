using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Policy.V1beta1
{
    public partial class AllowedCSIDriver
    {
        /** <summary>Name is the registered name of the CSI driver</summary> */
        public string name { get; set; }
    }
}