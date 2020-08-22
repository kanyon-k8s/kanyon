using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Apiregistration.V1beta1
{
    public partial class APIServiceStatus
    {
        /** <summary>Current service state of apiService.</summary> */
        public IEnumerable<Apiregistration.V1beta1.APIServiceCondition> conditions { get; set; }
    }
}