using System.Collections.Generic;

namespace Kanyon.Engine.Configuration
{
    public interface IManifestConfigurationProvider
    {
        Dictionary<string, string> Build(Dictionary<string, string> values);
    }
}