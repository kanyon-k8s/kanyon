using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Rbac.V1alpha1
{
    public partial class AggregationRule
    {
        /** <summary>ClusterRoleSelectors holds a list of selectors which will be used to find ClusterRoles and create the rules. If any of the selectors match, then the ClusterRole's permissions will be added</summary> */
        public IEnumerable<Core.V1.LabelSelector> clusterRoleSelectors { get; set; }
    }
}