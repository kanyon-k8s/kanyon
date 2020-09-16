using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class EnvVarSource
    {
        /** <summary>Selects a key from a ConfigMap.</summary> */
        public Core.V1.ConfigMapKeySelector configMapKeyRef { get; set; }
        /** <summary>ObjectFieldSelector selects an APIVersioned field of an object.</summary> */
        public Core.V1.ObjectFieldSelector fieldRef { get; set; }
        /** <summary>ResourceFieldSelector represents container resources (cpu, memory) and their output format</summary> */
        public Core.V1.ResourceFieldSelector resourceFieldRef { get; set; }
        /** <summary>SecretKeySelector selects a key of a Secret.</summary> */
        public Core.V1.SecretKeySelector secretKeyRef { get; set; }
    }
}