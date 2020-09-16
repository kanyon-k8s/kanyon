using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class DownwardAPIProjection
    {
        /** <summary>Items is a list of DownwardAPIVolume file</summary> */
        public IEnumerable<Core.V1.DownwardAPIVolumeFile> items { get; set; }
    }
}