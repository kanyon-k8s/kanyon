using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Policy.V1beta1
{
    public partial class AllowedHostPath
    {
        /** <summary>pathPrefix is the path prefix that the host volume must match. It does not support `&#42;`. Trailing slashes are trimmed when validating the path prefix with a host path.

Examples: `/foo` would allow `/foo`, `/foo/` and `/foo/bar` `/foo` would not allow `/food` or `/etc/foo`</summary> */
        public string pathPrefix { get; set; }
        /** <summary>when set to true, will allow host volumes matching the pathPrefix only if all volume mounts are readOnly.</summary> */
        public bool readOnly { get; set; }
    }
}