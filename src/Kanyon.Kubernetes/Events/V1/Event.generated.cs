using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Core;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Events.V1
{
    public partial class Event : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "events.k8s.io/v1";
        [JsonProperty("kind")]
        public string Kind => "Event";

        /** <summary>action is what action was taken/failed regarding to the regarding object. It is machine-readable. This field can have at most 128 characters.</summary> */
        public string action { get; set; }
        /** <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary> */
        public string apiVersion { get; set; }
        /** <summary>deprecatedCount is the deprecated field assuring backward compatibility with core.v1 Event type.</summary> */
        public int deprecatedCount { get; set; }
        /** <summary>Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers.</summary> */
        public Core.V1.Time deprecatedFirstTimestamp { get; set; }
        /** <summary>Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers.</summary> */
        public Core.V1.Time deprecatedLastTimestamp { get; set; }
        /** <summary>EventSource contains information for an event.</summary> */
        public Core.V1.EventSource deprecatedSource { get; set; }
        /** <summary>MicroTime is version of Time with microsecond level precision.</summary> */
        public Core.V1.MicroTime eventTime { get; set; }
        /** <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary> */
        public string kind { get; set; }
        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>note is a human-readable description of the status of this operation. Maximal length of the note is 1kB, but libraries should be prepared to handle values up to 64kB.</summary> */
        public string note { get; set; }
        /** <summary>reason is why the action was taken. It is human-readable. This field can have at most 128 characters.</summary> */
        public string reason { get; set; }
        /** <summary>ObjectReference contains enough information to let you inspect or modify the referred object.</summary> */
        public Core.V1.ObjectReference regarding { get; set; }
        /** <summary>ObjectReference contains enough information to let you inspect or modify the referred object.</summary> */
        public Core.V1.ObjectReference related { get; set; }
        /** <summary>reportingController is the name of the controller that emitted this Event, e.g. `kubernetes.io/kubelet`. This field cannot be empty for new Events.</summary> */
        public string reportingController { get; set; }
        /** <summary>reportingInstance is the ID of the controller instance, e.g. `kubelet-xyzf`. This field cannot be empty for new Events and it can have at most 128 characters.</summary> */
        public string reportingInstance { get; set; }
        /** <summary>EventSeries contain information on series of events, i.e. thing that was/is happening continuously for some time. How often to update the EventSeries is up to the event reporters. The default event reporter in "k8s.io/client-go/tools/events/event_broadcaster.go" shows how this struct is updated on heartbeats and can guide customized reporter implementations.</summary> */
        public Events.V1.EventSeries series { get; set; }
        /** <summary>type is the type of this event (Normal, Warning), new types could be added in the future. It is machine-readable.</summary> */
        public string type { get; set; }
    }
}