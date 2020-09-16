using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Storage.V1beta1
{
    public partial class VolumeError
    {
        /** <summary>String detailing the error encountered during Attach or Detach operation. This string may be logged, so it should not contain sensitive information.</summary> */
        public string message { get; set; }
        /** <summary>Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers.</summary> */
        public Core.V1.Time time { get; set; }
    }
}