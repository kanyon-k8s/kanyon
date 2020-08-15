using k8s.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kapitan.Core.Resources.V1
{
    public class Service : V1Service
    {
        public Service() : this(null)
        {
        }

        public Service(V1ObjectMeta metadata = null, V1ServiceSpec spec = null, V1ServiceStatus status = null) : base("v1", "Service", metadata, spec, status)
        {
        }
    }
}
