using Kapitan.Core;
using System.IO;
using System.Threading.Tasks;

namespace Kapitan.Loaders
{
    public interface IManifestLoader
    {
        Task<Manifest> LoadManifest(FileInfo file);
    }
}