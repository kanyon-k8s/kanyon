using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class EphemeralVolumeSource
    {
        /** <summary>PersistentVolumeClaimTemplate is used to produce PersistentVolumeClaim objects as part of an EphemeralVolumeSource.</summary> */
        public Core.V1.PersistentVolumeClaimTemplate volumeClaimTemplate { get; set; }
    }
}