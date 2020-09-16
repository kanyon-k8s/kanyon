using Kapitan.Core;

namespace Kapitan.Filters
{
    public interface IManifestFilter
    {
        bool Filter(IManifestObject manifestObject);
    }
}