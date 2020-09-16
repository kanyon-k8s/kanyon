# Kanyon
> Write Kubernetes manifests faster and with less frustration

![build](https://github.com/kanyon-k8s/kanyon/workflows/.NET%20Core/badge.svg)
![license](https://img.shields.io/github/license/kanyon-k8s/kanyon)
![issues](https://img.shields.io/github/issues/kanyon-k8s/kanyon)
![kanyon.kubernetes](https://badgen.net/nuget/v/kanyon.kubernetes/latest)

### Features
- Repeatable - A Kanyon Manifest will generate the same manifest given the same input every time
- Parameterized - Kanyon manifests allow the writer to inject values from the configuration directly into the manifest, removing the need for a find-and-replace step to inject parameters
- Stateless - Kanyon manifests simply render to a YAML file, which allows the user to use kubectl to apply the manifest and leverage the same patching and validation rules
- Easy-to-use - Kanyon manifests shouldn't require knowledge of magic strings like Kind names, APIVersion values, or other similar tribal knowledge. Where a value is static for a resource, it should be a readonly property so that the user doesn't need to duplicate knowledge and keystrokes

## Usage
Kanyon uses Manifest objects to define what Kubernetes API resources should be emitted. Manifest objects are simply collections of IManifestObject, and can be inherited from and composed with to build the final manifest that Kanyon will serialize. The least-abstracted manifests resemble their YAML counterparts, making translation from YAML simple and frictionless. All of the Kubernetes core resources are implemented in the Kanyon.Kubernetes library.

Kanyon manifests can be defined in either a C# Script (.csx) file that returns a Manifest object or a compiled DLL with a type that inherits from Manifest. Here is an example of a simple manifest written in a C# Script

```csharp
#r "nuget: Kanyon.Kubernetes, 2.0.0"

using Kanyon.Kubernetes.Core.V1;
using Kanyon.Kubernetes.Apps.V1;

new Kanyon.Core.Manifest() {
    new Deployment() {
        metadata = new ObjectMeta {
            name = "helloworld"
        },
        spec = new DeploymentSpec {
            template = new PodTemplateSpec {
                spec = new PodSpec {
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
    },
    new Service {
        metadata = new ObjectMeta {
            name = "helloworld",
        },
        spec = new ServiceSpec {
            type = "ClusterIP",
            selector = new { app = "helloworld" }
        }
    }
}
```

Manifests can be used to build abstractions to minimize repitition of patterns. For example, a HttpServiceManifest class can be created that abstracts the creation of the deployment and needed services.

```csharp
public class HttpServiceManifest : Manifest
{
    public HttpServiceManifest(string name, string image, string host, Dictionary<string, string> envVars, Dictionary<string, string> labels)
    {
        Add(new Deployment() {
            metadata = new ObjectMeta {
                labels = labels,
                name = name
            },
            spec = new DeploymentSpec() {
                selector = new LabelSelector {
                    matchLabels = labels
                },
                template = new PodTemplateSpec() {
                    metadata = new ObjectMeta() {
                        labels = labels
                    },
                    spec = new PodSpec() {
                        containers = new List<Container>() {
                            new Container() {
                                name = "api",
                                image = image,
                                ports = new List<ContainerPort> {
                                    new ContainerPort { containerPort = 80, name = "http" }
                                },
                                env = envVars.Select(env => new EnvVar { name = env.Key, value = env.Value }).ToList()
                            }
                        },
                    }
                }
            }
        });

        Add(new Service() {
            metadata = new ObjectMeta {
                labels = labels,
                name = name
            },
            spec = new ServiceSpec() {
                type = "ClusterIP",
                ports = new int[] { 80 }.Select(port => new ServicePort { port = 80 }).ToList(),
                selector = labels
            }
        });

        Add(new Ingress() {
            metadata = new ObjectMeta {
                labels = labels,
                name = name,
                annotations = new Dictionary<string, string> {
                    { "kubernetes.io/ingress.class", "nginx" }
                }
            },
            spec = new IngressSpec() {
                rules = new List<IngressRule> {
                    new IngressRule {
                        host = host,
                        http = new HTTPIngressRuleValue() {
                            paths = new List<HTTPIngressPath>() {
                                new HTTPIngressPath() {
                                    path = "/",
                                    backend = new IngressBackend{serviceName = name, servicePort = "http" }
                                }
                            }
                        }
                    }
                }
            }
        });
    }
}
```

The Manifest object also exposes APIs to receive configuration values and expose them in the manifest. Each Manifest object will have the ConfigureItems method invoked before it is serialized. This method accepts a `Dictionary<string, string>` as a parameter. This dictionary is populated with the environment variables available to the Kanyon process, as well as any arguments provided on the command line.

```csharp
class CDManifest : Manifest {
    public override void ConfigureItems(Dictionary<string, string> configuration) {
        Add(
            new Deployment { 
            metadata = new ObjectMeta() { 
                name = "helloworld" 
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
```

Full examples can be found in the examples directory.

### How to install
Kanyon is packaged as a .Net Core global tool to make it easy to install. Simply run 
```
dotnet tool install --global kanyon
```

This will install the latest version from NuGet and add it into your path.

### How to generate manifests
Kanyon writes the YAML directly to stdout to make it easy to pipe the output to file or to kubectl. To generate a manifest, simply run 
```
kanyon -f your-manifest-filename.csx
``` 
and the manifest will be emitted to the console. To apply this manifest directly, you can run 
```
kanyon -f your-manifest-filename.csx | kubectl apply -f -
```

Configuration values can also be provided over the command line. Values must be provided using the `key=value` format. To pass a BuildNumber variable into a Kanyon manifest, you can run 
```
kanyon -f your-manifest-filename.csx -c BuildNumber=2.0.0
```

## Background
### Problem Statement
  
- YAML is very painful to make changes to because it isn't type-safe, relies on whitespace for structure, and doesn't provide any validation around parameterization
- Helm provides automation around parameters, but inherits all of the pain with YAML and adds more pain with the template language obscuring the actual manifest definition
- Pulumi makes the editing experience much more friendly, but requires you to set well-known things that can be included in the abstraction (like API versions, etc). It's also unclear that we could 
- CDK8S handles the editing experience well, but it relies on a scope that cross-cuts through the entire stack, and also seems to have the same leaky abstractions as Pulumi. Parameterization is also unclear.

## FAQ
### Why do my script manifests fail to export a manifest?
The script manifests must return a Manifest object as the last instruction. If a semicolon is placed at the end of the line, it is treated as a full statement and nothing is returned.
 
