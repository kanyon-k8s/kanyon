using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Apiextensions.V1
{
    public partial class CustomResourceConversion
    {
        /** <summary>strategy specifies how custom resources are converted between versions. Allowed values are: - `None`: The converter only change the apiVersion and would not touch any other field in the custom resource. - `Webhook`: API Server will call to an external webhook to do the conversion. Additional information
  is needed for this option. This requires spec.preserveUnknownFields to be false, and spec.conversion.webhook to be set.</summary> */
        public string strategy { get; set; }
        /** <summary>WebhookConversion describes how to call a conversion webhook</summary> */
        public Apiextensions.V1.WebhookConversion webhook { get; set; }
    }
}