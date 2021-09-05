using Kanyon.Core;

namespace Kanyon.Filters
{
    public interface IManifestFilter
    {
        bool Filter(IManifestObject manifestObject);
    }
}