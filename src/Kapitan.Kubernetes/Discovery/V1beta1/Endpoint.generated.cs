using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Discovery.V1beta1
{
    public partial class Endpoint
    {
        /** <summary>addresses of this endpoint. The contents of this field are interpreted according to the corresponding EndpointSlice addressType field. Consumers must handle different types of addresses in the context of their own capabilities. This must contain at least one address but no more than 100.</summary> */
        public List<string> addresses { get; set; }
        /** <summary>EndpointConditions represents the current condition of an endpoint.</summary> */
        public Discovery.V1beta1.EndpointConditions conditions { get; set; }
        /** <summary>hostname of this endpoint. This field may be used by consumers of endpoints to distinguish endpoints from each other (e.g. in DNS names). Multiple endpoints which use the same hostname should be considered fungible (e.g. multiple A values in DNS). Must pass DNS Label (RFC 1123) validation.</summary> */
        public string hostname { get; set; }
        /** <summary>ObjectReference contains enough information to let you inspect or modify the referred object.</summary> */
        public Core.V1.ObjectReference targetRef { get; set; }
        /** <summary>topology contains arbitrary topology information associated with the endpoint. These key/value pairs must conform with the label format. https://kubernetes.io/docs/concepts/overview/working-with-objects/labels Topology may include a maximum of 16 key/value pairs. This includes, but is not limited to the following well known keys: &#42; kubernetes.io/hostname: the value indicates the hostname of the node
  where the endpoint is located. This should match the corresponding
  node label.
&#42; topology.kubernetes.io/zone: the value indicates the zone where the
  endpoint is located. This should match the corresponding node label.
&#42; topology.kubernetes.io/region: the value indicates the region where the
  endpoint is located. This should match the corresponding node label.</summary> */
        public object topology { get; set; }
    }
}