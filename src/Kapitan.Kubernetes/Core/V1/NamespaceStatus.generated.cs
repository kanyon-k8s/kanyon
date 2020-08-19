using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class NamespaceStatus
    {
        /** <summary>Represents the latest available observations of a namespace's current state.</summary> */
        public List<Core.V1.NamespaceCondition> conditions { get; set; }
        /** <summary>Phase is the current lifecycle phase of the namespace. More info: https://kubernetes.io/docs/tasks/administer-cluster/namespaces/</summary> */
        public string phase { get; set; }
    }
}