using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Batch.V1beta1
{
    public partial class CronJob : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "batch/v1beta1";
        [JsonProperty("kind")]
        public string Kind => "CronJob";

        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>CronJobSpec describes how the job execution will look like and when it will actually run.</summary> */
        public Batch.V1beta1.CronJobSpec spec { get; set; }
        /** <summary>CronJobStatus represents the current state of a cron job.</summary> */
        public Batch.V1beta1.CronJobStatus status { get; set; }
    }
}