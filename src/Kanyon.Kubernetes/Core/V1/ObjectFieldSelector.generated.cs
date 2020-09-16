using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class ObjectFieldSelector
    {
        /** <summary>Version of the schema the FieldPath is written in terms of, defaults to "v1".</summary> */
        public string apiVersion { get; set; }
        /** <summary>Path of the field to select in the specified API version.</summary> */
        public string fieldPath { get; set; }
    }
}