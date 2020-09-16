using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class LocalVolumeSource
    {
        /** <summary>Filesystem type to mount. It applies only when the Path is a block device. Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". The default value is to auto-select a fileystem if unspecified.</summary> */
        public string fsType { get; set; }
        /** <summary>The full path to the volume on the node. It can be either a directory or block device (disk, partition, ...).</summary> */
        public string path { get; set; }
    }
}