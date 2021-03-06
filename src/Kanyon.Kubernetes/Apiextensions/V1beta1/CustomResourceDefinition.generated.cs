using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Core;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Apiextensions.V1beta1
{
    public partial class CustomResourceDefinition : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "apiextensions.k8s.io/v1beta1";
        [JsonProperty("kind")]
        public string Kind => "CustomResourceDefinition";

        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>CustomResourceDefinitionSpec describes how a user wants their resource to appear</summary> */
        public Apiextensions.V1beta1.CustomResourceDefinitionSpec spec { get; set; }
        /** <summary>CustomResourceDefinitionStatus indicates the state of the CustomResourceDefinition</summary> */
        public Apiextensions.V1beta1.CustomResourceDefinitionStatus status { get; set; }
    }
}