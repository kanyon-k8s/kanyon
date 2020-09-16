using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Core;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Node.V1alpha1
{
    public partial class RuntimeClass : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "node.k8s.io/v1alpha1";
        [JsonProperty("kind")]
        public string Kind => "RuntimeClass";

        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>RuntimeClassSpec is a specification of a RuntimeClass. It contains parameters that are required to describe the RuntimeClass to the Container Runtime Interface (CRI) implementation, as well as any other components that need to understand how the pod will be run. The RuntimeClassSpec is immutable.</summary> */
        public Node.V1alpha1.RuntimeClassSpec spec { get; set; }
    }
}