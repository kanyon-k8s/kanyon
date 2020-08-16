using Kapitan.Configuration;
using McMaster.Extensions.CommandLineUtils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Kapitan
{
    class Program
    {
        public static async Task<int> Main(string[] args) => await CommandLineApplication.ExecuteAsync<Program>(args);

        [Option("-c")]
        public string[] Configuration { get; set; }

        [Option("-f")]
        public string ManifestSource { get; set; }

        private async System.Threading.Tasks.Task OnExecuteAsync()
        {
            var providers = new List<IManifestConfigurationProvider>()
            {
                new EnvironmentManifestConfigurationProvider()
            };

            if (Configuration != null && Configuration.Any())
            {
                providers.Add(new ArgumentManifestConfigurationProvider(Configuration));
            }

            var processor = new ManifestProcessor(providers);
            var pipeline = new ManifestPipeline(processor);
            await pipeline.ExecutePipeline(new System.IO.FileInfo(ManifestSource));
        }
    }
}
