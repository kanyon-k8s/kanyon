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
        private readonly ManifestSerializer serializer;

        public ManifestPipeline(ManifestProcessor processor, ManifestLoader loader, ManifestSerializer serializer)
        {
            this.processor = processor;
            this.loader = loader;
            this.serializer = serializer;
        }

        public async Task ExecutePipeline(FileInfo file)
        {
            var manifest = await loader.LoadManifest(file);

            var config = processor.BuildConfiguration();
            processor.Process(manifest, config);

            var output = serializer.ProcessManifest(manifest);

            Console.WriteLine(output);
        }
    }
}
