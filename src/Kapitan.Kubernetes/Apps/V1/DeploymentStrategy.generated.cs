using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Apps.V1
{
    public partial class DeploymentStrategy
    {
        /** <summary>Spec to control the desired behavior of rolling update.</summary> */
        public Apps.V1.RollingUpdateDeployment rollingUpdate { get; set; }
        /** <summary>Type of deployment. Can be "Recreate" or "RollingUpdate". Default is RollingUpdate.</summary> */
        public string type { get; set; }
    }
}