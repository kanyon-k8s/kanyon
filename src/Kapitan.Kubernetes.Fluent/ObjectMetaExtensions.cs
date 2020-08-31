using Kapitan.Kubernetes.Core.V1;
using System;
using System.Collections.Generic;

namespace Kapitan.Kubernetes.Fluent
{
    public static class ObjectMetadata
    {
        public static ObjectMeta ObjectMeta(string name)
        {
            return new ObjectMeta() { name = name };
        }
    }

    public static class ObjectMetaExtensions
    {
        public static ObjectMeta WithName(this ObjectMeta meta, string name)
        {
            meta.name = name;

            return meta;
        }

        public static ObjectMeta WithNamespace(this ObjectMeta meta, string @namespace)
        {
            meta.@namespace = @namespace;

            return meta;
        }

        public static ObjectMeta WithLabel(this ObjectMeta meta, string key, string value)
        {
            if (meta.labels == null) meta.labels = new Dictionary<string, string>();
            var labels = meta.labels as Dictionary<string, string>;
            if (labels == null) throw new InvalidOperationException("Labels can only be added to a dictionary");

            labels.Add(key, value);

            return meta;
        }

        public static ObjectMeta WithAnnotation(this ObjectMeta meta, string key, string value)
        {
            if (meta.annotations == null) meta.annotations = new Dictionary<string, string>();
            var annotations = meta.annotations as Dictionary<string, string>;
            if (annotations == null) throw new InvalidOperationException("Annotations can only be added to a dictionary");

            annotations.Add(key, value);

            return meta;
        }
    }
}
