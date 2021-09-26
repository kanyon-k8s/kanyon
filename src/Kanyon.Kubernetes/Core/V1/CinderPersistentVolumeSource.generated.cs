using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class CinderPersistentVolumeSource
    {
        /** <summary>Filesystem type to mount. Must be a filesystem type supported by the host operating system. Examples: "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified. More info: https://examples.k8s.io/mysql-cinder-pd/README.md</summary> */
        public string fsType { get; set; }
        /** <summary>Optional: Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts. More info: https://examples.k8s.io/mysql-cinder-pd/README.md</summary> */
        public bool? readOnly { get; set; }
        /** <summary>SecretReference represents a Secret Reference. It has enough information to retrieve secret in any namespace</summary> */
        public Core.V1.SecretReference secretRef { get; set; }
        /** <summary>volume id used to identify the volume in cinder. More info: https://examples.k8s.io/mysql-cinder-pd/README.md</summary> */
        public string volumeID { get; set; }
    }
}