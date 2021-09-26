using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Networking.V1
{
    public partial class HTTPIngressPath
    {
        /** <summary>IngressBackend describes all endpoints for a given service and port.</summary> */
        public Networking.V1.IngressBackend backend { get; set; }
        /** <summary>Path is matched against the path of an incoming request. Currently it can contain characters disallowed from the conventional "path" part of a URL as defined by RFC 3986. Paths must begin with a '/' and must be present when using PathType with value "Exact" or "Prefix".</summary> */
        public string path { get; set; }
        /** <summary>PathType determines the interpretation of the Path matching. PathType can be one of the following values: &#42; Exact: Matches the URL path exactly. &#42; Prefix: Matches based on a URL path prefix split by '/'. Matching is
  done on a path element by element basis. A path element refers is the
  list of labels in the path split by the '/' separator. A request is a
  match for path p if every p is an element-wise prefix of p of the
  request path. Note that if the last element of the path is a substring
  of the last element in request path, it is not a match (e.g. /foo/bar
  matches /foo/bar/baz, but does not match /foo/barbaz).
&#42; ImplementationSpecific: Interpretation of the Path matching is up to
  the IngressClass. Implementations can treat this as a separate PathType
  or treat it identically to Prefix or Exact path types.
Implementations are required to support all path types.</summary> */
        public string pathType { get; set; }
    }
}