using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Authorization.V1beta1
{
    public partial class SelfSubjectRulesReviewSpec
    {
        /** <summary>Namespace to evaluate rules for. Required.</summary> */
        public string @namespace { get; set; }
    }
}