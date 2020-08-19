using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class ManagedFieldsEntry
    {
        /** <summary>APIVersion defines the version of this resource that this field set applies to. The format is "group/version" just like the top-level APIVersion field. It is necessary to track the version of a field set because it cannot be automatically converted.</summary> */
        public string apiVersion { get; set; }
        /** <summary>FieldsType is the discriminator for the different fields format and version. There is currently only one possible value: "FieldsV1"</summary> */
        public string fieldsType { get; set; }
        /** <summary>FieldsV1 stores a set of fields in a data structure like a Trie, in JSON format.

Each key is either a '.' representing the field itself, and will always map to an empty set, or a string representing a sub-field or item. The string will follow one of these four formats: 'f:<name>', where <name> is the name of a field in a struct, or key in a map 'v:<value>', where <value> is the exact json formatted value of a list item 'i:<index>', where <index> is position of a item in a list 'k:<keys>', where <keys> is a map of  a list item's key fields to their unique values If a key maps to an empty Fields value, the field that key represents is part of the set.

The exact format is defined in sigs.k8s.io/structured-merge-diff</summary> */
        public Core.V1.FieldsV1 fieldsV1 { get; set; }
        /** <summary>Manager is an identifier of the workflow managing these fields.</summary> */
        public string manager { get; set; }
        /** <summary>Operation is the type of operation which lead to this ManagedFieldsEntry being created. The only valid values for this field are 'Apply' and 'Update'.</summary> */
        public string operation { get; set; }
        /** <summary>Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers.</summary> */
        public Core.V1.Time time { get; set; }
    }
}