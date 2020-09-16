using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Flowcontrol.V1alpha1
{
    public partial class ServiceAccountSubject
    {
        /** <summary>`name` is the name of matching ServiceAccount objects, or "&#42;" to match regardless of name. Required.</summary> */
        public string name { get; set; }
        /** <summary>`namespace` is the namespace of matching ServiceAccount objects. Required.</summary> */
        public string @namespace { get; set; }
    }
}