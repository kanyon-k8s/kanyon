using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Flowcontrol.V1alpha1
{
    public partial class FlowSchema : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "flowcontrol.apiserver.k8s.io/v1alpha1";
        [JsonProperty("kind")]
        public string Kind => "FlowSchema";

        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>FlowSchemaSpec describes how the FlowSchema's specification looks like.</summary> */
        public Flowcontrol.V1alpha1.FlowSchemaSpec spec { get; set; }
        /** <summary>FlowSchemaStatus represents the current state of a FlowSchema.</summary> */
        public Flowcontrol.V1alpha1.FlowSchemaStatus status { get; set; }
    }
}