using k8s.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kapitan.Core.Resources.Apps.V1
{
    public class Deployment : V1Deployment
    {
        public Deployment() : this(null)
        {
        }

        public Deployment(V1ObjectMeta metadata = null, V1DeploymentSpec spec = null, V1DeploymentStatus status = null) : base("apps/v1", "Deployment", metadata, spec, status)
        {
        }

        
    }
}
