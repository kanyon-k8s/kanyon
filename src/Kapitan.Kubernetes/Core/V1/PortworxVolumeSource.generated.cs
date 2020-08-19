using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class PortworxVolumeSource
    {
        /** <summary>FSType represents the filesystem type to mount Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs". Implicitly inferred to be "ext4" if unspecified.</summary> */
        public string fsType { get; set; }
        /** <summary>Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.</summary> */
        public bool readOnly { get; set; }
        /** <summary>VolumeID uniquely identifies a Portworx volume</summary> */
        public string volumeID { get; set; }
    }
}