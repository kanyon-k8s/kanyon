using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class Event : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "v1";
        [JsonProperty("kind")]
        public string Kind => "Event";

        /** <summary>What action was taken/failed regarding to the Regarding object.</summary> */
        public string action { get; set; }
        /** <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary> */
        public string apiVersion { get; set; }
        /** <summary>The number of times this event has occurred.</summary> */
        public int count { get; set; }
        /** <summary>MicroTime is version of Time with microsecond level precision.</summary> */
        public Core.V1.MicroTime eventTime { get; set; }
        /** <summary>Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers.</summary> */
        public Core.V1.Time firstTimestamp { get; set; }
        /** <summary>ObjectReference contains enough information to let you inspect or modify the referred object.</summary> */
        public Core.V1.ObjectReference involvedObject { get; set; }
        /** <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary> */
        public string kind { get; set; }
        /** <summary>Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers.</summary> */
        public Core.V1.Time lastTimestamp { get; set; }
        /** <summary>A human-readable description of the status of this operation.</summary> */
        public string message { get; set; }
        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>This should be a short, machine understandable string that gives the reason for the transition into the object's current status.</summary> */
        public string reason { get; set; }
        /** <summary>ObjectReference contains enough information to let you inspect or modify the referred object.</summary> */
        public Core.V1.ObjectReference related { get; set; }
        /** <summary>Name of the controller that emitted this Event, e.g. `kubernetes.io/kubelet`.</summary> */
        public string reportingComponent { get; set; }
        /** <summary>ID of the controller instance, e.g. `kubelet-xyzf`.</summary> */
        public string reportingInstance { get; set; }
        /** <summary>EventSeries contain information on series of events, i.e. thing that was/is happening continuously for some time.</summary> */
        public Core.V1.EventSeries series { get; set; }
        /** <summary>EventSource contains information for an event.</summary> */
        public Core.V1.EventSource source { get; set; }
        /** <summary>Type of this event (Normal, Warning), new types could be added in the future</summary> */
        public string type { get; set; }
    }
}