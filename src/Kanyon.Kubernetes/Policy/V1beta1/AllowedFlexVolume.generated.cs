using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Policy.V1beta1
{
    public partial class AllowedFlexVolume
    {
        /** <summary>driver is the name of the Flexvolume driver.</summary> */
        public string driver { get; set; }
    }
}