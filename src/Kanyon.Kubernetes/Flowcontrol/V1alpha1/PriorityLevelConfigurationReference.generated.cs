using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Flowcontrol.V1alpha1
{
    public partial class PriorityLevelConfigurationReference
    {
        /** <summary>`name` is the name of the priority level configuration being referenced Required.</summary> */
        public string name { get; set; }
    }
}