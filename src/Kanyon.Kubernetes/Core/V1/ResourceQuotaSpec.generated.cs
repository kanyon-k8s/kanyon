using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class ResourceQuotaSpec
    {
        /** <summary>hard is the set of desired hard limits for each named resource. More info: https://kubernetes.io/docs/concepts/policy/resource-quotas/</summary> */
        public object hard { get; set; }
        /** <summary>A scope selector represents the AND of the selectors represented by the scoped-resource selector requirements.</summary> */
        public Core.V1.ScopeSelector scopeSelector { get; set; }
        /** <summary>A collection of filters that must match each object tracked by a quota. If not specified, the quota matches all objects.</summary> */
        public IEnumerable<string> scopes { get; set; }
    }
}