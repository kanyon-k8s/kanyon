using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class VsphereVirtualDiskVolumeSource
    {
        /** <summary>Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified.</summary> */
        public string fsType { get; set; }
        /** <summary>Storage Policy Based Management (SPBM) profile ID associated with the StoragePolicyName.</summary> */
        public string storagePolicyID { get; set; }
        /** <summary>Storage Policy Based Management (SPBM) profile name.</summary> */
        public string storagePolicyName { get; set; }
        /** <summary>Path that identifies vSphere volume vmdk</summary> */
        public string volumePath { get; set; }
    }
}