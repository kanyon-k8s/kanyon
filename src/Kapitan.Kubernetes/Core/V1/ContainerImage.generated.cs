using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class ContainerImage
    {
        /** <summary>Names by which this image is known. e.g. ["k8s.gcr.io/hyperkube:v1.0.7", "dockerhub.io/google_containers/hyperkube:v1.0.7"]</summary> */
        public IEnumerable<string> names { get; set; }
        /** <summary>The size of the image in bytes.</summary> */
        public int sizeBytes { get; set; }
    }
}