using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace Kapitan.Configuration
{
    public class EnvironmentManifestConfigurationProvider : IManifestConfigurationProvider
    {
        public Dictionary<string, string> Build(Dictionary<string, string> values)
        {
            var envVars = Environment.GetEnvironmentVariables();
            foreach (DictionaryEntry env in envVars)
            {
                values.Add(env.Key.ToString(), env.Value.ToString());
            }

            return values;
        }
    }
}
