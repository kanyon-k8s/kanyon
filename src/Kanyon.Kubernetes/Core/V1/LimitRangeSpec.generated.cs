using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class LimitRangeSpec
    {
        /** <summary>Limits is the list of LimitRangeItem objects that are enforced.</summary> */
        public IEnumerable<Core.V1.LimitRangeItem> limits { get; set; }
    }
}