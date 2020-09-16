using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class Preconditions
    {
        /** <summary>Specifies the target ResourceVersion</summary> */
        public string resourceVersion { get; set; }
        /** <summary>Specifies the target UID.</summary> */
        public string uid { get; set; }
    }
}