using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class CSIVolumeSource
    {
        /** <summary>Driver is the name of the CSI driver that handles this volume. Consult with your admin for the correct name as registered in the cluster.</summary> */
        public string driver { get; set; }
        /** <summary>Filesystem type to mount. Ex. "ext4", "xfs", "ntfs". If not provided, the empty value is passed to the associated CSI driver which will determine the default filesystem to apply.</summary> */
        public string fsType { get; set; }
        /** <summary>LocalObjectReference contains enough information to let you locate the referenced object inside the same namespace.</summary> */
        public Core.V1.LocalObjectReference nodePublishSecretRef { get; set; }
        /** <summary>Specifies a read-only configuration for the volume. Defaults to false (read/write).</summary> */
        public bool? readOnly { get; set; }
        /** <summary>VolumeAttributes stores driver-specific properties that are passed to the CSI driver. Consult your driver's documentation for supported values.</summary> */
        public object volumeAttributes { get; set; }
    }
}