using Kanyon.Core;
using Kanyon.Engine.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kanyon
{
    public class ManifestProcessor
    {
        private readonly IEnumerable<IManifestConfigurationProvider> configProviders;

        public ManifestProcessor(IEnumerable<IManifestConfigurationProvider> configProviders)
        {
            this.configProviders = configProviders;
        }

        public Dictionary<string, string> BuildConfiguration()
        {
            var config = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            foreach (var configProvider in configProviders)
            {
                config = configProvider.Build(config);
            }

            return config;
        }

        public void Process(Manifest manifest, Dictionary<string, string> configuration)
        {
            manifest.ConfigureItems(configuration);
        }
    }
}
