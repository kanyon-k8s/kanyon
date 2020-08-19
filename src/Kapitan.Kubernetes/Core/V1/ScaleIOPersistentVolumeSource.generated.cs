using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class ScaleIOPersistentVolumeSource
    {
        /** <summary>Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". Default is "xfs"</summary> */
        public string fsType { get; set; }
        /** <summary>The host address of the ScaleIO API Gateway.</summary> */
        public string gateway { get; set; }
        /** <summary>The name of the ScaleIO Protection Domain for the configured storage.</summary> */
        public string protectionDomain { get; set; }
        /** <summary>Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.</summary> */
        public bool readOnly { get; set; }
        /** <summary>SecretReference represents a Secret Reference. It has enough information to retrieve secret in any namespace</summary> */
        public Core.V1.SecretReference secretRef { get; set; }
        /** <summary>Flag to enable/disable SSL communication with Gateway, default false</summary> */
        public bool sslEnabled { get; set; }
        /** <summary>Indicates whether the storage for a volume should be ThickProvisioned or ThinProvisioned. Default is ThinProvisioned.</summary> */
        public string storageMode { get; set; }
        /** <summary>The ScaleIO Storage Pool associated with the protection domain.</summary> */
        public string storagePool { get; set; }
        /** <summary>The name of the storage system as configured in ScaleIO.</summary> */
        public string system { get; set; }
        /** <summary>The name of a volume already created in the ScaleIO system that is associated with this volume source.</summary> */
        public string volumeName { get; set; }
    }
}