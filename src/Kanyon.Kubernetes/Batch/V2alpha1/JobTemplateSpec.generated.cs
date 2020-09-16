using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Batch.V2alpha1
{
    public partial class JobTemplateSpec
    {
        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>JobSpec describes how the job execution will look like.</summary> */
        public Batch.V1.JobSpec spec { get; set; }
    }
}