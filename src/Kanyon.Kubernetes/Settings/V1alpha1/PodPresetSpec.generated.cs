using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Settings.V1alpha1
{
    public partial class PodPresetSpec
    {
        /** <summary>Env defines the collection of EnvVar to inject into containers.</summary> */
        public IEnumerable<Core.V1.EnvVar> env { get; set; }
        /** <summary>EnvFrom defines the collection of EnvFromSource to inject into containers.</summary> */
        public IEnumerable<Core.V1.EnvFromSource> envFrom { get; set; }
        /** <summary>A label selector is a label query over a set of resources. The result of matchLabels and matchExpressions are ANDed. An empty label selector matches all objects. A null label selector matches no objects.</summary> */
        public Core.V1.LabelSelector selector { get; set; }
        /** <summary>VolumeMounts defines the collection of VolumeMount to inject into containers.</summary> */
        public IEnumerable<Core.V1.VolumeMount> volumeMounts { get; set; }
        /** <summary>Volumes defines the collection of Volume to inject into the pod.</summary> */
        public IEnumerable<Core.V1.Volume> volumes { get; set; }
    }
}