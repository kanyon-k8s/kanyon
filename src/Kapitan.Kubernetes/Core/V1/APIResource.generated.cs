using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class APIResource
    {
        /** <summary>categories is a list of the grouped resources this resource belongs to (e.g. 'all')</summary> */
        public List<string> categories { get; set; }
        /** <summary>group is the preferred group of the resource.  Empty implies the group of the containing resource list. For subresources, this may have a different value, for example: Scale".</summary> */
        public string group { get; set; }
        /** <summary>kind is the kind for the resource (e.g. 'Foo' is the kind for a resource 'foo')</summary> */
        public string kind { get; set; }
        /** <summary>name is the plural name of the resource.</summary> */
        public string name { get; set; }
        /** <summary>namespaced indicates if a resource is namespaced or not.</summary> */
        public bool namespaced { get; set; }
        /** <summary>shortNames is a list of suggested short names of the resource.</summary> */
        public List<string> shortNames { get; set; }
        /** <summary>singularName is the singular name of the resource.  This allows clients to handle plural and singular opaquely. The singularName is more correct for reporting status on a single item and both singular and plural are allowed from the kubectl CLI interface.</summary> */
        public string singularName { get; set; }
        /** <summary>The hash value of the storage version, the version this resource is converted to when written to the data store. Value must be treated as opaque by clients. Only equality comparison on the value is valid. This is an alpha feature and may change or be removed in the future. The field is populated by the apiserver only if the StorageVersionHash feature gate is enabled. This field will remain optional even if it graduates.</summary> */
        public string storageVersionHash { get; set; }
        /** <summary>verbs is a list of supported kube verbs (this includes get, list, watch, create, update, patch, delete, deletecollection, and proxy)</summary> */
        public List<string> verbs { get; set; }
        /** <summary>version is the preferred version of the resource.  Empty implies the version of the containing resource list For subresources, this may have a different value, for example: v1 (while inside a v1beta1 version of the core resource's group)".</summary> */
        public string version { get; set; }
    }
}