using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Admissionregistration.V1beta1
{
    public partial class RuleWithOperations
    {
        /** <summary>APIGroups is the API groups the resources belong to. '&#42;' is all groups. If '&#42;' is present, the length of the slice must be one. Required.</summary> */
        public IEnumerable<string> apiGroups { get; set; }
        /** <summary>APIVersions is the API versions the resources belong to. '&#42;' is all versions. If '&#42;' is present, the length of the slice must be one. Required.</summary> */
        public IEnumerable<string> apiVersions { get; set; }
        /** <summary>Operations is the operations the admission hook cares about - CREATE, UPDATE, DELETE, CONNECT or &#42; for all of those operations and any future admission operations that are added. If '&#42;' is present, the length of the slice must be one. Required.</summary> */
        public IEnumerable<string> operations { get; set; }
        /** <summary>Resources is a list of resources this rule applies to.

For example: 'pods' means pods. 'pods/log' means the log subresource of pods. '&#42;' means all resources, but not subresources. 'pods/&#42;' means all subresources of pods. '&#42;/scale' means all scale subresources. '&#42;/&#42;' means all resources and their subresources.

If wildcard is present, the validation rule will ensure resources do not overlap with each other.

Depending on the enclosing object, subresources might not be allowed. Required.</summary> */
        public IEnumerable<string> resources { get; set; }
        /** <summary>scope specifies the scope of this rule. Valid values are "Cluster", "Namespaced", and "&#42;" "Cluster" means that only cluster-scoped resources will match this rule. Namespace API objects are cluster-scoped. "Namespaced" means that only namespaced resources will match this rule. "&#42;" means that there are no scope restrictions. Subresources match the scope of their parent resource. Default is "&#42;".</summary> */
        public string scope { get; set; }
    }
}