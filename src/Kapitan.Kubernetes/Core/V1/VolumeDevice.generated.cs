using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class VolumeDevice
    {
        /** <summary>devicePath is the path inside of the container that the device will be mapped to.</summary> */
        public string devicePath { get; set; }
        /** <summary>name must match the name of a persistentVolumeClaim in the pod</summary> */
        public string name { get; set; }
    }
}