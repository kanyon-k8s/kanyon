using System.Collections.Generic;

namespace Kanyon.Configuration
{
    public interface IManifestConfigurationProvider
    {
        Dictionary<string, string> Build(Dictionary<string, string> values);
    }
}