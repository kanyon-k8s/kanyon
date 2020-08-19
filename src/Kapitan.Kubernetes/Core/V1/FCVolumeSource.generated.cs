using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class FCVolumeSource
    {
        /** <summary>Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified.</summary> */
        public string fsType { get; set; }
        /** <summary>Optional: FC target lun number</summary> */
        public int lun { get; set; }
        /** <summary>Optional: Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.</summary> */
        public bool readOnly { get; set; }
        /** <summary>Optional: FC target worldwide names (WWNs)</summary> */
        public List<string> targetWWNs { get; set; }
        /** <summary>Optional: FC volume world wide identifiers (wwids) Either wwids or combination of targetWWNs and lun must be set, but not both simultaneously.</summary> */
        public List<string> wwids { get; set; }
    }
}