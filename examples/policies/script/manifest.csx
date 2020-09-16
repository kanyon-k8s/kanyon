#r "nuget: Kanyon.Kubernetes, 2.1.0"

using Kanyon.Kubernetes.Apps.V1;
using Kanyon.Kubernetes.Core.V1;

new Kanyon.Core.Manifest() {
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