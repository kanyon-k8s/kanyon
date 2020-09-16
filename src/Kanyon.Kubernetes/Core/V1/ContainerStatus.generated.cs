using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class ContainerStatus
    {
        /** <summary>Container's ID in the format 'docker://<container_id>'.</summary> */
        public string containerID { get; set; }
        /** <summary>The image the container is running. More info: https://kubernetes.io/docs/concepts/containers/images</summary> */
        public string image { get; set; }
        /** <summary>ImageID of the container's image.</summary> */
        public string imageID { get; set; }
        /** <summary>ContainerState holds a possible state of container. Only one of its members may be specified. If none of them is specified, the default one is ContainerStateWaiting.</summary> */
        public Core.V1.ContainerState lastState { get; set; }
        /** <summary>This must be a DNS_LABEL. Each container in a pod must have a unique name. Cannot be updated.</summary> */
        public string name { get; set; }
        /** <summary>Specifies whether the container has passed its readiness probe.</summary> */
        public bool ready { get; set; }
        /** <summary>The number of times the container has been restarted, currently based on the number of dead containers that have not yet been removed. Note that this is calculated from dead containers. But those containers are subject to garbage collection. This value will get capped at 5 by GC.</summary> */
        public int restartCount { get; set; }
        /** <summary>Specifies whether the container has passed its startup probe. Initialized as false, becomes true after startupProbe is considered successful. Resets to false when the container is restarted, or if kubelet loses state temporarily. Is always true when no startupProbe is defined.</summary> */
        public bool started { get; set; }
        /** <summary>ContainerState holds a possible state of container. Only one of its members may be specified. If none of them is specified, the default one is ContainerStateWaiting.</summary> */
        public Core.V1.ContainerState state { get; set; }
    }
}