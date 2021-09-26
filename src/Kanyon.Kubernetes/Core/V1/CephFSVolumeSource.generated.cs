using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class CephFSVolumeSource
    {
        /** <summary>Required: Monitors is a collection of Ceph monitors More info: https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it</summary> */
        public IEnumerable<string> monitors { get; set; }
        /** <summary>Optional: Used as the mounted root, rather than the full Ceph tree, default is /</summary> */
        public string path { get; set; }
        /** <summary>Optional: Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts. More info: https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it</summary> */
        public bool? readOnly { get; set; }
        /** <summary>Optional: SecretFile is the path to key ring for User, default is /etc/ceph/user.secret More info: https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it</summary> */
        public string secretFile { get; set; }
        /** <summary>LocalObjectReference contains enough information to let you locate the referenced object inside the same namespace.</summary> */
        public Core.V1.LocalObjectReference secretRef { get; set; }
        /** <summary>Optional: User is the rados user name, default is admin More info: https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it</summary> */
        public string user { get; set; }
    }
}