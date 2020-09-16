using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class PersistentVolumeClaimTemplate
    {
        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>PersistentVolumeClaimSpec describes the common attributes of storage devices and allows a Source for provider-specific attributes</summary> */
        public Core.V1.PersistentVolumeClaimSpec spec { get; set; }
    }
}