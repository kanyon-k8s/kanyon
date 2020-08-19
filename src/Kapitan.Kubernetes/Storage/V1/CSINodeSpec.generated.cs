using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Storage.V1
{
    public partial class CSINodeSpec
    {
        /** <summary>drivers is a list of information of all CSI Drivers existing on a node. If all drivers in the list are uninstalled, this can become empty.</summary> */
        public List<Storage.V1.CSINodeDriver> drivers { get; set; }
    }
}