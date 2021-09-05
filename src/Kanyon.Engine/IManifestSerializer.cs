using Kanyon.Core;

namespace Kanyon
{
    public interface IManifestSerializer
    {
        string ProcessManifest(Manifest manifest);
    }
}