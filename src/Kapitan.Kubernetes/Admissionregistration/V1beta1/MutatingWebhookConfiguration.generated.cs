using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Admissionregistration.V1beta1
{
    public partial class MutatingWebhookConfiguration : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "admissionregistration.k8s.io/v1beta1";
        [JsonProperty("kind")]
        public string Kind => "MutatingWebhookConfiguration";

        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>Webhooks is a list of webhooks and the affected resources and operations.</summary> */
        public List<Admissionregistration.V1beta1.MutatingWebhook> webhooks { get; set; }
    }
}