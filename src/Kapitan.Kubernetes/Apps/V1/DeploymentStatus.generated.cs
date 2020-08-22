using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Apps.V1
{
    public partial class DeploymentStatus
    {
        /** <summary>Total number of available pods (ready for at least minReadySeconds) targeted by this deployment.</summary> */
        public int availableReplicas { get; set; }
        /** <summary>Count of hash collisions for the Deployment. The Deployment controller uses this field as a collision avoidance mechanism when it needs to create the name for the newest ReplicaSet.</summary> */
        public int collisionCount { get; set; }
        /** <summary>Represents the latest available observations of a deployment's current state.</summary> */
        public IEnumerable<Apps.V1.DeploymentCondition> conditions { get; set; }
        /** <summary>The generation observed by the deployment controller.</summary> */
        public int observedGeneration { get; set; }
        /** <summary>Total number of ready pods targeted by this deployment.</summary> */
        public int readyReplicas { get; set; }
        /** <summary>Total number of non-terminated pods targeted by this deployment (their labels match the selector).</summary> */
        public int replicas { get; set; }
        /** <summary>Total number of unavailable pods targeted by this deployment. This is the total number of pods that are still required for the deployment to have 100% available capacity. They may either be pods that are running but not yet available or pods that still have not been created.</summary> */
        public int unavailableReplicas { get; set; }
        /** <summary>Total number of non-terminated pods targeted by this deployment that have the desired template spec.</summary> */
        public int updatedReplicas { get; set; }
    }
}