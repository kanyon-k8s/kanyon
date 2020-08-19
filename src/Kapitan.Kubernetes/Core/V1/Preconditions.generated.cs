using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class Preconditions
    {
        /** <summary>Specifies the target ResourceVersion</summary> */
        public string resourceVersion { get; set; }
        /** <summary>Specifies the target UID.</summary> */
        public string uid { get; set; }
    }
}