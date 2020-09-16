using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Node.V1alpha1
{
    public partial class Scheduling
    {
        /** <summary>nodeSelector lists labels that must be present on nodes that support this RuntimeClass. Pods using this RuntimeClass can only be scheduled to a node matched by this selector. The RuntimeClass nodeSelector is merged with a pod's existing nodeSelector. Any conflicts will cause the pod to be rejected in admission.</summary> */
        public object nodeSelector { get; set; }
        /** <summary>tolerations are appended (excluding duplicates) to pods running with this RuntimeClass during admission, effectively unioning the set of nodes tolerated by the pod and the RuntimeClass.</summary> */
        public IEnumerable<Core.V1.Toleration> tolerations { get; set; }
    }
}