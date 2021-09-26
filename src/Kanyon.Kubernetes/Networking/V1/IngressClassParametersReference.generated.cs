using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Networking.V1
{
    public partial class IngressClassParametersReference
    {
        /** <summary>APIGroup is the group for the resource being referenced. If APIGroup is not specified, the specified Kind must be in the core API group. For any other third-party types, APIGroup is required.</summary> */
        public string apiGroup { get; set; }
        /** <summary>Kind is the type of resource being referenced.</summary> */
        public string kind { get; set; }
        /** <summary>Name is the name of resource being referenced.</summary> */
        public string name { get; set; }
        /** <summary>Namespace is the namespace of the resource being referenced. This field is required when scope is set to "Namespace" and must be unset when scope is set to "Cluster".</summary> */
        public string @namespace { get; set; }
        /** <summary>Scope represents if this refers to a cluster or namespace scoped resource. This may be set to "Cluster" (default) or "Namespace". Field can be enabled with IngressClassNamespacedParams feature gate.</summary> */
        public string scope { get; set; }
    }
}