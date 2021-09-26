using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Internal.V1alpha1
{
    public partial class ServerStorageVersion
    {
        /** <summary>The ID of the reporting API server.</summary> */
        public string apiServerID { get; set; }
        /** <summary>The API server can decode objects encoded in these versions. The encodingVersion must be included in the decodableVersions.</summary> */
        public IEnumerable<string> decodableVersions { get; set; }
        /** <summary>The API server encodes the object to this version when persisting it in the backend (e.g., etcd).</summary> */
        public string encodingVersion { get; set; }
    }
}