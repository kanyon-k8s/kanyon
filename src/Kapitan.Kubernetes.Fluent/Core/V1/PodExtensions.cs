using Kapitan.Kubernetes.Core.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kapitan.Kubernetes.Fluent.Core.V1
{
    public static class PodExtensions
    {
        public static PodSpec WithVolume(this PodSpec pod, Volume volume)
        {
            if (pod.volumes == null) pod.volumes = new List<Volume>();

            var list = pod.volumes.ToList();
            list.Add(volume);

            pod.volumes = list;

            return pod;
        }

        public static PodSpec WithVolume(this Pod pod, Volume volume) { return pod.spec.WithVolume(volume); }

        public static PodSpec WithImagePullSecret(this PodSpec pod, string imagePullSecretName)
        {
            if (pod.imagePullSecrets == null) pod.imagePullSecrets = new List<LocalObjectReference>();
            var list = pod.imagePullSecrets.ToList();
            list.Add(new LocalObjectReference() { name = imagePullSecretName });

            pod.imagePullSecrets = list;

            return pod;
        }

        public static PodSpec WithImagePullSecret(this Pod pod, string imagePullSecretName) { return pod.spec.WithImagePullSecret(imagePullSecretName); }

        public static PodSpec WithRestartPolicy(this PodSpec pod, string restartPolicy)
        {
            pod.restartPolicy = restartPolicy;

            return pod;
        }

        public static PodSpec WithRestartPolicy(this Pod pod, string restartPolicy) { return pod.spec.WithRestartPolicy(restartPolicy); }

        public static PodSpec WithServiceAccountName(this PodSpec pod, string serviceAccountName)
        {
            pod.serviceAccountName = serviceAccountName;

            return pod;
        }

        public static PodSpec WithServiceAccountName(this Pod pod, string serviceAccountName) { return pod.spec.WithServiceAccountName(serviceAccountName); }

        public static PodSpec WithTerminationGracePeriodSeconds(this PodSpec pod, int terminationGracePeriodSeconds)
        {
            pod.terminationGracePeriodSeconds = terminationGracePeriodSeconds;

            return pod;
        }

        public static PodSpec WithTerminationGracePeriodSeconds(this Pod pod, int terminationGracePeriodSeconds) { return pod.spec.WithTerminationGracePeriodSeconds(terminationGracePeriodSeconds); }

        public static Container WithContainer(this PodSpec pod, string name)
        {
            if (pod.containers == null) pod.containers = new List<Container>();

            Container container = pod.containers.Where(c => c.name == name).FirstOrDefault();
            if (container == null)
            {
                var list = pod.containers.ToList();
                list.Add(container = new Container() { name = name });

                pod.containers = list;
            }

            return container;
        }

        public static Container WithContainer(this Pod pod, string name) { return pod.spec.WithContainer(name); }

        public static Container WithInitContainer(this PodSpec pod, string name)
        {
            if (pod.initContainers == null) pod.initContainers = new List<Container>();

            Container container = pod.initContainers.Where(c => c.name == name).FirstOrDefault();
            if (container == null)
            {
                var list = pod.initContainers.ToList();
                list.Add(container = new Container() { name = name });

                pod.initContainers = list;
            }

            return container;
        }

        public static Container WithInitContainer(this Pod pod, string name) { return pod.spec.WithInitContainer(name); }
    }
}
