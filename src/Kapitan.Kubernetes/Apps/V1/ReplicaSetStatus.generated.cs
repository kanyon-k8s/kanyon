using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Apps.V1
{
    public partial class ReplicaSetStatus
    {
        /** <summary>The number of available replicas (ready for at least minReadySeconds) for this replica set.</summary> */
        public int availableReplicas { get; set; }
        /** <summary>Represents the latest available observations of a replica set's current state.</summary> */
        public List<Apps.V1.ReplicaSetCondition> conditions { get; set; }
        /** <summary>The number of pods that have labels matching the labels of the pod template of the replicaset.</summary> */
        public int fullyLabeledReplicas { get; set; }
        /** <summary>ObservedGeneration reflects the generation of the most recently observed ReplicaSet.</summary> */
        public int observedGeneration { get; set; }
        /** <summary>The number of ready replicas for this replica set.</summary> */
        public int readyReplicas { get; set; }
        /** <summary>Replicas is the most recently oberved number of replicas. More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller/#what-is-a-replicationcontroller</summary> */
        public int replicas { get; set; }
    }
}