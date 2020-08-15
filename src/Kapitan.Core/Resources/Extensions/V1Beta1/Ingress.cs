using k8s.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kapitan.Core.Resources.Extensions.V1Beta1
{
    public class Ingress : Extensionsv1beta1Ingress
    {
        public Ingress() : this(null)
        {
        }

        public Ingress(V1ObjectMeta metadata = null, Extensionsv1beta1IngressSpec spec = null, Extensionsv1beta1IngressStatus status = null) : base("extensions/v1beta1", "Ingress", metadata, spec, status)
        {
        }
    }
}
