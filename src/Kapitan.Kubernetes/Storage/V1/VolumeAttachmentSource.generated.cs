using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Storage.V1
{
    public partial class VolumeAttachmentSource
    {
        /** <summary>PersistentVolumeSpec is the specification of a persistent volume.</summary> */
        public Core.V1.PersistentVolumeSpec inlineVolumeSpec { get; set; }
        /** <summary>Name of the persistent volume to attach.</summary> */
        public string persistentVolumeName { get; set; }
    }
}