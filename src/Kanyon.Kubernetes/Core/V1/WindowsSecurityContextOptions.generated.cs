using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class WindowsSecurityContextOptions
    {
        /** <summary>GMSACredentialSpec is where the GMSA admission webhook (https://github.com/kubernetes-sigs/windows-gmsa) inlines the contents of the GMSA credential spec named by the GMSACredentialSpecName field.</summary> */
        public string gmsaCredentialSpec { get; set; }
        /** <summary>GMSACredentialSpecName is the name of the GMSA credential spec to use.</summary> */
        public string gmsaCredentialSpecName { get; set; }
        /** <summary>The UserName in Windows to run the entrypoint of the container process. Defaults to the user specified in image metadata if unspecified. May also be set in PodSecurityContext. If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.</summary> */
        public string runAsUserName { get; set; }
    }
}