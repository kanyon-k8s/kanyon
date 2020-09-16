using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Scheduling.V1beta1
{
    public partial class PriorityClass : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "scheduling.k8s.io/v1beta1";
        [JsonProperty("kind")]
        public string Kind => "PriorityClass";

        /** <summary>description is an arbitrary string that usually provides guidelines on when this priority class should be used.</summary> */
        public string description { get; set; }
        /** <summary>globalDefault specifies whether this PriorityClass should be considered as the default priority for pods that do not have any priority class. Only one PriorityClass can be marked as `globalDefault`. However, if more than one PriorityClasses exists with their `globalDefault` field set to true, the smallest value of such global default PriorityClasses will be used as the default priority.</summary> */
        public bool globalDefault { get; set; }
        /** <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary> */
        public string kind { get; set; }
        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>PreemptionPolicy is the Policy for preempting pods with lower priority. One of Never, PreemptLowerPriority. Defaults to PreemptLowerPriority if unset. This field is beta-level, gated by the NonPreemptingPriority feature-gate.</summary> */
        public string preemptionPolicy { get; set; }
        /** <summary>The value of this priority class. This is the actual priority that pods receive when they have the name of this class in their pod spec.</summary> */
        public int value { get; set; }
    }
}