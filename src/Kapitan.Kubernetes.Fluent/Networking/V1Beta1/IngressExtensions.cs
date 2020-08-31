using Kapitan.Kubernetes.Extensions.V1beta1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kapitan.Kubernetes.Fluent.Networking.V1Beta1
{
    public static class IngressExtensions
    {

    }

    public static class Ingresses
    {
        public static Ingress Ingress()
        {
            return new Ingress
            {
                metadata = new Kubernetes.Core.V1.ObjectMeta(),
                spec = new IngressSpec()
            };
        }
    }
}
