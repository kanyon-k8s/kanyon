using Kanyon.Core;
using System.IO;
using System.Threading.Tasks;

namespace Kanyon.Loaders
{
    public interface IManifestLoader
    {
        Task<Manifest> LoadManifest(FileInfo file);
    }
}