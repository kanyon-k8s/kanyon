using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class EnvFromSource
    {
        /** <summary>ConfigMapEnvSource selects a ConfigMap to populate the environment variables with.

The contents of the target ConfigMap's Data field will represent the key-value pairs as environment variables.</summary> */
        public Core.V1.ConfigMapEnvSource configMapRef { get; set; }
        /** <summary>An optional identifier to prepend to each key in the ConfigMap. Must be a C_IDENTIFIER.</summary> */
        public string prefix { get; set; }
        /** <summary>SecretEnvSource selects a Secret to populate the environment variables with.

The contents of the target Secret's Data field will represent the key-value pairs as environment variables.</summary> */
        public Core.V1.SecretEnvSource secretRef { get; set; }
    }
}