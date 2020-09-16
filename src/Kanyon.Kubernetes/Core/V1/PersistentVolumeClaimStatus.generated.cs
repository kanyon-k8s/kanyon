using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class PersistentVolumeClaimStatus
    {
        /** <summary>AccessModes contains the actual access modes the volume backing the PVC has. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#access-modes-1</summary> */
        public IEnumerable<string> accessModes { get; set; }
        /** <summary>Represents the actual resources of the underlying volume.</summary> */
        public object capacity { get; set; }
        /** <summary>Current Condition of persistent volume claim. If underlying persistent volume is being resized then the Condition will be set to 'ResizeStarted'.</summary> */
        public IEnumerable<Core.V1.PersistentVolumeClaimCondition> conditions { get; set; }
        /** <summary>Phase represents the current phase of PersistentVolumeClaim.</summary> */
        public string phase { get; set; }
    }
}