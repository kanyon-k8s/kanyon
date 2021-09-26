using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Flowcontrol.V1beta1
{
    public partial class LimitedPriorityLevelConfiguration
    {
        /** <summary>`assuredConcurrencyShares` (ACS) configures the execution limit, which is a limit on the number of requests of this priority level that may be exeucting at a given time.  ACS must be a positive number. The server's concurrency limit (SCL) is divided among the concurrency-controlled priority levels in proportion to their assured concurrency shares. This produces the assured concurrency value (ACV) --- the number of requests that may be executing at a time --- for each such priority level:

            ACV(l) = ceil( SCL &#42; ACS(l) / ( sum[priority levels k] ACS(k) ) )

bigger numbers of ACS mean more reserved concurrent requests (at the expense of every other PL). This field has a default value of 30.</summary> */
        public int assuredConcurrencyShares { get; set; }
        /** <summary>LimitResponse defines how to handle requests that can not be executed right now.</summary> */
        public Flowcontrol.V1beta1.LimitResponse limitResponse { get; set; }
    }
}