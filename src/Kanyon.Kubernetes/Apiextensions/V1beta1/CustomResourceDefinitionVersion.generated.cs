using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Apiextensions.V1beta1
{
    public partial class CustomResourceDefinitionVersion
    {
        /** <summary>additionalPrinterColumns specifies additional columns returned in Table output. See https://kubernetes.io/docs/reference/using-api/api-concepts/#receiving-resources-as-tables for details. Top-level and per-version columns are mutually exclusive. Per-version columns must not all be set to identical values (top-level columns should be used instead). If no top-level or per-version columns are specified, a single column displaying the age of the custom resource is used.</summary> */
        public IEnumerable<Apiextensions.V1beta1.CustomResourceColumnDefinition> additionalPrinterColumns { get; set; }
        /** <summary>deprecated indicates this version of the custom resource API is deprecated. When set to true, API requests to this version receive a warning header in the server response. Defaults to false.</summary> */
        public bool deprecated { get; set; }
        /** <summary>deprecationWarning overrides the default warning returned to API clients. May only be set when `deprecated` is true. The default warning indicates this version is deprecated and recommends use of the newest served version of equal or greater stability, if one exists.</summary> */
        public string deprecationWarning { get; set; }
        /** <summary>name is the version name, e.g. “v1”, “v2beta1”, etc. The custom resources are served under this version at `/apis/<group>/<version>/...` if `served` is true.</summary> */
        public string name { get; set; }
        /** <summary>CustomResourceValidation is a list of validation methods for CustomResources.</summary> */
        public Apiextensions.V1beta1.CustomResourceValidation schema { get; set; }
        /** <summary>served is a flag enabling/disabling this version from being served via REST APIs</summary> */
        public bool served { get; set; }
        /** <summary>storage indicates this version should be used when persisting custom resources to storage. There must be exactly one version with storage=true.</summary> */
        public bool storage { get; set; }
        /** <summary>CustomResourceSubresources defines the status and scale subresources for CustomResources.</summary> */
        public Apiextensions.V1beta1.CustomResourceSubresources subresources { get; set; }
    }
}