using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Certificates.V1
{
    public partial class CertificateSigningRequest : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "certificates.k8s.io/v1";
        [JsonProperty("kind")]
        public string Kind => "CertificateSigningRequest";

        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>CertificateSigningRequestSpec contains the certificate request.</summary> */
        public Certificates.V1.CertificateSigningRequestSpec spec { get; set; }
        /** <summary>CertificateSigningRequestStatus contains conditions used to indicate approved/denied/failed status of the request, and the issued certificate.</summary> */
        public Certificates.V1.CertificateSigningRequestStatus status { get; set; }
    }
}