using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Discovery.V1beta1
{
    public partial class EndpointConditions
    {
        /** <summary>ready indicates that this endpoint is prepared to receive traffic, according to whatever system is managing the endpoint. A nil value indicates an unknown state. In most cases consumers should interpret this unknown state as ready.</summary> */
        public bool ready { get; set; }
    }
}