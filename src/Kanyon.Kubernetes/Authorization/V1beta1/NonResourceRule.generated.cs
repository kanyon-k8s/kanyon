using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Authorization.V1beta1
{
    public partial class NonResourceRule
    {
        /** <summary>NonResourceURLs is a set of partial urls that a user should have access to.  &#42;s are allowed, but only as the full, final step in the path.  "&#42;" means all.</summary> */
        public IEnumerable<string> nonResourceURLs { get; set; }
        /** <summary>Verb is a list of kubernetes non-resource API verbs, like: get, post, put, delete, patch, head, options.  "&#42;" means all.</summary> */
        public IEnumerable<string> verbs { get; set; }
    }
}