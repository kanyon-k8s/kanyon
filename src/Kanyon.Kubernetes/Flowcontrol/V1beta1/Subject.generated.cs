using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Flowcontrol.V1beta1
{
    public partial class Subject
    {
        /** <summary>GroupSubject holds detailed information for group-kind subject.</summary> */
        public Flowcontrol.V1beta1.GroupSubject group { get; set; }
        /** <summary>`kind` indicates which one of the other fields is non-empty. Required</summary> */
        public string kind { get; set; }
        /** <summary>ServiceAccountSubject holds detailed information for service-account-kind subject.</summary> */
        public Flowcontrol.V1beta1.ServiceAccountSubject serviceAccount { get; set; }
        /** <summary>UserSubject holds detailed information for user-kind subject.</summary> */
        public Flowcontrol.V1beta1.UserSubject user { get; set; }
    }
}