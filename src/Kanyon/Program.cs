using Kanyon.Configuration;
using Kanyon.Core;
using Kanyon.Filters;
using Kanyon.Loaders;
using McMaster.Extensions.CommandLineUtils;
using McMaster.Extensions.CommandLineUtils.HelpText;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Kanyon
{
    [SuppressDefaultHelpOption]
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

        [Option("-h|-?|--help")]
        public bool IsHelpRequested { get; set; }

        [Option("-w|--wait")]
        public bool WaitAfterCompletion { get; set; }

        [Option("-e|--env-file")]
        public string EnvFile { get; set; }

        private async Task EvaluateHelp(CommandLineApplication app)
        {
            // Write Default Help
            app.ShowHelp();

            if (!string.IsNullOrWhiteSpace(ManifestSource))
            {
                var loader = BuildManifestLoader();

                var manifest = await loader.LoadManifest();
                var provider = manifest as IHelpTextProvider;

                Console.WriteLine();
                Console.WriteLine("Manifest Configuration:");

                var helpTextList = provider.GetHelpText();
                foreach (var helpText in helpTextList)
                {
                    Console.WriteLine($"  {helpText.ConfigValue}\t\t{helpText.Description}");
                }
            }
        }

        private IManifestLoader BuildManifestLoader()
        {
            var manifestFile = new FileInfo(ManifestSource);
            if (!manifestFile.Exists && !Uri.IsWellFormedUriString(ManifestSource, UriKind.Absolute))
            {
                Console.Error.WriteLine($"Could not find manifest {ManifestSource}. Exiting...");
                return null;
            }

            var loader = ManifestLoaderFactory.BuildManifestLoader(ManifestSource, Verbose);

            return loader;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0051:Remove unused private members", Justification = "Used by reflection")]
        private async Task OnExecuteAsync(CommandLineApplication app)
        {
            try
            {
                if (IsHelpRequested)
                {
                    await EvaluateHelp(app);
                    return;
                }

                var loader = BuildManifestLoader();
                if (loader == null) return;
                List<IManifestConfigurationProvider> providers = BuildConfiguration();

                IPolicySetLoader policyLoader = null;
                if (!string.IsNullOrEmpty(PolicySetSource)) policyLoader = PolicySetLoaderFactory.BuildPolicySetLoader(PolicySetSource, Verbose, PolicySetName);
                PolicySetEvaluator policyEvaluator = new PolicySetEvaluator(policyLoader);

                var processor = new ManifestProcessor(providers);
                var filter = ManifestFilterFactory.BuildManifestFilter(EmitCrds);
                var serializer = new ManifestSerializer(filter);
                var pipeline = new ManifestPipeline(processor, loader, serializer, policyEvaluator);
                await pipeline.ExecutePipeline();
            }
            catch (Exception ex)
            {
                if (Verbose) Console.Error.WriteLine(ex.ToString());
                else Console.Error.WriteLine(ex.Message);

                Environment.ExitCode = -1;
            }
            finally
            {
                if (WaitAfterCompletion)
                {
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            }
        }

        private List<IManifestConfigurationProvider> BuildConfiguration()
        {
            var providers = new List<IManifestConfigurationProvider>()
                {
                    new GlobalOptionsManifestConfigurationProvider(this),
                    new EnvironmentManifestConfigurationProvider()
                };

            if (Configuration != null && Configuration.Any())
            {
                providers.Add(new ArgumentManifestConfigurationProvider(Configuration));
            }

            if (!string.IsNullOrEmpty(EnvFile))
            {
                providers.Add(new EnvFileManifestConfigurationProvider(EnvFile));
            }

            return providers;
        }
    }
}
