#r "nuget: Kapitan.Kubernetes, 2.1.0"

using Kapitan.Kubernetes.Apps.V1;
using Kapitan.Kubernetes.Core.V1;

new Kapitan.Core.Manifest() {
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