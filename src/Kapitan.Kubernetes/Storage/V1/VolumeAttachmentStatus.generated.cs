using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Storage.V1
{
    public partial class VolumeAttachmentStatus
    {
        /** <summary>VolumeError captures an error encountered during a volume operation.</summary> */
        public Storage.V1.VolumeError attachError { get; set; }
        /** <summary>Indicates the volume is successfully attached. This field must only be set by the entity completing the attach operation, i.e. the external-attacher.</summary> */
        public bool attached { get; set; }
        /** <summary>Upon successful attach, this field is populated with any information returned by the attach operation that must be passed into subsequent WaitForAttach or Mount calls. This field must only be set by the entity completing the attach operation, i.e. the external-attacher.</summary> */
        public object attachmentMetadata { get; set; }
        /** <summary>VolumeError captures an error encountered during a volume operation.</summary> */
        public Storage.V1.VolumeError detachError { get; set; }
    }
}