using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class SecretKeySelector
    {
        /** <summary>The key of the secret to select from.  Must be a valid secret key.</summary> */
        public string key { get; set; }
        /** <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary> */
        public string name { get; set; }
        /** <summary>Specify whether the Secret or its key must be defined</summary> */
        public bool? optional { get; set; }
    }
}