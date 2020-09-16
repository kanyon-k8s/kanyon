using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Core;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Storage.V1
{
    public partial class StorageClass : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "storage.k8s.io/v1";
        [JsonProperty("kind")]
        public string Kind => "StorageClass";

        /** <summary>AllowVolumeExpansion shows whether the storage class allow volume expand</summary> */
        public bool allowVolumeExpansion { get; set; }
        /** <summary>Restrict the node topologies where volumes can be dynamically provisioned. Each volume plugin defines its own supported topology specifications. An empty TopologySelectorTerm list means there is no topology restriction. This field is only honored by servers that enable the VolumeScheduling feature.</summary> */
        public IEnumerable<Core.V1.TopologySelectorTerm> allowedTopologies { get; set; }
        /** <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary> */
        public string apiVersion { get; set; }
        /** <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary> */
        public string kind { get; set; }
        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>Dynamically provisioned PersistentVolumes of this storage class are created with these mountOptions, e.g. ["ro", "soft"]. Not validated - mount of the PVs will simply fail if one is invalid.</summary> */
        public IEnumerable<string> mountOptions { get; set; }
        /** <summary>Parameters holds the parameters for the provisioner that should create volumes of this storage class.</summary> */
        public object parameters { get; set; }
        /** <summary>Provisioner indicates the type of the provisioner.</summary> */
        public string provisioner { get; set; }
        /** <summary>Dynamically provisioned PersistentVolumes of this storage class are created with this reclaimPolicy. Defaults to Delete.</summary> */
        public string reclaimPolicy { get; set; }
        /** <summary>VolumeBindingMode indicates how PersistentVolumeClaims should be provisioned and bound.  When unset, VolumeBindingImmediate is used. This field is only honored by servers that enable the VolumeScheduling feature.</summary> */
        public string volumeBindingMode { get; set; }
    }
}