using Kanyon.Core;
using System.Collections.Generic;

namespace Kanyon
{
    public interface IManifestConfigurationProcessor
    {
        Dictionary<string, string> BuildConfiguration();
        void Process(Manifest manifest, Dictionary<string, string> configuration);
    }
}