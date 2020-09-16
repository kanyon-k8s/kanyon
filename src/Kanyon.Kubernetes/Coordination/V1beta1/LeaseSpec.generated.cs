using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Coordination.V1beta1
{
    public partial class LeaseSpec
    {
        /** <summary>MicroTime is version of Time with microsecond level precision.</summary> */
        public Core.V1.MicroTime acquireTime { get; set; }
        /** <summary>holderIdentity contains the identity of the holder of a current lease.</summary> */
        public string holderIdentity { get; set; }
        /** <summary>leaseDurationSeconds is a duration that candidates for a lease need to wait to force acquire it. This is measure against time of last observed RenewTime.</summary> */
        public int leaseDurationSeconds { get; set; }
        /** <summary>leaseTransitions is the number of transitions of a lease between holders.</summary> */
        public int leaseTransitions { get; set; }
        /** <summary>MicroTime is version of Time with microsecond level precision.</summary> */
        public Core.V1.MicroTime renewTime { get; set; }
    }
}