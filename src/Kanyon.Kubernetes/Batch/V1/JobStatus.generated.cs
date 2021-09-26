using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Batch.V1
{
    public partial class JobStatus
    {
        /** <summary>The number of actively running pods.</summary> */
        public int active { get; set; }
        /** <summary>CompletedIndexes holds the completed indexes when .spec.completionMode = "Indexed" in a text format. The indexes are represented as decimal integers separated by commas. The numbers are listed in increasing order. Three or more consecutive numbers are compressed and represented by the first and last element of the series, separated by a hyphen. For example, if the completed indexes are 1, 3, 4, 5 and 7, they are represented as "1,3-5,7".</summary> */
        public string completedIndexes { get; set; }
        /** <summary>Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers.</summary> */
        public Core.V1.Time completionTime { get; set; }
        /** <summary>The latest available observations of an object's current state. When a Job fails, one of the conditions will have type "Failed" and status true. When a Job is suspended, one of the conditions will have type "Suspended" and status true; when the Job is resumed, the status of this condition will become false. When a Job is completed, one of the conditions will have type "Complete" and status true. More info: https://kubernetes.io/docs/concepts/workloads/controllers/jobs-run-to-completion/</summary> */
        public IEnumerable<Batch.V1.JobCondition> conditions { get; set; }
        /** <summary>The number of pods which reached phase Failed.</summary> */
        public int failed { get; set; }
        /** <summary>Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers.</summary> */
        public Core.V1.Time startTime { get; set; }
        /** <summary>The number of pods which reached phase Succeeded.</summary> */
        public int succeeded { get; set; }
        /** <summary>UncountedTerminatedPods holds UIDs of Pods that have terminated but haven't been accounted in Job status counters.</summary> */
        public Batch.V1.UncountedTerminatedPods uncountedTerminatedPods { get; set; }
    }
}