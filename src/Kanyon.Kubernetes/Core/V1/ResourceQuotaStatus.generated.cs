using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class ResourceQuotaStatus
    {
        /** <summary>Hard is the set of enforced hard limits for each named resource. More info: https://kubernetes.io/docs/concepts/policy/resource-quotas/</summary> */
        public object hard { get; set; }
        /** <summary>Used is the current observed total usage of the resource in the namespace.</summary> */
        public object used { get; set; }
    }
}