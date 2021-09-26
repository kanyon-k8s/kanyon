using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class PersistentVolumeClaimVolumeSource
    {
        /** <summary>ClaimName is the name of a PersistentVolumeClaim in the same namespace as the pod using this volume. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#persistentvolumeclaims</summary> */
        public string claimName { get; set; }
        /** <summary>Will force the ReadOnly setting in VolumeMounts. Default false.</summary> */
        public bool? readOnly { get; set; }
    }
}