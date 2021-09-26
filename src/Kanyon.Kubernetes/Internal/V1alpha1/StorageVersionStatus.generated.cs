using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Internal.V1alpha1
{
    public partial class StorageVersionStatus
    {
        /** <summary>If all API server instances agree on the same encoding storage version, then this field is set to that version. Otherwise this field is left empty. API servers should finish updating its storageVersionStatus entry before serving write operations, so that this field will be in sync with the reality.</summary> */
        public string commonEncodingVersion { get; set; }
        /** <summary>The latest available observations of the storageVersion's state.</summary> */
        public IEnumerable<Internal.V1alpha1.StorageVersionCondition> conditions { get; set; }
        /** <summary>The reported versions per API server instance.</summary> */
        public IEnumerable<Internal.V1alpha1.ServerStorageVersion> storageVersions { get; set; }
    }
}