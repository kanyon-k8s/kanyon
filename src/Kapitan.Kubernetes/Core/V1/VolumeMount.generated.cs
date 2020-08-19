using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class VolumeMount
    {
        /** <summary>Path within the container at which the volume should be mounted.  Must not contain ':'.</summary> */
        public string mountPath { get; set; }
        /** <summary>mountPropagation determines how mounts are propagated from the host to container and the other way around. When not set, MountPropagationNone is used. This field is beta in 1.10.</summary> */
        public string mountPropagation { get; set; }
        /** <summary>This must match the Name of a Volume.</summary> */
        public string name { get; set; }
        /** <summary>Mounted read-only if true, read-write otherwise (false or unspecified). Defaults to false.</summary> */
        public bool readOnly { get; set; }
        /** <summary>Path within the volume from which the container's volume should be mounted. Defaults to "" (volume's root).</summary> */
        public string subPath { get; set; }
        /** <summary>Expanded path within the volume from which the container's volume should be mounted. Behaves similarly to SubPath but environment variable references $(VAR_NAME) are expanded using the container's environment. Defaults to "" (volume's root). SubPathExpr and SubPath are mutually exclusive.</summary> */
        public string subPathExpr { get; set; }
    }
}