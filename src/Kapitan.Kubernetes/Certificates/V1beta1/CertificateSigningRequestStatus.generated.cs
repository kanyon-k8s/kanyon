using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Certificates.V1beta1
{
    public partial class CertificateSigningRequestStatus
    {
        /** <summary>If request was approved, the controller will place the issued certificate here.</summary> */
        public string certificate { get; set; }
        /** <summary>Conditions applied to the request, such as approval or denial.</summary> */
        public IEnumerable<Certificates.V1beta1.CertificateSigningRequestCondition> conditions { get; set; }
    }
}