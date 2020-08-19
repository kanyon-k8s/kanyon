using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class EventSource
    {
        /** <summary>Component from which the event is generated.</summary> */
        public string component { get; set; }
        /** <summary>Node name on which the event is generated.</summary> */
        public string host { get; set; }
    }
}