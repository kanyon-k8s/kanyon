using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Core;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Discovery.V1
{
    public partial class EndpointSlice : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "discovery.k8s.io/v1";
        [JsonProperty("kind")]
        public string Kind => "EndpointSlice";

        /** <summary>addressType specifies the type of address carried by this EndpointSlice. All addresses in this slice must be the same type. This field is immutable after creation. The following address types are currently supported: &#42; IPv4: Represents an IPv4 Address. &#42; IPv6: Represents an IPv6 Address. &#42; FQDN: Represents a Fully Qualified Domain Name.</summary> */
        public string addressType { get; set; }
        /** <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary> */
        public string apiVersion { get; set; }
        /** <summary>endpoints is a list of unique endpoints in this slice. Each slice may include a maximum of 1000 endpoints.</summary> */
        public IEnumerable<Discovery.V1.Endpoint> endpoints { get; set; }
        /** <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary> */
        public string kind { get; set; }
        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>ports specifies the list of network ports exposed by each endpoint in this slice. Each port must have a unique name. When ports is empty, it indicates that there are no defined ports. When a port is defined with a nil port value, it indicates "all ports". Each slice may include a maximum of 100 ports.</summary> */
        public IEnumerable<Discovery.V1.EndpointPort> ports { get; set; }
    }
}