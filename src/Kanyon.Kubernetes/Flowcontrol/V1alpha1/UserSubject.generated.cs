using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Flowcontrol.V1alpha1
{
    public partial class UserSubject
    {
        /** <summary>`name` is the username that matches, or "&#42;" to match all usernames. Required.</summary> */
        public string name { get; set; }
    }
}