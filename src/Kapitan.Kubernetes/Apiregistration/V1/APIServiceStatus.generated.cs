using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Apiregistration.V1
{
    public partial class APIServiceStatus
    {
        /** <summary>Current service state of apiService.</summary> */
        public List<Apiregistration.V1.APIServiceCondition> conditions { get; set; }
    }
}