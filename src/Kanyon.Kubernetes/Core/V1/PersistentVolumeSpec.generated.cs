using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class PersistentVolumeSpec
    {
        /** <summary>AccessModes contains all ways the volume can be mounted. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#access-modes</summary> */
        public IEnumerable<string> accessModes { get; set; }
        /** <summary>Represents a Persistent Disk resource in AWS.

An AWS EBS disk must exist before mounting to a container. The disk must also be in the same AWS zone as the kubelet. An AWS EBS disk can only be mounted as read/write once. AWS EBS volumes support ownership management and SELinux relabeling.</summary> */
        public Core.V1.AWSElasticBlockStoreVolumeSource awsElasticBlockStore { get; set; }
        /** <summary>AzureDisk represents an Azure Data Disk mount on the host and bind mount to the pod.</summary> */
        public Core.V1.AzureDiskVolumeSource azureDisk { get; set; }
        /** <summary>AzureFile represents an Azure File Service mount on the host and bind mount to the pod.</summary> */
        public Core.V1.AzureFilePersistentVolumeSource azureFile { get; set; }
        /** <summary>A description of the persistent volume's resources and capacity. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#capacity</summary> */
        public object capacity { get; set; }
        /** <summary>Represents a Ceph Filesystem mount that lasts the lifetime of a pod Cephfs volumes do not support ownership management or SELinux relabeling.</summary> */
        public Core.V1.CephFSPersistentVolumeSource cephfs { get; set; }
        /** <summary>Represents a cinder volume resource in Openstack. A Cinder volume must exist before mounting to a container. The volume must also be in the same region as the kubelet. Cinder volumes support ownership management and SELinux relabeling.</summary> */
        public Core.V1.CinderPersistentVolumeSource cinder { get; set; }
        /** <summary>ObjectReference contains enough information to let you inspect or modify the referred object.</summary> */
        public Core.V1.ObjectReference claimRef { get; set; }
        /** <summary>Represents storage that is managed by an external CSI volume driver (Beta feature)</summary> */
        public Core.V1.CSIPersistentVolumeSource csi { get; set; }
        /** <summary>Represents a Fibre Channel volume. Fibre Channel volumes can only be mounted as read/write once. Fibre Channel volumes support ownership management and SELinux relabeling.</summary> */
        public Core.V1.FCVolumeSource fc { get; set; }
        /** <summary>FlexPersistentVolumeSource represents a generic persistent volume resource that is provisioned/attached using an exec based plugin.</summary> */
        public Core.V1.FlexPersistentVolumeSource flexVolume { get; set; }
        /** <summary>Represents a Flocker volume mounted by the Flocker agent. One and only one of datasetName and datasetUUID should be set. Flocker volumes do not support ownership management or SELinux relabeling.</summary> */
        public Core.V1.FlockerVolumeSource flocker { get; set; }
        /** <summary>Represents a Persistent Disk resource in Google Compute Engine.

A GCE PD must exist before mounting to a container. The disk must also be in the same GCE project and zone as the kubelet. A GCE PD can only be mounted as read/write once or read-only many times. GCE PDs support ownership management and SELinux relabeling.</summary> */
        public Core.V1.GCEPersistentDiskVolumeSource gcePersistentDisk { get; set; }
        /** <summary>Represents a Glusterfs mount that lasts the lifetime of a pod. Glusterfs volumes do not support ownership management or SELinux relabeling.</summary> */
        public Core.V1.GlusterfsPersistentVolumeSource glusterfs { get; set; }
        /** <summary>Represents a host path mapped into a pod. Host path volumes do not support ownership management or SELinux relabeling.</summary> */
        public Core.V1.HostPathVolumeSource hostPath { get; set; }
        /** <summary>ISCSIPersistentVolumeSource represents an ISCSI disk. ISCSI volumes can only be mounted as read/write once. ISCSI volumes support ownership management and SELinux relabeling.</summary> */
        public Core.V1.ISCSIPersistentVolumeSource iscsi { get; set; }
        /** <summary>Local represents directly-attached storage with node affinity (Beta feature)</summary> */
        public Core.V1.LocalVolumeSource local { get; set; }
        /** <summary>A list of mount options, e.g. ["ro", "soft"]. Not validated - mount will simply fail if one is invalid. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes/#mount-options</summary> */
        public IEnumerable<string> mountOptions { get; set; }
        /** <summary>Represents an NFS mount that lasts the lifetime of a pod. NFS volumes do not support ownership management or SELinux relabeling.</summary> */
        public Core.V1.NFSVolumeSource nfs { get; set; }
        /** <summary>VolumeNodeAffinity defines constraints that limit what nodes this volume can be accessed from.</summary> */
        public Core.V1.VolumeNodeAffinity nodeAffinity { get; set; }
        /** <summary>What happens to a persistent volume when released from its claim. Valid options are Retain (default for manually created PersistentVolumes), Delete (default for dynamically provisioned PersistentVolumes), and Recycle (deprecated). Recycle must be supported by the volume plugin underlying this PersistentVolume. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#reclaiming</summary> */
        public string persistentVolumeReclaimPolicy { get; set; }
        /** <summary>Represents a Photon Controller persistent disk resource.</summary> */
        public Core.V1.PhotonPersistentDiskVolumeSource photonPersistentDisk { get; set; }
        /** <summary>PortworxVolumeSource represents a Portworx volume resource.</summary> */
        public Core.V1.PortworxVolumeSource portworxVolume { get; set; }
        /** <summary>Represents a Quobyte mount that lasts the lifetime of a pod. Quobyte volumes do not support ownership management or SELinux relabeling.</summary> */
        public Core.V1.QuobyteVolumeSource quobyte { get; set; }
        /** <summary>Represents a Rados Block Device mount that lasts the lifetime of a pod. RBD volumes support ownership management and SELinux relabeling.</summary> */
        public Core.V1.RBDPersistentVolumeSource rbd { get; set; }
        /** <summary>ScaleIOPersistentVolumeSource represents a persistent ScaleIO volume</summary> */
        public Core.V1.ScaleIOPersistentVolumeSource scaleIO { get; set; }
        /** <summary>Name of StorageClass to which this persistent volume belongs. Empty value means that this volume does not belong to any StorageClass.</summary> */
        public string storageClassName { get; set; }
        /** <summary>Represents a StorageOS persistent volume resource.</summary> */
        public Core.V1.StorageOSPersistentVolumeSource storageos { get; set; }
        /** <summary>volumeMode defines if a volume is intended to be used with a formatted filesystem or to remain in raw block state. Value of Filesystem is implied when not included in spec.</summary> */
        public string volumeMode { get; set; }
        /** <summary>Represents a vSphere volume resource.</summary> */
        public Core.V1.VsphereVirtualDiskVolumeSource vsphereVolume { get; set; }
    }
}