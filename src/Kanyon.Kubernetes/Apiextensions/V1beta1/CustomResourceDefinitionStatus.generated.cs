using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Apiextensions.V1beta1
{
    public partial class CustomResourceDefinitionStatus
    {
        /** <summary>CustomResourceDefinitionNames indicates the names to serve this CustomResourceDefinition</summary> */
        public Apiextensions.V1beta1.CustomResourceDefinitionNames acceptedNames { get; set; }
        /** <summary>conditions indicate state for particular aspects of a CustomResourceDefinition</summary> */
        public IEnumerable<Apiextensions.V1beta1.CustomResourceDefinitionCondition> conditions { get; set; }
        /** <summary>storedVersions lists all versions of CustomResources that were ever persisted. Tracking these versions allows a migration path for stored versions in etcd. The field is mutable so a migration controller can finish a migration to another version (ensuring no old objects are left in storage), and then remove the rest of the versions from this list. Versions may not be removed from `spec.versions` while they exist in this list.</summary> */
        public IEnumerable<string> storedVersions { get; set; }
    }
}