using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Apiextensions.V1
{
    public partial class WebhookConversion
    {
        /** <summary>WebhookClientConfig contains the information to make a TLS connection with the webhook.</summary> */
        public Apiextensions.V1.WebhookClientConfig clientConfig { get; set; }
        /** <summary>conversionReviewVersions is an ordered list of preferred `ConversionReview` versions the Webhook expects. The API server will use the first version in the list which it supports. If none of the versions specified in this list are supported by API server, conversion will fail for the custom resource. If a persisted Webhook configuration specifies allowed versions and does not include any versions known to the API Server, calls to the webhook will fail.</summary> */
        public List<string> conversionReviewVersions { get; set; }
    }
}