using Kapitan.Configuration;
using Kapitan.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kapitan
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
            var config = new Dictionary<string, string>();
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
