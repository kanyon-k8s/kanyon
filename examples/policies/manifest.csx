#r "nuget: Kanyon.Kubernetes, 3.1.3"

using Kanyon.Kubernetes.Apps.V1;
using Kanyon.Kubernetes.Core.V1;
using Kanyon.Core;

new Manifest() {
    new Deployment() {
        metadata = new ObjectMeta {
            name = "helloworld",
            @namespace = "default"
        },
        spec = new DeploymentSpec {
            template = new PodTemplateSpec {
                spec = new PodSpec {
                    containers = new List<Container> {
                        new Container {
                            image = "busybox",
                            name = "hello",
                            command = new List<string> { "sh", "-c" },
                            ports = new List<ContainerPort> {
                                new ContainerPort { containerPort = 80 }
                            }
                        }
                    },
                    restartPolicy = "OnFailure"
                }
            }
        }
    },
    new Service {
        metadata = new ObjectMeta {
            name = "helloworld",
            @namespace = "default"
        },
        spec = new ServiceSpec {
            type = "ClusterIP",
            selector = new { app = "helloworld" }
        }
    }
}