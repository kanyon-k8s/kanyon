using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Rbac.V1
{
    public partial class RoleBinding : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "rbac.authorization.k8s.io/v1";
        [JsonProperty("kind")]
        public string Kind => "RoleBinding";

        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>RoleRef contains information that points to the role being used</summary> */
        public Rbac.V1.RoleRef roleRef { get; set; }
        /** <summary>Subjects holds references to the objects the role applies to.</summary> */
        public List<Rbac.V1.Subject> subjects { get; set; }
    }
}