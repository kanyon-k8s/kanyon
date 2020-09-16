#r "nuget: Kanyon.Kubernetes, 2.0.0"
using Kanyon.Core;
using Kanyon.Kubernetes.Apps.V1;
using Kanyon.Kubernetes.Core.V1;

class CDManifest : Manifest {
    public override void ConfigureItems(Dictionary<string, string> configuration) {
        Add(
            new Deployment { 
            metadata = new ObjectMeta() { 
                name = "helloworld",
                annotations = new Dictionary<string, string> {
                    // { "manifest", configuration["Invocation:ManifestSource"] },
                    { "generated-by", configuration["USERNAME"] }
                } 
            },
            spec = new DeploymentSpec() {
                template = new PodTemplateSpec() {
                    spec = new PodSpec() {
                        containers = new List<Container>() {
                            new Container() {
                                image = $"busybox:{configuration["BuildNumber"]}",
                                name = "hello",
                                command = new List<string> { "sh", "-c", "echo \"Hello, Kubernetes!\" && sleep 3600" }
                            }
                        },
                        restartPolicy = "OnFailure"
                    }
                }
            }
        });
    }
}

new CDManifest()