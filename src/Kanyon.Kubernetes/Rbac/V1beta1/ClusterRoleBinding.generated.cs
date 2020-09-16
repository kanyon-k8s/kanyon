using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Core;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Rbac.V1beta1
{
    public partial class ClusterRoleBinding : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "rbac.authorization.k8s.io/v1beta1";
        [JsonProperty("kind")]
        public string Kind => "ClusterRoleBinding";

        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>RoleRef contains information that points to the role being used</summary> */
        public Rbac.V1beta1.RoleRef roleRef { get; set; }
        /** <summary>Subjects holds references to the objects the role applies to.</summary> */
        public IEnumerable<Rbac.V1beta1.Subject> subjects { get; set; }
    }
}