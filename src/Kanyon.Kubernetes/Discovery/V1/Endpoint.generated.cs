using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Discovery.V1
{
    public partial class Endpoint
    {
        /** <summary>addresses of this endpoint. The contents of this field are interpreted according to the corresponding EndpointSlice addressType field. Consumers must handle different types of addresses in the context of their own capabilities. This must contain at least one address but no more than 100.</summary> */
        public IEnumerable<string> addresses { get; set; }
        /** <summary>EndpointConditions represents the current condition of an endpoint.</summary> */
        public Discovery.V1.EndpointConditions conditions { get; set; }
        /** <summary>deprecatedTopology contains topology information part of the v1beta1 API. This field is deprecated, and will be removed when the v1beta1 API is removed (no sooner than kubernetes v1.24).  While this field can hold values, it is not writable through the v1 API, and any attempts to write to it will be silently ignored. Topology information can be found in the zone and nodeName fields instead.</summary> */
        public object deprecatedTopology { get; set; }
        /** <summary>EndpointHints provides hints describing how an endpoint should be consumed.</summary> */
        public Discovery.V1.EndpointHints hints { get; set; }
        /** <summary>hostname of this endpoint. This field may be used by consumers of endpoints to distinguish endpoints from each other (e.g. in DNS names). Multiple endpoints which use the same hostname should be considered fungible (e.g. multiple A values in DNS). Must be lowercase and pass DNS Label (RFC 1123) validation.</summary> */
        public string hostname { get; set; }
        /** <summary>nodeName represents the name of the Node hosting this endpoint. This can be used to determine endpoints local to a Node. This field can be enabled with the EndpointSliceNodeName feature gate.</summary> */
        public string nodeName { get; set; }
        /** <summary>ObjectReference contains enough information to let you inspect or modify the referred object.</summary> */
        public Core.V1.ObjectReference targetRef { get; set; }
        /** <summary>zone is the name of the Zone this endpoint exists in.</summary> */
        public string zone { get; set; }
    }
}