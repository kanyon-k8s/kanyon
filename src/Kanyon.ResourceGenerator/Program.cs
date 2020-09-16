using Kanyon.ResourceGenerator.Heuristics;
using McMaster.Extensions.CommandLineUtils;
using Microsoft.OpenApi.Readers;
using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Kanyon.ResourceGenerator
{
    class Program
    {
        [Argument(0)]
        public string SwaggerFile { get; set; }
        [Option("-o")]
        public string OutputPath { get; set; }
        [Option("-g")]
        public string Group { get; set; }
        [Option("-a")]
        public string ApiVersion { get; set; }
        [Option("-c")]
        public string CrdSource { get; set; }

        public static async Task<int> Main(string[] args) => await CommandLineApplication.ExecuteAsync<Program>(args);

        public async System.Threading.Tasks.Task OnExecuteAsync()
        {
            var uri = SwaggerFile;

            if (string.IsNullOrEmpty(OutputPath)) OutputPath = Environment.CurrentDirectory;

            // TODO: allow local or HTTP
            using (var stream = File.OpenRead(uri))
            {
                (var apiVersionProvider, var heuristic) = await BuildGenerationProfile();
                var typeManager = new TypeDefinitionManager(heuristic, apiVersionProvider);
                var classGenerator = new ClassGenerator(new DirectoryInfo(OutputPath));
                await classGenerator.InitializeAsync();

                var spec = new OpenApiStreamReader().Read(stream, out var diagnostic);

                // Get list of root types
                var definitions = typeManager.BuildTypeDefinitions(spec);
                foreach (var definition in definitions)
                {
                    Console.WriteLine($"Writing {Path.Combine(OutputPath, definition.Directory ?? "", definition.TypeName)}.cs");
                    await classGenerator.WriteCodeFileAsync(definition);
                }

                Console.WriteLine("Finished!");
            }
        }

        private async Task<(IApiVersionProvider ApiVersionProvider, IManifestObjectHeuristic Heuristic)> BuildGenerationProfile()
        {
            IApiVersionProvider provider = new OpenApiExtensionApiVersionProvider();
            IManifestObjectHeuristic heuristic = new KubernetesExtensionManifestObjectHeuristic();

            if (!string.IsNullOrEmpty(Group) && !string.IsNullOrEmpty(ApiVersion))
            {
                provider = new ConfigurationBasedApiVersionProvider(Group, ApiVersion);
                
                if (!string.IsNullOrWhiteSpace(CrdSource))
                {
                    var crdHeuristic = new CrdTypeMatchManifestObjectHeuristic();
                    await crdHeuristic.InitializeAsync(CrdSource);
                    heuristic = crdHeuristic;
                }
                else
                {
                    heuristic = new RequiredPropertyManifestObjectHeuristic();
                }
            }            

            return (provider, heuristic);
        }
    }
}
