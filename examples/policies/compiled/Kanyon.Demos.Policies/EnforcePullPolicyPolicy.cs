using System;
using System.Collections.Generic;
using Kanyon.Core;
using Kanyon.Kubernetes.Apps.V1;

namespace Kanyon.Demos.Policies
{
    public class EnforcePullPolicyPolicy : IPolicy
    {
        public void Evaluate(IManifestObject manifestObject, Dictionary<string, string> configuration)
        {
            if (manifestObject is Deployment deployment) {
                foreach (var container in deployment.spec.template.spec.containers) {
                    container.imagePullPolicy = "IfNotPresent";
                }
            }
        }
    }
}
