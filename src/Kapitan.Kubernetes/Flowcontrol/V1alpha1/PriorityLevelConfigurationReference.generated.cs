using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Flowcontrol.V1alpha1
{
    public partial class PriorityLevelConfigurationReference
    {
        /** <summary>`name` is the name of the priority level configuration being referenced Required.</summary> */
        public string name { get; set; }
    }
}