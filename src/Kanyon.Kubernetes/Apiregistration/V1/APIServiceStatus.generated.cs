using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Apiregistration.V1
{
    public partial class APIServiceStatus
    {
        /** <summary>Current service state of apiService.</summary> */
        public IEnumerable<Apiregistration.V1.APIServiceCondition> conditions { get; set; }
    }
}