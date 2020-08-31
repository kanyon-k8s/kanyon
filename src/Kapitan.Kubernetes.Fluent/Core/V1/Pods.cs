using Kapitan.Kubernetes.Core.V1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kapitan.Kubernetes.Fluent.Core.V1
{
    public static class Pods
    {
        public static Pod Pod() => new Pod() { metadata = new ObjectMeta(), spec = new PodSpec() };
    }
}
