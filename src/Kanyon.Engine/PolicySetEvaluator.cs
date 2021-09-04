using Kanyon.Core;
using Kanyon.Engine.Loaders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Kanyon
{
    public class PolicySetEvaluator
    {
        private readonly IPolicySetLoader loader;

        public PolicySetEvaluator(IPolicySetLoader loader)
        {
            this.loader = loader;
        }

        public async Task Evaluate(Manifest manifest, Dictionary<string, string> configuration)
        {
            if (loader != null)
            {
                var policySet = await loader.Load();
                if (policySet != null)
                {
                    foreach (IPolicy policy in policySet)
                    {
                        foreach (IManifestObject obj in manifest)
                        {
                            policy.Evaluate(obj, configuration);
                        }
                    }
                }
            }
        }
    }
}
