using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class NodeSystemInfo
    {
        /** <summary>The Architecture reported by the node</summary> */
        public string architecture { get; set; }
        /** <summary>Boot ID reported by the node.</summary> */
        public string bootID { get; set; }
        /** <summary>ContainerRuntime Version reported by the node through runtime remote API (e.g. docker://1.5.0).</summary> */
        public string containerRuntimeVersion { get; set; }
        /** <summary>Kernel Version reported by the node from 'uname -r' (e.g. 3.16.0-0.bpo.4-amd64).</summary> */
        public string kernelVersion { get; set; }
        /** <summary>KubeProxy Version reported by the node.</summary> */
        public string kubeProxyVersion { get; set; }
        /** <summary>Kubelet Version reported by the node.</summary> */
        public string kubeletVersion { get; set; }
        /** <summary>MachineID reported by the node. For unique machine identification in the cluster this field is preferred. Learn more from man(5) machine-id: http://man7.org/linux/man-pages/man5/machine-id.5.html</summary> */
        public string machineID { get; set; }
        /** <summary>The Operating System reported by the node</summary> */
        public string operatingSystem { get; set; }
        /** <summary>OS Image reported by the node from /etc/os-release (e.g. Debian GNU/Linux 7 (wheezy)).</summary> */
        public string osImage { get; set; }
        /** <summary>SystemUUID reported by the node. For unique machine identification MachineID is preferred. This field is specific to Red Hat hosts https://access.redhat.com/documentation/en-us/red_hat_subscription_management/1/html/rhsm/uuid</summary> */
        public string systemUUID { get; set; }
    }
}