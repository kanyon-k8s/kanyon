using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class FlockerVolumeSource
    {
        /** <summary>Name of the dataset stored as metadata -> name on the dataset for Flocker should be considered as deprecated</summary> */
        public string datasetName { get; set; }
        /** <summary>UUID of the dataset. This is unique identifier of a Flocker dataset</summary> */
        public string datasetUUID { get; set; }
    }
}