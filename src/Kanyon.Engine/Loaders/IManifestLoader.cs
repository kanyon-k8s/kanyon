using Kanyon.Core;
using System.IO;
using System.Threading.Tasks;

namespace Kanyon.Engine.Loaders
{
    public interface IManifestLoader
    {
        Task<Manifest> LoadManifest();
    }
}