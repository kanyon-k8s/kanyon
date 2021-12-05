using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Kanyon.Engine.Configuration
{
    public class EnhancedEnvFileManifestConfigurationProvider : IManifestConfigurationProvider
    {
        private readonly string filePath;
        private DotNetEnv.LoadOptions options;

        public EnhancedEnvFileManifestConfigurationProvider(string filePath, bool traverse)
        {
            this.filePath = filePath;
            options = new DotNetEnv.LoadOptions(false, onlyExactPath: !traverse);
        }
        public Dictionary<string, string> Build(Dictionary<string, string> values)
        {
            var newValues = DotNetEnv.Env.Load(filePath, options);

            foreach (var value in newValues) {
                values[value.Key] = value.Value;
            }

            return values;
        }
    }
}
