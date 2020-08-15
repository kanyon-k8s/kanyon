using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kapitan.Core
{
    public class ThirdPartyResource : KubernetesObject
    {
        public V1ObjectMeta Metadata { get; set; }
        public object Spec { get; set; }
    }
}
