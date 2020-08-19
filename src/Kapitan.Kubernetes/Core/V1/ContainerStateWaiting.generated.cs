using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class ContainerStateWaiting
    {
        /** <summary>Message regarding why the container is not yet running.</summary> */
        public string message { get; set; }
        /** <summary>(brief) reason the container is not yet running.</summary> */
        public string reason { get; set; }
    }
}