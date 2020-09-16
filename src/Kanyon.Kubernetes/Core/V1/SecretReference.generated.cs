using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class SecretReference
    {
        /** <summary>Name is unique within a namespace to reference a secret resource.</summary> */
        public string name { get; set; }
        /** <summary>Namespace defines the space within which the secret name must be unique.</summary> */
        public string @namespace { get; set; }
    }
}