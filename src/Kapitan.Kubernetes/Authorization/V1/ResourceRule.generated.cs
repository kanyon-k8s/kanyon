using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Authorization.V1
{
    public partial class ResourceRule
    {
        /** <summary>APIGroups is the name of the APIGroup that contains the resources.  If multiple API groups are specified, any action requested against one of the enumerated resources in any API group will be allowed.  "&#42;" means all.</summary> */
        public List<string> apiGroups { get; set; }
        /** <summary>ResourceNames is an optional white list of names that the rule applies to.  An empty set means that everything is allowed.  "&#42;" means all.</summary> */
        public List<string> resourceNames { get; set; }
        /** <summary>Resources is a list of resources this rule applies to.  "&#42;" means all in the specified apiGroups.
 "&#42;/foo" represents the subresource 'foo' for all resources in the specified apiGroups.</summary> */
        public List<string> resources { get; set; }
        /** <summary>Verb is a list of kubernetes resource API verbs, like: get, list, watch, create, update, delete, proxy.  "&#42;" means all.</summary> */
        public List<string> verbs { get; set; }
    }
}