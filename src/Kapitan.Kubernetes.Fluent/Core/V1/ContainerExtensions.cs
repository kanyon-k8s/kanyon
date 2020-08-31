using Kapitan.Kubernetes.Core.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Kapitan.Kubernetes.Fluent.Core.V1
{
    public static class ContainerExtensions
    {
        public static Container WithImage(this Container container, string image)
        {
            container.image = image;
            return container;
        }

        public static Container WithImagePullPolicy(this Container container, string imagePullPolicy)
        {
            container.imagePullPolicy = imagePullPolicy;

            return container;
        }

        public static Container WithEnvVar(this Container container, string variableName, string value)
        {
            if (container.env == null) container.env = new List<EnvVar>();

            var list = container.env?.ToList() ?? new List<EnvVar>();
            list.Add(new EnvVar() { name = variableName, value = value });

            container.env = list;

            return container;
        }

        public static Container WithEnvVarFromSecret(this Container container, string variableName, string secretName, string secretKey, bool optional = false)
        {
            var list = container.env?.ToList() ?? new List<EnvVar>();
            list.Add(new EnvVar()
            {
                name = variableName,
                valueFrom = new EnvVarSource { secretKeyRef = new SecretKeySelector() { name = secretName, key = secretKey, optional = optional } }
            });

            container.env = list;

            return container;
        }

        public static Container WithEnvVarFromConfigMap(this Container container, string variableName, string configMapName, string configMapKey, bool optional = false)
        {
            var list = container.env?.ToList() ?? new List<EnvVar>();
            list.Add(new EnvVar()
            {
                name = variableName,
                valueFrom = new EnvVarSource()
                {
                    configMapKeyRef = new ConfigMapKeySelector
                    {
                        name = configMapName,
                        key = configMapKey,
                        optional = optional
                    }
                }
            });

            container.env = list;
            return container;
        }

        public static Probe WithLivenessProbe(this Container container)
        {
            if (container.livenessProbe == null) container.livenessProbe = new Probe();

            return container.livenessProbe;
        }

        public static Probe WithReadinessProbe(this Container container)
        {
            if (container.readinessProbe == null) container.readinessProbe = new Probe();

            return container.readinessProbe;
        }

        public static Probe WithStartupProbe(this Container container)
        {
            if (container.startupProbe == null) container.startupProbe = new Probe();

            return container.startupProbe;
        }

        public static Container WithPort(this Container container, int containerPort, string name = null, string protocol = null)
        {
            var list = container.ports?.ToList() ?? new List<ContainerPort>();

            list.Add(new ContainerPort
            {
                containerPort = containerPort,
                name = name,
                protocol = protocol
            });

            container.ports = list;

            return container;
        }

        public static Container WithLimits(this Container container, string cpu = null, string memory = null)
        {
            if (container.resources == null) container.resources = new ResourceRequirements();

            container.resources.limits = new Dictionary<string, string>
            {
                { "cpu", cpu },
                { "memory", memory }
            };

            return container;
        }

        public static Container WithRequests(this Container container, string cpu = null, string memory = null)
        {
            if (container.resources == null) container.resources = new ResourceRequirements();

            container.resources.requests = new Dictionary<string, string>
            {
                { "cpu", cpu },
                { "memory", memory }
            };

            return container;
        }
    }
}
