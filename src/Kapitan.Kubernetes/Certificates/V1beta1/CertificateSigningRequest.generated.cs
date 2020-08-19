using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Certificates.V1beta1
{
    public partial class CertificateSigningRequest : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "certificates.k8s.io/v1beta1";
        [JsonProperty("kind")]
        public string Kind => "CertificateSigningRequest";

        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>This information is immutable after the request is created. Only the Request and Usages fields can be set on creation, other fields are derived by Kubernetes and cannot be modified by users.</summary> */
        public Certificates.V1beta1.CertificateSigningRequestSpec spec { get; set; }
        /** <summary></summary> */
        public Certificates.V1beta1.CertificateSigningRequestStatus status { get; set; }
    }
}