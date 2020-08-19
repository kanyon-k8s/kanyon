using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Apiextensions.V1beta1
{
    public partial class CustomResourceColumnDefinition
    {
        /** <summary>JSONPath is a simple JSON path (i.e. with array notation) which is evaluated against each custom resource to produce the value for this column.</summary> */
        public string JSONPath { get; set; }
        /** <summary>description is a human readable description of this column.</summary> */
        public string description { get; set; }
        /** <summary>format is an optional OpenAPI type definition for this column. The 'name' format is applied to the primary identifier column to assist in clients identifying column is the resource name. See https://github.com/OAI/OpenAPI-Specification/blob/master/versions/2.0.md#data-types for details.</summary> */
        public string format { get; set; }
        /** <summary>name is a human readable name for the column.</summary> */
        public string name { get; set; }
        /** <summary>priority is an integer defining the relative importance of this column compared to others. Lower numbers are considered higher priority. Columns that may be omitted in limited space scenarios should be given a priority greater than 0.</summary> */
        public int priority { get; set; }
        /** <summary>type is an OpenAPI type definition for this column. See https://github.com/OAI/OpenAPI-Specification/blob/master/versions/2.0.md#data-types for details.</summary> */
        public string type { get; set; }
    }
}