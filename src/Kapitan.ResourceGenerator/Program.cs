using Microsoft.OpenApi.Readers;
using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace Kapitan.ResourceGenerator
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            var uri = args[0];

            // TODO: allow local or HTTP
            using (var stream = File.OpenRead(uri))
            {
                var typeManager = new TypeDefinitionManager();
                var classGenerator = new ClassGenerator(new DirectoryInfo(args[1]));
                await classGenerator.InitializeAsync();

                var spec = new OpenApiStreamReader().Read(stream, out var diagnostic);

                // Get list of root types
                var definitions = typeManager.BuildTypeDefinitions(spec);
                foreach (var definition in definitions)
                {
                    Console.WriteLine($"Writing {Path.Combine(args[1], definition.Directory ?? "", definition.TypeName)}.cs");
                    await classGenerator.WriteCodeFileAsync(definition);
                }

                Console.WriteLine("Finished!");
            }
        }
    }
}
