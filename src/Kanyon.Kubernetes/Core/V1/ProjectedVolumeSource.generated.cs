using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class ProjectedVolumeSource
    {
        /** <summary>Mode bits used to set permissions on created files by default. Must be an octal value between 0000 and 0777 or a decimal value between 0 and 511. YAML accepts both octal and decimal values, JSON requires decimal values for mode bits. Directories within the path are not affected by this setting. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.</summary> */
        public int defaultMode { get; set; }
        /** <summary>list of volume projections</summary> */
        public IEnumerable<Core.V1.VolumeProjection> sources { get; set; }
    }
}