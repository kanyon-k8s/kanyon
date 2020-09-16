using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Apiextensions.V1
{
    public partial class CustomResourceSubresources
    {
        /** <summary>CustomResourceSubresourceScale defines how to serve the scale subresource for CustomResources.</summary> */
        public Apiextensions.V1.CustomResourceSubresourceScale scale { get; set; }
        /** <summary>CustomResourceSubresourceStatus defines how to serve the status subresource for CustomResources. Status is represented by the `.status` JSON path inside of a CustomResource. When set, &#42; exposes a /status subresource for the custom resource &#42; PUT requests to the /status subresource take a custom resource object, and ignore changes to anything except the status stanza &#42; PUT/POST/PATCH requests to the custom resource ignore changes to the status stanza</summary> */
        public Apiextensions.V1.CustomResourceSubresourceStatus status { get; set; }
    }
}