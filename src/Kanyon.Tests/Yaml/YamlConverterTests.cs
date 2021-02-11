using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kanyon.Yaml;
using System;
using System.Collections.Generic;
using System.Text;
using Kanyon.Core;
using Kanyon.Kubernetes.Apiextensions.V1beta1;
using Kanyon.Kubernetes.Core.V1;

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
    }
}