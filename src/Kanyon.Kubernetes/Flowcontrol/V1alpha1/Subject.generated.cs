using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Flowcontrol.V1alpha1
{
    public partial class Subject
    {
        /** <summary>GroupSubject holds detailed information for group-kind subject.</summary> */
        public Flowcontrol.V1alpha1.GroupSubject group { get; set; }
        /** <summary>Required</summary> */
        public string kind { get; set; }
        /** <summary>ServiceAccountSubject holds detailed information for service-account-kind subject.</summary> */
        public Flowcontrol.V1alpha1.ServiceAccountSubject serviceAccount { get; set; }
        /** <summary>UserSubject holds detailed information for user-kind subject.</summary> */
        public Flowcontrol.V1alpha1.UserSubject user { get; set; }
    }
}