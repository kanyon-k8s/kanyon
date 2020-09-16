using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Authorization.V1
{
    public partial class SelfSubjectRulesReviewSpec
    {
        /** <summary>Namespace to evaluate rules for. Required.</summary> */
        public string @namespace { get; set; }
    }
}