using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Events.V1beta1
{
    public partial class EventList : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "events.k8s.io/v1beta1";
        [JsonProperty("kind")]
        public string Kind => "EventList";

        /** <summary>items is a list of schema objects.</summary> */
        public List<Events.V1beta1.Event> items { get; set; }
        /** <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary> */
        public string kind { get; set; }
        /** <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary> */
        public Core.V1.ListMeta metadata { get; set; }
    }
}