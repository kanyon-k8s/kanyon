using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class StorageOSVolumeSource
    {
        /** <summary>Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified.</summary> */
        public string fsType { get; set; }
        /** <summary>Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.</summary> */
        public bool? readOnly { get; set; }
        /** <summary>LocalObjectReference contains enough information to let you locate the referenced object inside the same namespace.</summary> */
        public Core.V1.LocalObjectReference secretRef { get; set; }
        /** <summary>VolumeName is the human-readable name of the StorageOS volume.  Volume names are only unique within a namespace.</summary> */
        public string volumeName { get; set; }
        /** <summary>VolumeNamespace specifies the scope of the volume within StorageOS.  If no namespace is specified then the Pod's namespace will be used.  This allows the Kubernetes name scoping to be mirrored within StorageOS for tighter integration. Set VolumeName to any name to override the default behaviour. Set to "default" if you are not using namespaces within StorageOS. Namespaces that do not pre-exist within StorageOS will be created.</summary> */
        public string volumeNamespace { get; set; }
    }
}