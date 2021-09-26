using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class AzureFileVolumeSource
    {
        /** <summary>Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.</summary> */
        public bool? readOnly { get; set; }
        /** <summary>the name of secret that contains Azure Storage Account Name and Key</summary> */
        public string secretName { get; set; }
        /** <summary>Share Name</summary> */
        public string shareName { get; set; }
    }
}