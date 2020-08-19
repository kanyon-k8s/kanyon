using Kapitan.Core;
using Kapitan.Kubernetes.Core.V1;

namespace Kapitan.Kubernetes
{
    public class ThirdPartyResource : IManifestObject
    {
        public string apiVersion { get; set; }
        public string kind { get; set; }
        public ObjectMeta metadata { get; set; }
        public object spec { get; set; }
    }
}
