using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class RBDVolumeSource
    {
        /** <summary>Filesystem type of the volume that you want to mount. Tip: Ensure that the filesystem type is supported by the host operating system. Examples: "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified. More info: https://kubernetes.io/docs/concepts/storage/volumes#rbd</summary> */
        public string fsType { get; set; }
        /** <summary>The rados image name. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it</summary> */
        public string image { get; set; }
        /** <summary>Keyring is the path to key ring for RBDUser. Default is /etc/ceph/keyring. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it</summary> */
        public string keyring { get; set; }
        /** <summary>A collection of Ceph monitors. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it</summary> */
        public IEnumerable<string> monitors { get; set; }
        /** <summary>The rados pool name. Default is rbd. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it</summary> */
        public string pool { get; set; }
        /** <summary>ReadOnly here will force the ReadOnly setting in VolumeMounts. Defaults to false. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it</summary> */
        public bool? readOnly { get; set; }
        /** <summary>LocalObjectReference contains enough information to let you locate the referenced object inside the same namespace.</summary> */
        public Core.V1.LocalObjectReference secretRef { get; set; }
        /** <summary>The rados user name. Default is admin. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it</summary> */
        public string user { get; set; }
    }
}