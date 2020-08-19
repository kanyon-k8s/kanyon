using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class NodeSpec
    {
        /** <summary>NodeConfigSource specifies a source of node configuration. Exactly one subfield (excluding metadata) must be non-nil.</summary> */
        public Core.V1.NodeConfigSource configSource { get; set; }
        /** <summary>Deprecated. Not all kubelets will set this field. Remove field after 1.13. see: https://issues.k8s.io/61966</summary> */
        public string externalID { get; set; }
        /** <summary>PodCIDR represents the pod IP range assigned to the node.</summary> */
        public string podCIDR { get; set; }
        /** <summary>podCIDRs represents the IP ranges assigned to the node for usage by Pods on that node. If this field is specified, the 0th entry must match the podCIDR field. It may contain at most 1 value for each of IPv4 and IPv6.</summary> */
        public List<string> podCIDRs { get; set; }
        /** <summary>ID of the node assigned by the cloud provider in the format: <ProviderName>://<ProviderSpecificNodeID></summary> */
        public string providerID { get; set; }
        /** <summary>If specified, the node's taints.</summary> */
        public List<Core.V1.Taint> taints { get; set; }
        /** <summary>Unschedulable controls node schedulability of new pods. By default, node is schedulable. More info: https://kubernetes.io/docs/concepts/nodes/node/#manual-node-administration</summary> */
        public bool unschedulable { get; set; }
    }
}