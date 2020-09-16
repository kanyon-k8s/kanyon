using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class ConfigMapNodeConfigSource
    {
        /** <summary>KubeletConfigKey declares which key of the referenced ConfigMap corresponds to the KubeletConfiguration structure This field is required in all cases.</summary> */
        public string kubeletConfigKey { get; set; }
        /** <summary>Name is the metadata.name of the referenced ConfigMap. This field is required in all cases.</summary> */
        public string name { get; set; }
        /** <summary>Namespace is the metadata.namespace of the referenced ConfigMap. This field is required in all cases.</summary> */
        public string @namespace { get; set; }
        /** <summary>ResourceVersion is the metadata.ResourceVersion of the referenced ConfigMap. This field is forbidden in Node.Spec, and required in Node.Status.</summary> */
        public string resourceVersion { get; set; }
        /** <summary>UID is the metadata.UID of the referenced ConfigMap. This field is forbidden in Node.Spec, and required in Node.Status.</summary> */
        public string uid { get; set; }
    }
}