using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Apiextensions.V1
{
    public partial class CustomResourceDefinitionSpec
    {
        /** <summary>CustomResourceConversion describes how to convert different versions of a CR.</summary> */
        public Apiextensions.V1.CustomResourceConversion conversion { get; set; }
        /** <summary>group is the API group of the defined custom resource. The custom resources are served under `/apis/<group>/...`. Must match the name of the CustomResourceDefinition (in the form `<names.plural>.<group>`).</summary> */
        public string group { get; set; }
        /** <summary>CustomResourceDefinitionNames indicates the names to serve this CustomResourceDefinition</summary> */
        public Apiextensions.V1.CustomResourceDefinitionNames names { get; set; }
        /** <summary>preserveUnknownFields indicates that object fields which are not specified in the OpenAPI schema should be preserved when persisting to storage. apiVersion, kind, metadata and known fields inside metadata are always preserved. This field is deprecated in favor of setting `x-preserve-unknown-fields` to true in `spec.versions[&#42;].schema.openAPIV3Schema`. See https://kubernetes.io/docs/tasks/access-kubernetes-api/custom-resources/custom-resource-definitions/#pruning-versus-preserving-unknown-fields for details.</summary> */
        public bool? preserveUnknownFields { get; set; }
        /** <summary>scope indicates whether the defined custom resource is cluster- or namespace-scoped. Allowed values are `Cluster` and `Namespaced`.</summary> */
        public string scope { get; set; }
        /** <summary>versions is the list of all API versions of the defined custom resource. Version names are used to compute the order in which served versions are listed in API discovery. If the version string is "kube-like", it will sort above non "kube-like" version strings, which are ordered lexicographically. "Kube-like" versions start with a "v", then are followed by a number (the major version), then optionally the string "alpha" or "beta" and another number (the minor version). These are sorted first by GA > beta > alpha (where GA is a version with no suffix such as beta or alpha), and then by comparing major version, then minor version. An example sorted list of versions: v10, v2, v1, v11beta2, v10beta3, v3beta1, v12alpha1, v11alpha2, foo1, foo10.</summary> */
        public IEnumerable<Apiextensions.V1.CustomResourceDefinitionVersion> versions { get; set; }
    }
}