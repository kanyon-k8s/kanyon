using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class AzureDiskVolumeSource
    {
        /** <summary>Host Caching mode: None, Read Only, Read Write.</summary> */
        public string cachingMode { get; set; }
        /** <summary>The Name of the data disk in the blob storage</summary> */
        public string diskName { get; set; }
        /** <summary>The URI the data disk in the blob storage</summary> */
        public string diskURI { get; set; }
        /** <summary>Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified.</summary> */
        public string fsType { get; set; }
        /** <summary>Expected values Shared: multiple blob disks per storage account  Dedicated: single blob disk per storage account  Managed: azure managed data disk (only in managed availability set). defaults to shared</summary> */
        public string kind { get; set; }
        /** <summary>Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.</summary> */
        public bool readOnly { get; set; }
    }
}