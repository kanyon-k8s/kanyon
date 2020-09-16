using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class GroupVersionForDiscovery
    {
        /** <summary>groupVersion specifies the API group and version in the form "group/version"</summary> */
        public string groupVersion { get; set; }
        /** <summary>version specifies the version in the form of "version". This is to save the clients the trouble of splitting the GroupVersion.</summary> */
        public string version { get; set; }
    }
}