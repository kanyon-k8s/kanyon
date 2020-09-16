using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Autoscaling.V1
{
    public partial class CrossVersionObjectReference
    {
        /** <summary>API version of the referent</summary> */
        public string apiVersion { get; set; }
        /** <summary>Kind of the referent; More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds"</summary> */
        public string kind { get; set; }
        /** <summary>Name of the referent; More info: http://kubernetes.io/docs/user-guide/identifiers#names</summary> */
        public string name { get; set; }
    }
}