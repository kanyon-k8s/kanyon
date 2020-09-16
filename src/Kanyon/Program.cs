using Kanyon.Configuration;
using Kanyon.Filters;
using Kanyon.Loaders;
using McMaster.Extensions.CommandLineUtils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Kanyon
{
    public class Program
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

        [Option("-p")]
        public string PolicySetSource { get; set; }

        [Option("--policy-set")]
        public string PolicySetName { get; set; }

        private async System.Threading.Tasks.Task OnExecuteAsync()
        {
            var manifestFile = new FileInfo(ManifestSource);
            if (!manifestFile.Exists)
            {
                Console.Error.WriteLine($"Could not find manifest {ManifestSource}. Exiting...");
                return;
            }

            var providers = new List<IManifestConfigurationProvider>()
            {
                new GlobalOptionsManifestConfigurationProvider(this),
                new EnvironmentManifestConfigurationProvider()
            };

            if (Configuration != null && Configuration.Any())
            {
                providers.Add(new ArgumentManifestConfigurationProvider(Configuration));
            }

            PolicySetEvaluator policyEvaluator = null;
            IPolicySetLoader policyLoader = null;
            if (!string.IsNullOrEmpty(PolicySetSource)) policyLoader = PolicySetLoaderFactory.BuildPolicySetLoader(new FileInfo(PolicySetSource), Verbose, PolicySetName);
            policyEvaluator = new PolicySetEvaluator(policyLoader);

            var processor = new ManifestProcessor(providers);
            var loader = ManifestLoaderFactory.BuildManifestLoader(manifestFile, Verbose);
            var filter = ManifestFilterFactory.BuildManifestFilter(EmitCrds);
            var serializer = new ManifestSerializer(filter);
            var pipeline = new ManifestPipeline(processor, loader, serializer, policyEvaluator);
            await pipeline.ExecutePipeline(manifestFile);
        }
    }
}
