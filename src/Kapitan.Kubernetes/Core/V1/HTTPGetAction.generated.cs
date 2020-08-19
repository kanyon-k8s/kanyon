using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class HTTPGetAction
    {
        /** <summary>Host name to connect to, defaults to the pod IP. You probably want to set "Host" in httpHeaders instead.</summary> */
        public string host { get; set; }
        /** <summary>Custom headers to set in the request. HTTP allows repeated headers.</summary> */
        public List<Core.V1.HTTPHeader> httpHeaders { get; set; }
        /** <summary>Path to access on the HTTP server.</summary> */
        public string path { get; set; }
        /** <summary>IntOrString is a type that can hold an int32 or a string.  When used in JSON or YAML marshalling and unmarshalling, it produces or consumes the inner type.  This allows you to have, for example, a JSON field that can accept a name or number.</summary> */
        public IntOrString port { get; set; }
        /** <summary>Scheme to use for connecting to the host. Defaults to HTTP.</summary> */
        public string scheme { get; set; }
    }
}