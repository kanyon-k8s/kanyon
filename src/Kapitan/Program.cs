using Kapitan.Configuration;
using Kapitan.Filters;
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

        [Option("-v")]
        public bool Verbose { get; set; }

        [Option("--emit-crds")]
        public CrdEmitOptions EmitCrds { get; set; }

        private async System.Threading.Tasks.Task OnExecuteAsync()
        {
            if (!File.Exists(ManifestSource))
            {
                Console.Error.WriteLine($"Could not find manifest {ManifestSource}. Exiting...");
                return;
            }

            var providers = new List<IManifestConfigurationProvider>()
            {
                new EnvironmentManifestConfigurationProvider()
            };

            if (Configuration != null && Configuration.Any())
            {
                providers.Add(new ArgumentManifestConfigurationProvider(Configuration));
            }

            var processor = new ManifestProcessor(providers);
            var loader = new ManifestLoader() { Verbose = Verbose };
            var filter = ManifestFilterFactory.BuildManifestFilter(EmitCrds);
            var serializer = new ManifestSerializer(filter);
            var pipeline = new ManifestPipeline(processor, loader, serializer);
            await pipeline.ExecutePipeline(new System.IO.FileInfo(ManifestSource));
        }
    }
}
