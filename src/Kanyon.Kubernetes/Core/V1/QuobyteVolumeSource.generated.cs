using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class QuobyteVolumeSource
    {
        /** <summary>Group to map volume access to Default is no group</summary> */
        public string group { get; set; }
        /** <summary>ReadOnly here will force the Quobyte volume to be mounted with read-only permissions. Defaults to false.</summary> */
        public bool? readOnly { get; set; }
        /** <summary>Registry represents a single or multiple Quobyte Registry services specified as a string as host:port pair (multiple entries are separated with commas) which acts as the central registry for volumes</summary> */
        public string registry { get; set; }
        /** <summary>Tenant owning the given Quobyte volume in the Backend Used with dynamically provisioned Quobyte volumes, value is set by the plugin</summary> */
        public string tenant { get; set; }
        /** <summary>User to map volume access to Defaults to serivceaccount user</summary> */
        public string user { get; set; }
        /** <summary>Volume is a string that references an already created Quobyte volume by name.</summary> */
        public string volume { get; set; }
    }
}