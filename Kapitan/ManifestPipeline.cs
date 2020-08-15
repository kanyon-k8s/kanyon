using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Kapitan
{
    public class ManifestPipeline
    {
        private readonly ManifestProcessor processor;

        public ManifestPipeline(ManifestProcessor processor)
        {
            this.processor = processor;
        }

        public async Task ExecutePipeline(FileInfo file)
        {
            // Build args
            var loader = new ManifestLoader();
            var manifest = await loader.LoadManifest(file);

            var config = processor.BuildConfiguration();
            processor.Process(manifest, config);

            var serializer = new ManifestSerializer();
            var output = serializer.ProcessManifest(manifest);

            Console.WriteLine(output);
        }
    }
}
