using System;

namespace Kapitan.Demos.Configuration
{
    public class Manifest : Kapitan.Core.Manifest
    {
        public override void ConfigureItems(Dictionary<string, string> configuration)
        {
            Add(
                new Deployment
                {
                    metadata = new ObjectMeta()
                    {
                        name = "helloworld",
                        annotations = new Dictionary<string, string> {
                            { "manifest", configuration["Invocation:ManifestSource"] },
                            { "generated-by", configuration["USERNAME"] }
                        }
                    },
                    spec = new DeploymentSpec()
                    {
                        template = new PodTemplateSpec()
                        {
                            spec = new PodSpec()
                            {
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
}
