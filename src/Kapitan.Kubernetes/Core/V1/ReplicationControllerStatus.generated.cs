using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class ReplicationControllerStatus
    {
        /** <summary>The number of available replicas (ready for at least minReadySeconds) for this replication controller.</summary> */
        public int availableReplicas { get; set; }
        /** <summary>Represents the latest available observations of a replication controller's current state.</summary> */
        public List<Core.V1.ReplicationControllerCondition> conditions { get; set; }
        /** <summary>The number of pods that have labels matching the labels of the pod template of the replication controller.</summary> */
        public int fullyLabeledReplicas { get; set; }
        /** <summary>ObservedGeneration reflects the generation of the most recently observed replication controller.</summary> */
        public int observedGeneration { get; set; }
        /** <summary>The number of ready replicas for this replication controller.</summary> */
        public int readyReplicas { get; set; }
        /** <summary>Replicas is the most recently oberved number of replicas. More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller#what-is-a-replicationcontroller</summary> */
        public int replicas { get; set; }
    }
}