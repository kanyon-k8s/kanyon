using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class ContainerState
    {
        /** <summary>ContainerStateRunning is a running state of a container.</summary> */
        public Core.V1.ContainerStateRunning running { get; set; }
        /** <summary>ContainerStateTerminated is a terminated state of a container.</summary> */
        public Core.V1.ContainerStateTerminated terminated { get; set; }
        /** <summary>ContainerStateWaiting is a waiting state of a container.</summary> */
        public Core.V1.ContainerStateWaiting waiting { get; set; }
    }
}