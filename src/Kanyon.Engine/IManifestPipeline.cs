using System.Threading.Tasks;

namespace Kanyon
{
    public interface IManifestPipeline
    {
        Task<string> ExecutePipeline();
    }
}