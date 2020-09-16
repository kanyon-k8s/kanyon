using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class VolumeProjection
    {
        /** <summary>Adapts a ConfigMap into a projected volume.

The contents of the target ConfigMap's Data field will be presented in a projected volume as files using the keys in the Data field as the file names, unless the items element is populated with specific mappings of keys to paths. Note that this is identical to a configmap volume source without the default mode.</summary> */
        public Core.V1.ConfigMapProjection configMap { get; set; }
        /** <summary>Represents downward API info for projecting into a projected volume. Note that this is identical to a downwardAPI volume source without the default mode.</summary> */
        public Core.V1.DownwardAPIProjection downwardAPI { get; set; }
        /** <summary>Adapts a secret into a projected volume.

The contents of the target Secret's Data field will be presented in a projected volume as files using the keys in the Data field as the file names. Note that this is identical to a secret volume source without the default mode.</summary> */
        public Core.V1.SecretProjection secret { get; set; }
        /** <summary>ServiceAccountTokenProjection represents a projected service account token volume. This projection can be used to insert a service account token into the pods runtime filesystem for use against APIs (Kubernetes API Server or otherwise).</summary> */
        public Core.V1.ServiceAccountTokenProjection serviceAccountToken { get; set; }
    }
}