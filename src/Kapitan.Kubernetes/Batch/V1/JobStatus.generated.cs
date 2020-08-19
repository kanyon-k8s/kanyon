using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Batch.V1
{
    public partial class JobStatus
    {
        /** <summary>The number of actively running pods.</summary> */
        public int active { get; set; }
        /** <summary>Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers.</summary> */
        public Core.V1.Time completionTime { get; set; }
        /** <summary>The latest available observations of an object's current state. More info: https://kubernetes.io/docs/concepts/workloads/controllers/jobs-run-to-completion/</summary> */
        public List<Batch.V1.JobCondition> conditions { get; set; }
        /** <summary>The number of pods which reached phase Failed.</summary> */
        public int failed { get; set; }
        /** <summary>Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers.</summary> */
        public Core.V1.Time startTime { get; set; }
        /** <summary>The number of pods which reached phase Succeeded.</summary> */
        public int succeeded { get; set; }
    }
}