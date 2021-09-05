using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Kanyon.Engine.Configuration
{
    public class EnvFileManifestConfigurationProvider : IManifestConfigurationProvider
    {
        private readonly string filePath;

        public EnvFileManifestConfigurationProvider(string filePath)
        {
            this.filePath = filePath;
        }
        public Dictionary<string, string> Build(Dictionary<string, string> values)
        {
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var idx = line.IndexOf("=");
                var key = line.Substring(0, idx);
                var value = line.Substring(idx + 1);

                values.Add(key, value);
            }

            return values;
        }
    }
}
