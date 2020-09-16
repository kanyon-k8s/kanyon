using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class PersistentVolumeStatus
    {
        /** <summary>A human-readable message indicating details about why the volume is in this state.</summary> */
        public string message { get; set; }
        /** <summary>Phase indicates if a volume is available, bound to a claim, or released by a claim. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#phase</summary> */
        public string phase { get; set; }
        /** <summary>Reason is a brief CamelCase string that describes any failure and is meant for machine parsing and tidy display in the CLI.</summary> */
        public string reason { get; set; }
    }
}