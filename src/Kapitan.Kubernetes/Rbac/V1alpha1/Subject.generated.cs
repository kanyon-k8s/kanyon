using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Rbac.V1alpha1
{
    public partial class Subject
    {
        /** <summary>APIVersion holds the API group and version of the referenced subject. Defaults to "v1" for ServiceAccount subjects. Defaults to "rbac.authorization.k8s.io/v1alpha1" for User and Group subjects.</summary> */
        public string apiVersion { get; set; }
        /** <summary>Kind of object being referenced. Values defined by this API group are "User", "Group", and "ServiceAccount". If the Authorizer does not recognized the kind value, the Authorizer should report an error.</summary> */
        public string kind { get; set; }
        /** <summary>Name of the object being referenced.</summary> */
        public string name { get; set; }
        /** <summary>Namespace of the referenced object.  If the object kind is non-namespace, such as "User" or "Group", and this value is not empty the Authorizer should report an error.</summary> */
        public string @namespace { get; set; }
    }
}