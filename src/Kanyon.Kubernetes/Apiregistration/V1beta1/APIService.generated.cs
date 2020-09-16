using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Apiregistration.V1beta1
{
    public partial class APIService : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "apiregistration.k8s.io/v1beta1";
        [JsonProperty("kind")]
        public string Kind => "APIService";

        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>APIServiceSpec contains information for locating and communicating with a server. Only https is supported, though you are able to disable certificate verification.</summary> */
        public Apiregistration.V1beta1.APIServiceSpec spec { get; set; }
        /** <summary>APIServiceStatus contains derived information about an API server</summary> */
        public Apiregistration.V1beta1.APIServiceStatus status { get; set; }
    }
}