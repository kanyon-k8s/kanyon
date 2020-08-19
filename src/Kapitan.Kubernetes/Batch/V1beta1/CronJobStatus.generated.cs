using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Batch.V1beta1
{
    public partial class CronJobStatus
    {
        /** <summary>A list of pointers to currently running jobs.</summary> */
        public List<Core.V1.ObjectReference> active { get; set; }
        /** <summary>Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers.</summary> */
        public Core.V1.Time lastScheduleTime { get; set; }
    }
}