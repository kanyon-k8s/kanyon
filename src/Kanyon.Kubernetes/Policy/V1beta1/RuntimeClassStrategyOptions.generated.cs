using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Policy.V1beta1
{
    public partial class RuntimeClassStrategyOptions
    {
        /** <summary>allowedRuntimeClassNames is an allowlist of RuntimeClass names that may be specified on a pod. A value of "&#42;" means that any RuntimeClass name is allowed, and must be the only item in the list. An empty list requires the RuntimeClassName field to be unset.</summary> */
        public IEnumerable<string> allowedRuntimeClassNames { get; set; }
        /** <summary>defaultRuntimeClassName is the default RuntimeClassName to set on the pod. The default MUST be allowed by the allowedRuntimeClassNames list. A value of nil does not mutate the Pod.</summary> */
        public string defaultRuntimeClassName { get; set; }
    }
}