using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Core;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Node.V1
{
    public partial class RuntimeClass : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "node.k8s.io/v1";
        [JsonProperty("kind")]
        public string Kind => "RuntimeClass";

        /** <summary>Handler specifies the underlying runtime and configuration that the CRI implementation will use to handle pods of this class. The possible values are specific to the node & CRI configuration.  It is assumed that all handlers are available on every node, and handlers of the same name are equivalent on every node. For example, a handler called "runc" might specify that the runc OCI runtime (using native Linux containers) will be used to run the containers in a pod. The Handler must be lowercase, conform to the DNS Label (RFC 1123) requirements, and is immutable.</summary> */
        public string handler { get; set; }
        /** <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary> */
        public string kind { get; set; }
        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>Overhead structure represents the resource overhead associated with running a pod.</summary> */
        public Node.V1.Overhead overhead { get; set; }
        /** <summary>Scheduling specifies the scheduling constraints for nodes supporting a RuntimeClass.</summary> */
        public Node.V1.Scheduling scheduling { get; set; }
    }
}