using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Core;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Storage.V1alpha1
{
    public partial class VolumeAttachment : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "storage.k8s.io/v1alpha1";
        [JsonProperty("kind")]
        public string Kind => "VolumeAttachment";

        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>VolumeAttachmentSpec is the specification of a VolumeAttachment request.</summary> */
        public Storage.V1alpha1.VolumeAttachmentSpec spec { get; set; }
        /** <summary>VolumeAttachmentStatus is the status of a VolumeAttachment request.</summary> */
        public Storage.V1alpha1.VolumeAttachmentStatus status { get; set; }
    }
}