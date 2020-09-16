using System;
using System.Collections.Generic;
using System.Text;

namespace Kanyon.Configuration
{
    public class ArgumentManifestConfigurationProvider : IManifestConfigurationProvider
    {
        private readonly string[] args;

        public ArgumentManifestConfigurationProvider(string[] args)
        {
            this.args = args;
        }

        public Dictionary<string, string> Build(Dictionary<string, string> values)
        {
            foreach (var arg in args)
            {
                var idx = arg.IndexOf("=");
                var key = arg.Substring(0, idx);
                var value = arg.Substring(idx + 1);

                values.Add(key, value);
            }

            return values;
        }
    }
}
