using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Core;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Apps.V1
{
    public partial class DaemonSet : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "apps/v1";
        [JsonProperty("kind")]
        public string Kind => "DaemonSet";

        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>DaemonSetSpec is the specification of a daemon set.</summary> */
        public Apps.V1.DaemonSetSpec spec { get; set; }
        /** <summary>DaemonSetStatus represents the current status of a daemon set.</summary> */
        public Apps.V1.DaemonSetStatus status { get; set; }
    }
}