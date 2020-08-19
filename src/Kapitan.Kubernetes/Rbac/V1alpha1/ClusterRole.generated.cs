using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Rbac.V1alpha1
{
    public partial class ClusterRole : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "rbac.authorization.k8s.io/v1alpha1";
        [JsonProperty("kind")]
        public string Kind => "ClusterRole";

        /** <summary>AggregationRule describes how to locate ClusterRoles to aggregate into the ClusterRole</summary> */
        public Rbac.V1alpha1.AggregationRule aggregationRule { get; set; }
        /** <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary> */
        public string apiVersion { get; set; }
        /** <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary> */
        public string kind { get; set; }
        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>Rules holds all the PolicyRules for this ClusterRole</summary> */
        public List<Rbac.V1alpha1.PolicyRule> rules { get; set; }
    }
}