using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class CSIPersistentVolumeSource
    {
        /** <summary>SecretReference represents a Secret Reference. It has enough information to retrieve secret in any namespace</summary> */
        public Core.V1.SecretReference controllerExpandSecretRef { get; set; }
        /** <summary>SecretReference represents a Secret Reference. It has enough information to retrieve secret in any namespace</summary> */
        public Core.V1.SecretReference controllerPublishSecretRef { get; set; }
        /** <summary>Driver is the name of the driver to use for this volume. Required.</summary> */
        public string driver { get; set; }
        /** <summary>Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs".</summary> */
        public string fsType { get; set; }
        /** <summary>SecretReference represents a Secret Reference. It has enough information to retrieve secret in any namespace</summary> */
        public Core.V1.SecretReference nodePublishSecretRef { get; set; }
        /** <summary>SecretReference represents a Secret Reference. It has enough information to retrieve secret in any namespace</summary> */
        public Core.V1.SecretReference nodeStageSecretRef { get; set; }
        /** <summary>Optional: The value to pass to ControllerPublishVolumeRequest. Defaults to false (read/write).</summary> */
        public bool readOnly { get; set; }
        /** <summary>Attributes of the volume to publish.</summary> */
        public object volumeAttributes { get; set; }
        /** <summary>VolumeHandle is the unique volume name returned by the CSI volume plugin’s CreateVolume to refer to the volume on all subsequent calls. Required.</summary> */
        public string volumeHandle { get; set; }
    }
}