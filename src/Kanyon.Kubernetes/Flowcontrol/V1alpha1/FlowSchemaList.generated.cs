using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Core;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Flowcontrol.V1alpha1
{
    public partial class FlowSchemaList : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "flowcontrol.apiserver.k8s.io/v1alpha1";
        [JsonProperty("kind")]
        public string Kind => "FlowSchemaList";

        /** <summary>`items` is a list of FlowSchemas.</summary> */
        public IEnumerable<Flowcontrol.V1alpha1.FlowSchema> items { get; set; }
        /** <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary> */
        public string kind { get; set; }
        /** <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary> */
        public Core.V1.ListMeta metadata { get; set; }
    }
}