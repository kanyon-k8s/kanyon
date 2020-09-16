using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class FlexVolumeSource
    {
        /** <summary>Driver is the name of the driver to use for this volume.</summary> */
        public string driver { get; set; }
        /** <summary>Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". The default filesystem depends on FlexVolume script.</summary> */
        public string fsType { get; set; }
        /** <summary>Optional: Extra command options if any.</summary> */
        public object options { get; set; }
        /** <summary>Optional: Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.</summary> */
        public bool readOnly { get; set; }
        /** <summary>LocalObjectReference contains enough information to let you locate the referenced object inside the same namespace.</summary> */
        public Core.V1.LocalObjectReference secretRef { get; set; }
    }
}