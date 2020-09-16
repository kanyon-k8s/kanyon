using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Extensions.V1beta1
{
    public partial class IngressBackend
    {
        /** <summary>TypedLocalObjectReference contains enough information to let you locate the typed referenced object inside the same namespace.</summary> */
        public Core.V1.TypedLocalObjectReference resource { get; set; }
        /** <summary>Specifies the name of the referenced service.</summary> */
        public string serviceName { get; set; }
        /** <summary>IntOrString is a type that can hold an int32 or a string.  When used in JSON or YAML marshalling and unmarshalling, it produces or consumes the inner type.  This allows you to have, for example, a JSON field that can accept a name or number.</summary> */
        public IntOrString servicePort { get; set; }
    }
}