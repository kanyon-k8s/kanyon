using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Flowcontrol.V1alpha1
{
    public partial class NonResourcePolicyRule
    {
        /** <summary>`nonResourceURLs` is a set of url prefixes that a user should have access to and may not be empty. For example:
  - "/healthz" is legal
  - "/hea&#42;" is illegal
  - "/hea" is legal but matches nothing
  - "/hea/&#42;" also matches nothing
  - "/healthz/&#42;" matches all per-component health checks.
"&#42;" matches all non-resource urls. if it is present, it must be the only entry. Required.</summary> */
        public IEnumerable<string> nonResourceURLs { get; set; }
        /** <summary>`verbs` is a list of matching verbs and may not be empty. "&#42;" matches all verbs. If it is present, it must be the only entry. Required.</summary> */
        public IEnumerable<string> verbs { get; set; }
    }
}