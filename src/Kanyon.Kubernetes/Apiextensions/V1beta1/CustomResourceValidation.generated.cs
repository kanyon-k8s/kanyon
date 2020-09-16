using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Apiextensions.V1beta1
{
    public partial class CustomResourceValidation
    {
        /** <summary>JSONSchemaProps is a JSON-Schema following Specification Draft 4 (http://json-schema.org/).</summary> */
        public Microsoft.OpenApi.Models.OpenApiSchema openAPIV3Schema { get; set; }
    }
}