using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Authentication.V1
{
    public partial class BoundObjectReference
    {
        /** <summary>API version of the referent.</summary> */
        public string apiVersion { get; set; }
        /** <summary>Kind of the referent. Valid kinds are 'Pod' and 'Secret'.</summary> */
        public string kind { get; set; }
        /** <summary>Name of the referent.</summary> */
        public string name { get; set; }
        /** <summary>UID of the referent.</summary> */
        public string uid { get; set; }
    }
}