#r "nuget: Kapitan.Core, 2.1.0"
#r "nuget: Kapitan.Kubernetes, 2.1.0"

using System.Collections.Generic;
using Kapitan.Core;
using Kapitan.Kubernetes.Apps.V1;

class AnnotateObjectsPolicy : IPolicy
{
    public void Evaluate(IManifestObject manifestObject, Dictionary<string, string> configuration)
    {
        dynamic resource = manifestObject;

        try {
            if (resource.metadata.annotations == null) resource.metadata.annotations = new Dictionary<string, string>();
                resource.metadata.annotations.Add("kapitan.dev/manifest", configuration["Invocation.ManifestSource"]);
        }
        catch (Exception ex) { Console.Error.WriteLine(ex.Message); }
    }
}

class EnforcePullPolicyPolicy : IPolicy
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

new IPolicy[] {
    new AnnotateObjectsPolicy(),
    new EnforcePullPolicyPolicy()
}