using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Node.V1alpha1
{
    public partial class RuntimeClassSpec
    {
        /** <summary>Overhead structure represents the resource overhead associated with running a pod.</summary> */
        public Node.V1alpha1.Overhead overhead { get; set; }
        /** <summary>RuntimeHandler specifies the underlying runtime and configuration that the CRI implementation will use to handle pods of this class. The possible values are specific to the node & CRI configuration.  It is assumed that all handlers are available on every node, and handlers of the same name are equivalent on every node. For example, a handler called "runc" might specify that the runc OCI runtime (using native Linux containers) will be used to run the containers in a pod. The RuntimeHandler must be lowercase, conform to the DNS Label (RFC 1123) requirements, and is immutable.</summary> */
        public string runtimeHandler { get; set; }
        /** <summary>Scheduling specifies the scheduling constraints for nodes supporting a RuntimeClass.</summary> */
        public Node.V1alpha1.Scheduling scheduling { get; set; }
    }
}