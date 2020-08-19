using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Flowcontrol.V1alpha1
{
    public partial class ResourcePolicyRule
    {
        /** <summary>`apiGroups` is a list of matching API groups and may not be empty. "&#42;" matches all API groups and, if present, must be the only entry. Required.</summary> */
        public List<string> apiGroups { get; set; }
        /** <summary>`clusterScope` indicates whether to match requests that do not specify a namespace (which happens either because the resource is not namespaced or the request targets all namespaces). If this field is omitted or false then the `namespaces` field must contain a non-empty list.</summary> */
        public bool clusterScope { get; set; }
        /** <summary>`namespaces` is a list of target namespaces that restricts matches.  A request that specifies a target namespace matches only if either (a) this list contains that target namespace or (b) this list contains "&#42;".  Note that "&#42;" matches any specified namespace but does not match a request that _does not specify_ a namespace (see the `clusterScope` field for that). This list may be empty, but only if `clusterScope` is true.</summary> */
        public List<string> namespaces { get; set; }
        /** <summary>`resources` is a list of matching resources (i.e., lowercase and plural) with, if desired, subresource.  For example, [ "services", "nodes/status" ].  This list may not be empty. "&#42;" matches all resources and, if present, must be the only entry. Required.</summary> */
        public List<string> resources { get; set; }
        /** <summary>`verbs` is a list of matching verbs and may not be empty. "&#42;" matches all verbs and, if present, must be the only entry. Required.</summary> */
        public List<string> verbs { get; set; }
    }
}