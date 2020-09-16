using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Authorization.V1
{
    public partial class ResourceAttributes
    {
        /** <summary>Group is the API Group of the Resource.  "&#42;" means all.</summary> */
        public string group { get; set; }
        /** <summary>Name is the name of the resource being requested for a "get" or deleted for a "delete". "" (empty) means all.</summary> */
        public string name { get; set; }
        /** <summary>Namespace is the namespace of the action being requested.  Currently, there is no distinction between no namespace and all namespaces "" (empty) is defaulted for LocalSubjectAccessReviews "" (empty) is empty for cluster-scoped resources "" (empty) means "all" for namespace scoped resources from a SubjectAccessReview or SelfSubjectAccessReview</summary> */
        public string @namespace { get; set; }
        /** <summary>Resource is one of the existing resource types.  "&#42;" means all.</summary> */
        public string resource { get; set; }
        /** <summary>Subresource is one of the existing resource types.  "" means none.</summary> */
        public string subresource { get; set; }
        /** <summary>Verb is a kubernetes resource API verb, like: get, list, watch, create, update, delete, proxy.  "&#42;" means all.</summary> */
        public string verb { get; set; }
        /** <summary>Version is the API Version of the Resource.  "&#42;" means all.</summary> */
        public string version { get; set; }
    }
}