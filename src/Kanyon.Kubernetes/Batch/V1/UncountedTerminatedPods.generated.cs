using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Batch.V1
{
    public partial class UncountedTerminatedPods
    {
        /** <summary>Failed holds UIDs of failed Pods.</summary> */
        public IEnumerable<string> failed { get; set; }
        /** <summary>Succeeded holds UIDs of succeeded Pods.</summary> */
        public IEnumerable<string> succeeded { get; set; }
    }
}