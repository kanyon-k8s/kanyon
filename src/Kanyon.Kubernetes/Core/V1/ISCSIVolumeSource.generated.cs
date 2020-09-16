using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class ISCSIVolumeSource
    {
        /** <summary>whether support iSCSI Discovery CHAP authentication</summary> */
        public bool chapAuthDiscovery { get; set; }
        /** <summary>whether support iSCSI Session CHAP authentication</summary> */
        public bool chapAuthSession { get; set; }
        /** <summary>Filesystem type of the volume that you want to mount. Tip: Ensure that the filesystem type is supported by the host operating system. Examples: "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified. More info: https://kubernetes.io/docs/concepts/storage/volumes#iscsi</summary> */
        public string fsType { get; set; }
        /** <summary>Custom iSCSI Initiator Name. If initiatorName is specified with iscsiInterface simultaneously, new iSCSI interface <target portal>:<volume name> will be created for the connection.</summary> */
        public string initiatorName { get; set; }
        /** <summary>Target iSCSI Qualified Name.</summary> */
        public string iqn { get; set; }
        /** <summary>iSCSI Interface Name that uses an iSCSI transport. Defaults to 'default' (tcp).</summary> */
        public string iscsiInterface { get; set; }
        /** <summary>iSCSI Target Lun number.</summary> */
        public int lun { get; set; }
        /** <summary>iSCSI Target Portal List. The portal is either an IP or ip_addr:port if the port is other than default (typically TCP ports 860 and 3260).</summary> */
        public IEnumerable<string> portals { get; set; }
        /** <summary>ReadOnly here will force the ReadOnly setting in VolumeMounts. Defaults to false.</summary> */
        public bool readOnly { get; set; }
        /** <summary>LocalObjectReference contains enough information to let you locate the referenced object inside the same namespace.</summary> */
        public Core.V1.LocalObjectReference secretRef { get; set; }
        /** <summary>iSCSI Target Portal. The Portal is either an IP or ip_addr:port if the port is other than default (typically TCP ports 860 and 3260).</summary> */
        public string targetPortal { get; set; }
    }
}