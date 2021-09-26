using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class ConfigMapEnvSource
    {
        /** <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary> */
        public string name { get; set; }
        /** <summary>Specify whether the ConfigMap must be defined</summary> */
        public bool? optional { get; set; }
    }
}