using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class TypedLocalObjectReference
    {
        /** <summary>APIGroup is the group for the resource being referenced. If APIGroup is not specified, the specified Kind must be in the core API group. For any other third-party types, APIGroup is required.</summary> */
        public string apiGroup { get; set; }
        /** <summary>Kind is the type of resource being referenced</summary> */
        public string kind { get; set; }
        /** <summary>Name is the name of resource being referenced</summary> */
        public string name { get; set; }
    }
}