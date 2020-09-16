using Kanyon.Core;
using Kanyon.Kubernetes.Core.V1;

namespace Kanyon.Kubernetes
{
    public class ThirdPartyResource : IManifestObject
    {
        public string ApiVersion { get; set; }
        public string Kind { get; set; }
        public ObjectMeta metadata { get; set; }
        public object spec { get; set; }
    }
}
