using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class Volume
    {
        /** <summary>Represents a Persistent Disk resource in AWS.

An AWS EBS disk must exist before mounting to a container. The disk must also be in the same AWS zone as the kubelet. An AWS EBS disk can only be mounted as read/write once. AWS EBS volumes support ownership management and SELinux relabeling.</summary> */
        public Core.V1.AWSElasticBlockStoreVolumeSource awsElasticBlockStore { get; set; }
        /** <summary>AzureDisk represents an Azure Data Disk mount on the host and bind mount to the pod.</summary> */
        public Core.V1.AzureDiskVolumeSource azureDisk { get; set; }
        /** <summary>AzureFile represents an Azure File Service mount on the host and bind mount to the pod.</summary> */
        public Core.V1.AzureFileVolumeSource azureFile { get; set; }
        /** <summary>Represents a Ceph Filesystem mount that lasts the lifetime of a pod Cephfs volumes do not support ownership management or SELinux relabeling.</summary> */
        public Core.V1.CephFSVolumeSource cephfs { get; set; }
        /** <summary>Represents a cinder volume resource in Openstack. A Cinder volume must exist before mounting to a container. The volume must also be in the same region as the kubelet. Cinder volumes support ownership management and SELinux relabeling.</summary> */
        public Core.V1.CinderVolumeSource cinder { get; set; }
        /** <summary>Adapts a ConfigMap into a volume.

The contents of the target ConfigMap's Data field will be presented in a volume as files using the keys in the Data field as the file names, unless the items element is populated with specific mappings of keys to paths. ConfigMap volumes support ownership management and SELinux relabeling.</summary> */
        public Core.V1.ConfigMapVolumeSource configMap { get; set; }
        /** <summary>Represents a source location of a volume to mount, managed by an external CSI driver</summary> */
        public Core.V1.CSIVolumeSource csi { get; set; }
        /** <summary>DownwardAPIVolumeSource represents a volume containing downward API info. Downward API volumes support ownership management and SELinux relabeling.</summary> */
        public Core.V1.DownwardAPIVolumeSource downwardAPI { get; set; }
        /** <summary>Represents an empty directory for a pod. Empty directory volumes support ownership management and SELinux relabeling.</summary> */
        public Core.V1.EmptyDirVolumeSource emptyDir { get; set; }
        /** <summary>Represents an ephemeral volume that is handled by a normal storage driver.</summary> */
        public Core.V1.EphemeralVolumeSource ephemeral { get; set; }
        /** <summary>Represents a Fibre Channel volume. Fibre Channel volumes can only be mounted as read/write once. Fibre Channel volumes support ownership management and SELinux relabeling.</summary> */
        public Core.V1.FCVolumeSource fc { get; set; }
        /** <summary>FlexVolume represents a generic volume resource that is provisioned/attached using an exec based plugin.</summary> */
        public Core.V1.FlexVolumeSource flexVolume { get; set; }
        /** <summary>Represents a Flocker volume mounted by the Flocker agent. One and only one of datasetName and datasetUUID should be set. Flocker volumes do not support ownership management or SELinux relabeling.</summary> */
        public Core.V1.FlockerVolumeSource flocker { get; set; }
        /** <summary>Represents a Persistent Disk resource in Google Compute Engine.

A GCE PD must exist before mounting to a container. The disk must also be in the same GCE project and zone as the kubelet. A GCE PD can only be mounted as read/write once or read-only many times. GCE PDs support ownership management and SELinux relabeling.</summary> */
        public Core.V1.GCEPersistentDiskVolumeSource gcePersistentDisk { get; set; }
        /** <summary>Represents a volume that is populated with the contents of a git repository. Git repo volumes do not support ownership management. Git repo volumes support SELinux relabeling.

DEPRECATED: GitRepo is deprecated. To provision a container with a git repo, mount an EmptyDir into an InitContainer that clones the repo using git, then mount the EmptyDir into the Pod's container.</summary> */
        public Core.V1.GitRepoVolumeSource gitRepo { get; set; }
        /** <summary>Represents a Glusterfs mount that lasts the lifetime of a pod. Glusterfs volumes do not support ownership management or SELinux relabeling.</summary> */
        public Core.V1.GlusterfsVolumeSource glusterfs { get; set; }
        /** <summary>Represents a host path mapped into a pod. Host path volumes do not support ownership management or SELinux relabeling.</summary> */
        public Core.V1.HostPathVolumeSource hostPath { get; set; }
        /** <summary>Represents an ISCSI disk. ISCSI volumes can only be mounted as read/write once. ISCSI volumes support ownership management and SELinux relabeling.</summary> */
        public Core.V1.ISCSIVolumeSource iscsi { get; set; }
        /** <summary>Volume's name. Must be a DNS_LABEL and unique within the pod. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary> */
        public string name { get; set; }
        /** <summary>Represents an NFS mount that lasts the lifetime of a pod. NFS volumes do not support ownership management or SELinux relabeling.</summary> */
        public Core.V1.NFSVolumeSource nfs { get; set; }
        /** <summary>PersistentVolumeClaimVolumeSource references the user's PVC in the same namespace. This volume finds the bound PV and mounts that volume for the pod. A PersistentVolumeClaimVolumeSource is, essentially, a wrapper around another type of volume that is owned by someone else (the system).</summary> */
        public Core.V1.PersistentVolumeClaimVolumeSource persistentVolumeClaim { get; set; }
        /** <summary>Represents a Photon Controller persistent disk resource.</summary> */
        public Core.V1.PhotonPersistentDiskVolumeSource photonPersistentDisk { get; set; }
        /** <summary>PortworxVolumeSource represents a Portworx volume resource.</summary> */
        public Core.V1.PortworxVolumeSource portworxVolume { get; set; }
        /** <summary>Represents a projected volume source</summary> */
        public Core.V1.ProjectedVolumeSource projected { get; set; }
        /** <summary>Represents a Quobyte mount that lasts the lifetime of a pod. Quobyte volumes do not support ownership management or SELinux relabeling.</summary> */
        public Core.V1.QuobyteVolumeSource quobyte { get; set; }
        /** <summary>Represents a Rados Block Device mount that lasts the lifetime of a pod. RBD volumes support ownership management and SELinux relabeling.</summary> */
        public Core.V1.RBDVolumeSource rbd { get; set; }
        /** <summary>ScaleIOVolumeSource represents a persistent ScaleIO volume</summary> */
        public Core.V1.ScaleIOVolumeSource scaleIO { get; set; }
        /** <summary>Adapts a Secret into a volume.

The contents of the target Secret's Data field will be presented in a volume as files using the keys in the Data field as the file names. Secret volumes support ownership management and SELinux relabeling.</summary> */
        public Core.V1.SecretVolumeSource secret { get; set; }
        /** <summary>Represents a StorageOS persistent volume resource.</summary> */
        public Core.V1.StorageOSVolumeSource storageos { get; set; }
        /** <summary>Represents a vSphere volume resource.</summary> */
        public Core.V1.VsphereVirtualDiskVolumeSource vsphereVolume { get; set; }
    }
}