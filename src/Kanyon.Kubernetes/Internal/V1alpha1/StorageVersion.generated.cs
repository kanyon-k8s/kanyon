using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Core;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Internal.V1alpha1
{
    public partial class StorageVersion : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "internal.apiserver.k8s.io/v1alpha1";
        [JsonProperty("kind")]
        public string Kind => "StorageVersion";

        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>StorageVersionSpec is an empty spec.</summary> */
        public Internal.V1alpha1.StorageVersionSpec spec { get; set; }
        /** <summary>API server instances report the versions they can decode and the version they encode objects to when persisting objects in the backend.</summary> */
        public Internal.V1alpha1.StorageVersionStatus status { get; set; }
    }
}