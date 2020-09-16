using Kapitan.Core;
using Kapitan.Kubernetes.Core.V1;

namespace Kapitan.Kubernetes
{
    public class ThirdPartyResource : IManifestObject
    {
        public string ApiVersion { get; set; }
        public string Kind { get; set; }
        public ObjectMeta metadata { get; set; }
        public object spec { get; set; }
    }
}
