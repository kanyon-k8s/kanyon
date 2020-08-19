using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Rbac.V1
{
    public partial class PolicyRule
    {
        /** <summary>APIGroups is the name of the APIGroup that contains the resources.  If multiple API groups are specified, any action requested against one of the enumerated resources in any API group will be allowed.</summary> */
        public List<string> apiGroups { get; set; }
        /** <summary>NonResourceURLs is a set of partial urls that a user should have access to.  &#42;s are allowed, but only as the full, final step in the path Since non-resource URLs are not namespaced, this field is only applicable for ClusterRoles referenced from a ClusterRoleBinding. Rules can either apply to API resources (such as "pods" or "secrets") or non-resource URL paths (such as "/api"),  but not both.</summary> */
        public List<string> nonResourceURLs { get; set; }
        /** <summary>ResourceNames is an optional white list of names that the rule applies to.  An empty set means that everything is allowed.</summary> */
        public List<string> resourceNames { get; set; }
        /** <summary>Resources is a list of resources this rule applies to.  ResourceAll represents all resources.</summary> */
        public List<string> resources { get; set; }
        /** <summary>Verbs is a list of Verbs that apply to ALL the ResourceKinds and AttributeRestrictions contained in this rule.  VerbAll represents all kinds.</summary> */
        public List<string> verbs { get; set; }
    }
}