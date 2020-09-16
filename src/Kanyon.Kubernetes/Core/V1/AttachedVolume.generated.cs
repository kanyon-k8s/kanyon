using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class AttachedVolume
    {
        /** <summary>DevicePath represents the device path where the volume should be available</summary> */
        public string devicePath { get; set; }
        /** <summary>Name of the attached volume</summary> */
        public string name { get; set; }
    }
}