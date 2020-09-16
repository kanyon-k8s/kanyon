using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class PersistentVolumeClaimSpec
    {
        /** <summary>AccessModes contains the desired access modes the volume should have. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#access-modes-1</summary> */
        public IEnumerable<string> accessModes { get; set; }
        /** <summary>TypedLocalObjectReference contains enough information to let you locate the typed referenced object inside the same namespace.</summary> */
        public Core.V1.TypedLocalObjectReference dataSource { get; set; }
        /** <summary>ResourceRequirements describes the compute resource requirements.</summary> */
        public Core.V1.ResourceRequirements resources { get; set; }
        /** <summary>A label selector is a label query over a set of resources. The result of matchLabels and matchExpressions are ANDed. An empty label selector matches all objects. A null label selector matches no objects.</summary> */
        public Core.V1.LabelSelector selector { get; set; }
        /** <summary>Name of the StorageClass required by the claim. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#class-1</summary> */
        public string storageClassName { get; set; }
        /** <summary>volumeMode defines what type of volume is required by the claim. Value of Filesystem is implied when not included in claim spec.</summary> */
        public string volumeMode { get; set; }
        /** <summary>VolumeName is the binding reference to the PersistentVolume backing this claim.</summary> */
        public string volumeName { get; set; }
    }
}