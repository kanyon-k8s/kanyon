using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Apps.V1
{
    public partial class StatefulSetStatus
    {
        /** <summary>Total number of available pods (ready for at least minReadySeconds) targeted by this statefulset. This is a beta field and enabled/disabled by StatefulSetMinReadySeconds feature gate.</summary> */
        public int availableReplicas { get; set; }
        /** <summary>collisionCount is the count of hash collisions for the StatefulSet. The StatefulSet controller uses this field as a collision avoidance mechanism when it needs to create the name for the newest ControllerRevision.</summary> */
        public int collisionCount { get; set; }
        /** <summary>Represents the latest available observations of a statefulset's current state.</summary> */
        public IEnumerable<Apps.V1.StatefulSetCondition> conditions { get; set; }
        /** <summary>currentReplicas is the number of Pods created by the StatefulSet controller from the StatefulSet version indicated by currentRevision.</summary> */
        public int currentReplicas { get; set; }
        /** <summary>currentRevision, if not empty, indicates the version of the StatefulSet used to generate Pods in the sequence [0,currentReplicas).</summary> */
        public string currentRevision { get; set; }
        /** <summary>observedGeneration is the most recent generation observed for this StatefulSet. It corresponds to the StatefulSet's generation, which is updated on mutation by the API Server.</summary> */
        public int observedGeneration { get; set; }
        /** <summary>readyReplicas is the number of pods created for this StatefulSet with a Ready Condition.</summary> */
        public int readyReplicas { get; set; }
        /** <summary>replicas is the number of Pods created by the StatefulSet controller.</summary> */
        public int replicas { get; set; }
        /** <summary>updateRevision, if not empty, indicates the version of the StatefulSet used to generate Pods in the sequence [replicas-updatedReplicas,replicas)</summary> */
        public string updateRevision { get; set; }
        /** <summary>updatedReplicas is the number of Pods created by the StatefulSet controller from the StatefulSet version indicated by updateRevision.</summary> */
        public int updatedReplicas { get; set; }
    }
}