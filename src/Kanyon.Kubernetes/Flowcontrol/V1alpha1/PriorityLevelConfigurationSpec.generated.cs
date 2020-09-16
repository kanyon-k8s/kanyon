using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Flowcontrol.V1alpha1
{
    public partial class PriorityLevelConfigurationSpec
    {
        /** <summary>LimitedPriorityLevelConfiguration specifies how to handle requests that are subject to limits. It addresses two issues:
 &#42; How are requests for this priority level limited?
 &#42; What should be done with requests that exceed the limit?</summary> */
        public Flowcontrol.V1alpha1.LimitedPriorityLevelConfiguration limited { get; set; }
        /** <summary>`type` indicates whether this priority level is subject to limitation on request execution.  A value of `"Exempt"` means that requests of this priority level are not subject to a limit (and thus are never queued) and do not detract from the capacity made available to other priority levels.  A value of `"Limited"` means that (a) requests of this priority level _are_ subject to limits and (b) some of the server's limited capacity is made available exclusively to this priority level. Required.</summary> */
        public string type { get; set; }
    }
}