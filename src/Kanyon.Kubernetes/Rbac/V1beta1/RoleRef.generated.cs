using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Rbac.V1beta1
{
    public partial class RoleRef
    {
        /** <summary>APIGroup is the group for the resource being referenced</summary> */
        public string apiGroup { get; set; }
        /** <summary>Kind is the type of resource being referenced</summary> */
        public string kind { get; set; }
        /** <summary>Name is the name of resource being referenced</summary> */
        public string name { get; set; }
    }
}