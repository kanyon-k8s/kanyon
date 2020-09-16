using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Apiextensions.V1beta1
{
    public partial class CustomResourceDefinitionNames
    {
        /** <summary>categories is a list of grouped resources this custom resource belongs to (e.g. 'all'). This is published in API discovery documents, and used by clients to support invocations like `kubectl get all`.</summary> */
        public IEnumerable<string> categories { get; set; }
        /** <summary>kind is the serialized kind of the resource. It is normally CamelCase and singular. Custom resource instances will use this value as the `kind` attribute in API calls.</summary> */
        public string kind { get; set; }
        /** <summary>listKind is the serialized kind of the list for this resource. Defaults to "`kind`List".</summary> */
        public string listKind { get; set; }
        /** <summary>plural is the plural name of the resource to serve. The custom resources are served under `/apis/<group>/<version>/.../<plural>`. Must match the name of the CustomResourceDefinition (in the form `<names.plural>.<group>`). Must be all lowercase.</summary> */
        public string plural { get; set; }
        /** <summary>shortNames are short names for the resource, exposed in API discovery documents, and used by clients to support invocations like `kubectl get <shortname>`. It must be all lowercase.</summary> */
        public IEnumerable<string> shortNames { get; set; }
        /** <summary>singular is the singular name of the resource. It must be all lowercase. Defaults to lowercased `kind`.</summary> */
        public string singular { get; set; }
    }
}