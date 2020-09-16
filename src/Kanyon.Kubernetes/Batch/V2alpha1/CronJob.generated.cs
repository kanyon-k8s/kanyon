using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Core;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Batch.V2alpha1
{
    public partial class CronJob : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "batch/v2alpha1";
        [JsonProperty("kind")]
        public string Kind => "CronJob";

        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>CronJobSpec describes how the job execution will look like and when it will actually run.</summary> */
        public Batch.V2alpha1.CronJobSpec spec { get; set; }
        /** <summary>CronJobStatus represents the current state of a cron job.</summary> */
        public Batch.V2alpha1.CronJobStatus status { get; set; }
    }
}