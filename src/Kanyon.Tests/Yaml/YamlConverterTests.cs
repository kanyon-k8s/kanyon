using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Kanyon.Core;
using Kanyon.Kubernetes.Apiextensions.V1beta1;
using Kanyon.Kubernetes.Core.V1;
using Kanyon.Engine.Yaml;

namespace Kanyon.Yaml.Tests
{
    [TestClass()]
    public class YamlConverterTests
    {
        [TestMethod()]
        public void SerializeObject_RespectsJsonPropertyTest()
        {
            var manifest = new Manifest
            {
                new CustomResourceDefinition
                {
                    spec = new CustomResourceDefinitionSpec
                    {
                        additionalPrinterColumns = new List<CustomResourceColumnDefinition>
                        {
                            new CustomResourceColumnDefinition
                            {
                                JSONPath = ".path",
                                name = "name"
                            }
                        }
                    }
                }
            };

            var result = YamlConverter.SerializeObject(manifest);

            Assert.IsTrue(result.Contains("JSONPath"));
        }

        [TestMethod()]
        public void SerializeObject_ForCustomResource_RemovesEmptySets()
        {
            var template = new CustomResourceDefinition
            {
                metadata = new ObjectMeta
                {
                    name = "test.crd"
                },
                spec = new CustomResourceDefinitionSpec
                {
                    group = "crd",
                    names = new CustomResourceDefinitionNames
                    {
                        kind = "test",
                        plural = "tests"
                    },
                    scope = "Namespaced",
                    subresources = new CustomResourceSubresources
                    {
                        status = new CustomResourceSubresourceStatus
                        {
                        }
                    },
                    validation = new CustomResourceValidation
                    {
                        openAPIV3Schema = new Microsoft.OpenApi.Models.OpenApiSchema
                        {
                            Properties = new Dictionary<string, Microsoft.OpenApi.Models.OpenApiSchema>
                        {
                            { "apiVersion", new Microsoft.OpenApi.Models.OpenApiSchema
                            {
                                Type = "string"
                            } },
                            { "kind", new Microsoft.OpenApi.Models.OpenApiSchema
                            {
                                Type = "string"
                            } },
                            { "metadata", new Microsoft.OpenApi.Models.OpenApiSchema
                            {
                                Type = "object"
                            } },
                            { "spec", new Microsoft.OpenApi.Models.OpenApiSchema
                            {
                                Type = "object",
                                Properties = new Dictionary<string, Microsoft.OpenApi.Models.OpenApiSchema>
                                {
                                    { "rules", new Microsoft.OpenApi.Models.OpenApiSchema
                                    {
                                        Type = "array",
                                        Items = new Microsoft.OpenApi.Models.OpenApiSchema
                                        {
                                            Type = "object",
                                            Properties = new Dictionary<string, Microsoft.OpenApi.Models.OpenApiSchema>
                                            {
                                                { "backend", new Microsoft.OpenApi.Models.OpenApiSchema
                                                {
                                                    Type = "object",
                                                    Properties = new Dictionary<string, Microsoft.OpenApi.Models.OpenApiSchema>
                                                    {
                                                        { "serviceName", new Microsoft.OpenApi.Models.OpenApiSchema
                                                        {
                                                            Type = "string"
                                                        } },
                                                        { "servicePort", new Microsoft.OpenApi.Models.OpenApiSchema
                                                        {
                                                            Type = "integer",
                                                            Format = "int32"
                                                        } }
                                                    }
                                                } },
                                                { "host", new Microsoft.OpenApi.Models.OpenApiSchema
                                                {
                                                    Type = "string"
                                                } },
                                                { "port", new Microsoft.OpenApi.Models.OpenApiSchema
                                                {
                                                    Type = "integer",
                                                    Format = "int32"
                                                } }
                                            }
                                        }
                                    } },
                                    { "tls", new Microsoft.OpenApi.Models.OpenApiSchema
                                    {
                                        Type = "array",
                                        Items = new Microsoft.OpenApi.Models.OpenApiSchema
                                        {
                                            Type = "object",
                                            Properties = new Dictionary<string, Microsoft.OpenApi.Models.OpenApiSchema>
                                            {
                                                { "hosts", new Microsoft.OpenApi.Models.OpenApiSchema
                                                {
                                                    Type = "array",
                                                    Items = new Microsoft.OpenApi.Models.OpenApiSchema
                                                    {
                                                        Type = "string"
                                                    }
                                                } },
                                                { "secretName", new Microsoft.OpenApi.Models.OpenApiSchema
                                                {
                                                    Type = "string"
                                                } }
                                            }
                                        }
                                    } }
                                }
                            } },
                            { "status", new Microsoft.OpenApi.Models.OpenApiSchema
                            {
                                Type = "object"
                            } }
                        }
                        }
                    },
                    version = "v1beta1"
                },
                status = new CustomResourceDefinitionStatus
                {
                    acceptedNames = new CustomResourceDefinitionNames
                    {
                        kind = "",
                        plural = ""
                    }
                }
            };

            string yaml = YamlConverter.SerializeObject(template);

            Assert.IsFalse(yaml.Contains("allOf: []"));
        }

