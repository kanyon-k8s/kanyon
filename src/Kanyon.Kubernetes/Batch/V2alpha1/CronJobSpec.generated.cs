using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Batch.V2alpha1
{
    public partial class CronJobSpec
    {
        /** <summary>Specifies how to treat concurrent executions of a Job. Valid values are: - "Allow" (default): allows CronJobs to run concurrently; - "Forbid": forbids concurrent runs, skipping next run if previous run hasn't finished yet; - "Replace": cancels currently running job and replaces it with a new one</summary> */
        public string concurrencyPolicy { get; set; }
        /** <summary>The number of failed finished jobs to retain. This is a pointer to distinguish between explicit zero and not specified.</summary> */
        public int failedJobsHistoryLimit { get; set; }
        /** <summary>JobTemplateSpec describes the data a Job should have when created from a template</summary> */
        public Batch.V2alpha1.JobTemplateSpec jobTemplate { get; set; }
        /** <summary>The schedule in Cron format, see https://en.wikipedia.org/wiki/Cron.</summary> */
        public string schedule { get; set; }
        /** <summary>Optional deadline in seconds for starting the job if it misses scheduled time for any reason.  Missed jobs executions will be counted as failed ones.</summary> */
        public int startingDeadlineSeconds { get; set; }
        /** <summary>The number of successful finished jobs to retain. This is a pointer to distinguish between explicit zero and not specified.</summary> */
        public int successfulJobsHistoryLimit { get; set; }
        /** <summary>This flag tells the controller to suspend subsequent executions, it does not apply to already started executions.  Defaults to false.</summary> */
        public bool suspend { get; set; }
    }
}