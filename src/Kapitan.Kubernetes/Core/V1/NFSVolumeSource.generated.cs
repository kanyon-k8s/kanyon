using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class NFSVolumeSource
    {
        /** <summary>Path that is exported by the NFS server. More info: https://kubernetes.io/docs/concepts/storage/volumes#nfs</summary> */
        public string path { get; set; }
        /** <summary>ReadOnly here will force the NFS export to be mounted with read-only permissions. Defaults to false. More info: https://kubernetes.io/docs/concepts/storage/volumes#nfs</summary> */
        public bool readOnly { get; set; }
        /** <summary>Server is the hostname or IP address of the NFS server. More info: https://kubernetes.io/docs/concepts/storage/volumes#nfs</summary> */
        public string server { get; set; }
    }
}