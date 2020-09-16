using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Rbac.V1alpha1
{
    public partial class Role : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "rbac.authorization.k8s.io/v1alpha1";
        [JsonProperty("kind")]
        public string Kind => "Role";

        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>Rules holds all the PolicyRules for this Role</summary> */
        public IEnumerable<Rbac.V1alpha1.PolicyRule> rules { get; set; }
    }
}