using Kapitan.Loaders;
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
        private readonly IManifestLoader loader;
        private readonly ManifestSerializer serializer;
        private readonly PolicySetEvaluator policySet;

        public ManifestPipeline(ManifestProcessor processor, IManifestLoader loader, ManifestSerializer serializer, PolicySetEvaluator policySet)
        {
            this.processor = processor;
            this.loader = loader;
            this.serializer = serializer;
            this.policySet = policySet;
        }

        public async Task ExecutePipeline(FileInfo file)
        {
            var manifest = await loader.LoadManifest(file);

            var config = processor.BuildConfiguration();
            processor.Process(manifest, config);

            await policySet.Evaluate(manifest, config);

            var output = serializer.ProcessManifest(manifest);

            Console.WriteLine(output);
        }
    }
}
