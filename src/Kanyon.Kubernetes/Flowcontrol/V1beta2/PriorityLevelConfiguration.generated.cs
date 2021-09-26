using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Core;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Flowcontrol.V1beta2
{
    public partial class PriorityLevelConfiguration : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "flowcontrol.apiserver.k8s.io/v1beta2";
        [JsonProperty("kind")]
        public string Kind => "PriorityLevelConfiguration";

        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>PriorityLevelConfigurationSpec specifies the configuration of a priority level.</summary> */
        public Flowcontrol.V1beta2.PriorityLevelConfigurationSpec spec { get; set; }
        /** <summary>PriorityLevelConfigurationStatus represents the current state of a "request-priority".</summary> */
        public Flowcontrol.V1beta2.PriorityLevelConfigurationStatus status { get; set; }
    }
}