using Kanyon.Engine.Loaders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Kanyon
{
    public class ManifestPipeline : IManifestPipeline
    {
        private readonly IManifestConfigurationProcessor processor;
        private readonly IManifestLoader loader;
        private readonly IManifestSerializer serializer;
        private readonly IPolicySetEvaluator policySet;

        public ManifestPipeline(IManifestConfigurationProcessor processor, IManifestLoader loader, IManifestSerializer serializer, IPolicySetEvaluator policySet)
        {
            this.processor = processor;
            this.loader = loader;
            this.serializer = serializer;
            this.policySet = policySet;
        }

        public async Task<string> ExecutePipeline()
        {
            var manifest = await loader.LoadManifest();

            var config = processor.BuildConfiguration();
            processor.Process(manifest, config);

            await policySet.Evaluate(manifest, config);

            var output = serializer.ProcessManifest(manifest);

            return output;
        }
    }
}
