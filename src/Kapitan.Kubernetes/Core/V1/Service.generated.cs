using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class Service : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "v1";
        [JsonProperty("kind")]
        public string Kind => "Service";

        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>ServiceSpec describes the attributes that a user creates on a service.</summary> */
        public Core.V1.ServiceSpec spec { get; set; }
        /** <summary>ServiceStatus represents the current status of a service.</summary> */
        public Core.V1.ServiceStatus status { get; set; }
    }
}