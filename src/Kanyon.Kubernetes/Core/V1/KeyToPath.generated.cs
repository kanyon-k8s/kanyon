using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class KeyToPath
    {
        /** <summary>The key to project.</summary> */
        public string key { get; set; }
        /** <summary>Optional: mode bits used to set permissions on this file. Must be an octal value between 0000 and 0777 or a decimal value between 0 and 511. YAML accepts both octal and decimal values, JSON requires decimal values for mode bits. If not specified, the volume defaultMode will be used. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.</summary> */
        public int mode { get; set; }
        /** <summary>The relative path of the file to map the key to. May not be an absolute path. May not contain the path element '..'. May not start with the string '..'.</summary> */
        public string path { get; set; }
    }
}