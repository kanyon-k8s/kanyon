using System.Collections.Generic;

namespace Kapitan.Configuration
{
    public interface IManifestConfigurationProvider
    {
        Dictionary<string, string> Build(Dictionary<string, string> values);
    }
}