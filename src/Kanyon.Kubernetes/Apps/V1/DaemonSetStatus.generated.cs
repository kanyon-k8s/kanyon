using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Apps.V1
{
    public partial class DaemonSetStatus
    {
        /** <summary>Count of hash collisions for the DaemonSet. The DaemonSet controller uses this field as a collision avoidance mechanism when it needs to create the name for the newest ControllerRevision.</summary> */
        public int collisionCount { get; set; }
        /** <summary>Represents the latest available observations of a DaemonSet's current state.</summary> */
        public IEnumerable<Apps.V1.DaemonSetCondition> conditions { get; set; }
        /** <summary>The number of nodes that are running at least 1 daemon pod and are supposed to run the daemon pod. More info: https://kubernetes.io/docs/concepts/workloads/controllers/daemonset/</summary> */
        public int currentNumberScheduled { get; set; }
        /** <summary>The total number of nodes that should be running the daemon pod (including nodes correctly running the daemon pod). More info: https://kubernetes.io/docs/concepts/workloads/controllers/daemonset/</summary> */
        public int desiredNumberScheduled { get; set; }
        /** <summary>The number of nodes that should be running the daemon pod and have one or more of the daemon pod running and available (ready for at least spec.minReadySeconds)</summary> */
        public int numberAvailable { get; set; }
        /** <summary>The number of nodes that are running the daemon pod, but are not supposed to run the daemon pod. More info: https://kubernetes.io/docs/concepts/workloads/controllers/daemonset/</summary> */
        public int numberMisscheduled { get; set; }
        /** <summary>The number of nodes that should be running the daemon pod and have one or more of the daemon pod running and ready.</summary> */
        public int numberReady { get; set; }
        /** <summary>The number of nodes that should be running the daemon pod and have none of the daemon pod running and available (ready for at least spec.minReadySeconds)</summary> */
        public int numberUnavailable { get; set; }
        /** <summary>The most recent generation observed by the daemon set controller.</summary> */
        public int observedGeneration { get; set; }
        /** <summary>The total number of nodes that are running updated daemon pod</summary> */
        public int updatedNumberScheduled { get; set; }
    }
}