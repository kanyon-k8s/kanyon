using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class NodeConfigSource
    {
        /** <summary>ConfigMapNodeConfigSource contains the information to reference a ConfigMap as a config source for the Node.</summary> */
        public Core.V1.ConfigMapNodeConfigSource configMap { get; set; }
    }
}