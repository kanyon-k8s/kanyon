using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Storage.V1
{
    public partial class VolumeAttachmentSpec
    {
        /** <summary>Attacher indicates the name of the volume driver that MUST handle this request. This is the name returned by GetPluginName().</summary> */
        public string attacher { get; set; }
        /** <summary>The node that the volume should be attached to.</summary> */
        public string nodeName { get; set; }
        /** <summary>VolumeAttachmentSource represents a volume that should be attached. Right now only PersistenVolumes can be attached via external attacher, in future we may allow also inline volumes in pods. Exactly one member can be set.</summary> */
        public Storage.V1.VolumeAttachmentSource source { get; set; }
    }
}