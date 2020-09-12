using System;
using Kapitan.Kubernetes.Core.V1;
using Kapitan.Kubernetes.Apps.V1;
using System.Collections.Generic;

[assembly: Kapitan.Core.KapitanManifest(typeof(Kapitan.Demos.GettingStarted.Manifest))]

namespace Kapitan.Demos.GettingStarted
{
    public class Manifest : Kapitan.Core.Manifest
    {
        public Manifest()
        {
            this.Add(new Deployment()
            {
                metadata = new ObjectMeta
                {
                    name = "helloworld"
                },
                spec = new DeploymentSpec
                {
                    selector = new LabelSelector
                    {
                        matchLabels = new { app = "helloworld" }
                    },
                    template = new PodTemplateSpec
                    {
                        metadata = new ObjectMeta()
                        {
                            labels = new { app = "helloworld" }
                        },
                        spec = new PodSpec
                        {
                            containers = new List<Container> {
                        new Container {
                            image = "nginx",
                            name = "hello",
                            ports = new List<ContainerPort> {
                                new ContainerPort { containerPort = 80 }
                            }
                        }
                    },
                            restartPolicy = "OnFailure"
                        }
                    }
                }
            });

            this.Add(new Service
            {
                metadata = new ObjectMeta
                {
                    name = "helloworld",
                },
                spec = new ServiceSpec
                {
                    type = "ClusterIP",
                    selector = new { app = "helloworld" }
                }
            });
        }
    }
}