        [TestMethod]
        public void SerializeObject_ForCustomResource_RemovesExcessAdditionalPropertiesAllowedFlag()
        {
            var template = new CustomResourceDefinition
            {
                metadata = new ObjectMeta
                {
                    name = "test.crd"
                },
                spec = new CustomResourceDefinitionSpec
                {
                    group = "crd",
                    names = new CustomResourceDefinitionNames
                    {
                        kind = "test",
                        plural = "tests"
                    },
                    scope = "Namespaced",
                    subresources = new CustomResourceSubresources
                    {
                        status = new CustomResourceSubresourceStatus
                        {
                        }
                    },
                    validation = new CustomResourceValidation
                    {
                        openAPIV3Schema = new Microsoft.OpenApi.Models.OpenApiSchema
                        {
                            Properties = new Dictionary<string, Microsoft.OpenApi.Models.OpenApiSchema>
                        {
                            { "apiVersion", new Microsoft.OpenApi.Models.OpenApiSchema
                            {
                                Type = "string"
                            } },
                            { "kind", new Microsoft.OpenApi.Models.OpenApiSchema
                            {
                                Type = "string"
                            } },
                            { "metadata", new Microsoft.OpenApi.Models.OpenApiSchema
                            {
                                Type = "object"
                            } },
                            { "spec", new Microsoft.OpenApi.Models.OpenApiSchema
                            {
                                Type = "object",
                                Properties = new Dictionary<string, Microsoft.OpenApi.Models.OpenApiSchema>
                                {
                                    { "rules", new Microsoft.OpenApi.Models.OpenApiSchema
                                    {
                                        Type = "array",
                                        Items = new Microsoft.OpenApi.Models.OpenApiSchema
                                        {
                                            Type = "object",
                                            Properties = new Dictionary<string, Microsoft.OpenApi.Models.OpenApiSchema>
                                            {
                                                { "backend", new Microsoft.OpenApi.Models.OpenApiSchema
                                                {
                                                    Type = "object",
                                                    Properties = new Dictionary<string, Microsoft.OpenApi.Models.OpenApiSchema>
                                                    {
                                                        { "serviceName", new Microsoft.OpenApi.Models.OpenApiSchema
                                                        {
                                                            Type = "string"
                                                        } },
                                                        { "servicePort", new Microsoft.OpenApi.Models.OpenApiSchema
                                                        {
                                                            Type = "integer",
                                                            Format = "int32"
                                                        } }
                                                    }
                                                } },
                                                { "host", new Microsoft.OpenApi.Models.OpenApiSchema
                                                {
                                                    Type = "string"
                                                } },
                                                { "port", new Microsoft.OpenApi.Models.OpenApiSchema
                                                {
                                                    Type = "integer",
                                                    Format = "int32"
                                                } }
                                            }
                                        }
                                    } },
                                    { "tls", new Microsoft.OpenApi.Models.OpenApiSchema
                                    {
                                        Type = "array",
                                        Items = new Microsoft.OpenApi.Models.OpenApiSchema
                                        {
                                            Type = "object",
                                            Properties = new Dictionary<string, Microsoft.OpenApi.Models.OpenApiSchema>
                                            {
                                                { "hosts", new Microsoft.OpenApi.Models.OpenApiSchema
                                                {
                                                    Type = "array",
                                                    Items = new Microsoft.OpenApi.Models.OpenApiSchema
                                                    {
                                                        Type = "string"
                                                    }
                                                } },
                                                { "secretName", new Microsoft.OpenApi.Models.OpenApiSchema
                                                {
                                                    Type = "string"
                                                } }
                                            }
                                        }
                                    } }
                                }
                            } },
                            { "status", new Microsoft.OpenApi.Models.OpenApiSchema
                            {
                                Type = "object"
                            } }
                        }
                        }
                    },
                    version = "v1beta1"
                },
                status = new CustomResourceDefinitionStatus
                {
                    acceptedNames = new CustomResourceDefinitionNames
                    {
                        kind = "",
                        plural = ""
                    }
                }
            };

            string yaml = YamlConverter.SerializeObject(template);

            Assert.IsFalse(yaml.Contains("additionalPropertiesAllowed: true"));
        }

        [TestMethod]
        public void SerializeObject_WithAmbiguousValue_StringIsDoubleQuoted()
        {
            var manifest = new Kanyon.Kubernetes.Apps.V1.Deployment
            {
                metadata = new Kanyon.Kubernetes.Core.V1.ObjectMeta
                {
                    name = "sql"
                },
                spec = new Kanyon.Kubernetes.Apps.V1.DeploymentSpec
                {
                    replicas = 1,
                    selector = new Kanyon.Kubernetes.Core.V1.LabelSelector
                    {
                        matchLabels = new Dictionary<object, object>
                    {
                        { "app", "sql" }
                    }
                    },
                    template = new Kanyon.Kubernetes.Core.V1.PodTemplateSpec
                    {
                        metadata = new Kanyon.Kubernetes.Core.V1.ObjectMeta
                        {
                            labels = new Dictionary<object, object>
                        {
                            { "app", "sql" },
                            { "tier", "db" }
                        }
                        },
                        spec = new Kanyon.Kubernetes.Core.V1.PodSpec
                        {
                            containers = new List<Kanyon.Kubernetes.Core.V1.Container>
                        {
                            new Kanyon.Kubernetes.Core.V1.Container
                            {
                                env = new List<Kanyon.Kubernetes.Core.V1.EnvVar>
                                {
                                    new Kanyon.Kubernetes.Core.V1.EnvVar
                                    {
                                        name = "MSSQL_PID",
                                        value = "Developer"
                                    },
                                    new Kanyon.Kubernetes.Core.V1.EnvVar
                                    {
                                        name = "ACCEPT_EULA",
                                        value = "Y"
                                    }
                                },
                                image = "mcr.microsoft.com/mssql/server:2017-latest",
                                name = "mssql",
                                ports = new List<Kanyon.Kubernetes.Core.V1.ContainerPort>
                                {
                                    new Kanyon.Kubernetes.Core.V1.ContainerPort
                                    {
                                        containerPort = 1433
                                    }
                                }
                            }
                        }
                        }
                    }
                }
            };

            var result = YamlConverter.SerializeObject(manifest);

            Assert.IsTrue(result.Contains("\"Y\""));
        }
    }
}