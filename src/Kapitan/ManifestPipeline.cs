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
        private readonly ManifestLoader loader;

        public ManifestPipeline(ManifestProcessor processor, ManifestLoader loader)
        {
            this.processor = processor;
            this.loader = loader;
        }

        public async Task ExecutePipeline(FileInfo file)
        {
            var manifest = await loader.LoadManifest(file);

            var config = processor.BuildConfiguration();
            processor.Process(manifest, config);

            var serializer = new ManifestSerializer();
            var output = serializer.ProcessManifest(manifest);

            Console.WriteLine(output);
        }
    }
}
