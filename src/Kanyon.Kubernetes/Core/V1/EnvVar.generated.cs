using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class EnvVar
    {
        /** <summary>Name of the environment variable. Must be a C_IDENTIFIER.</summary> */
        public string name { get; set; }
        /** <summary>Variable references $(VAR_NAME) are expanded using the previously defined environment variables in the container and any service environment variables. If a variable cannot be resolved, the reference in the input string will be unchanged. Double $$ are reduced to a single $, which allows for escaping the $(VAR_NAME) syntax: i.e. "$$(VAR_NAME)" will produce the string literal "$(VAR_NAME)". Escaped references will never be expanded, regardless of whether the variable exists or not. Defaults to "".</summary> */
        public string value { get; set; }
        /** <summary>EnvVarSource represents a source for the value of an EnvVar.</summary> */
        public Core.V1.EnvVarSource valueFrom { get; set; }
    }
}