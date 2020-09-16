using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class APIGroup : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "v1";
        [JsonProperty("kind")]
        public string Kind => "APIGroup";

        /** <summary>name is the name of the group.</summary> */
        public string name { get; set; }
        /** <summary>GroupVersion contains the "group/version" and "version" string of a version. It is made a struct to keep extensibility.</summary> */
        public Core.V1.GroupVersionForDiscovery preferredVersion { get; set; }
        /** <summary>a map of client CIDR to server address that is serving this group. This is to help clients reach servers in the most network-efficient way possible. Clients can use the appropriate server address as per the CIDR that they match. In case of multiple matches, clients should use the longest matching CIDR. The server returns only those CIDRs that it thinks that the client can match. For example: the master will return an internal IP CIDR only, if the client reaches the server using an internal IP. Server looks at X-Forwarded-For header or X-Real-Ip header or request.RemoteAddr (in that order) to get the client IP.</summary> */
        public IEnumerable<Core.V1.ServerAddressByClientCIDR> serverAddressByClientCIDRs { get; set; }
        /** <summary>versions are the versions supported in this group.</summary> */
        public IEnumerable<Core.V1.GroupVersionForDiscovery> versions { get; set; }
    }
}