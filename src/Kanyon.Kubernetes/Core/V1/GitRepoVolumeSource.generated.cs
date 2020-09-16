using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class GitRepoVolumeSource
    {
        /** <summary>Target directory name. Must not contain or start with '..'.  If '.' is supplied, the volume directory will be the git repository.  Otherwise, if specified, the volume will contain the git repository in the subdirectory with the given name.</summary> */
        public string directory { get; set; }
        /** <summary>Repository URL</summary> */
        public string repository { get; set; }
        /** <summary>Commit hash for the specified revision.</summary> */
        public string revision { get; set; }
    }
}