using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Core;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Apps.V1
{
    public partial class Deployment : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "apps/v1";
        [JsonProperty("kind")]
        public string Kind => "Deployment";

        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>DeploymentSpec is the specification of the desired behavior of the Deployment.</summary> */
        public Apps.V1.DeploymentSpec spec { get; set; }
        /** <summary>DeploymentStatus is the most recently observed status of the Deployment.</summary> */
        public Apps.V1.DeploymentStatus status { get; set; }
    }
}