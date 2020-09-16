using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Apps.V1
{
    public partial class StatefulSet : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "apps/v1";
        [JsonProperty("kind")]
        public string Kind => "StatefulSet";

        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>A StatefulSetSpec is the specification of a StatefulSet.</summary> */
        public Apps.V1.StatefulSetSpec spec { get; set; }
        /** <summary>StatefulSetStatus represents the current state of a StatefulSet.</summary> */
        public Apps.V1.StatefulSetStatus status { get; set; }
    }
}