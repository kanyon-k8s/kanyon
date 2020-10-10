using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Kanyon.Core
{

    public abstract class ConfiguredManifest<T> : Manifest, IHelpTextProvider where T: new()
    {
        public override void ConfigureItems(Dictionary<string, string> configuration)
        {
            var configurationType = typeof(T);
            var serializedConfiguration = new T();
            var properties = configurationType.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var property in properties)
            {
                var configKey = property.Name;
                var metadata = property.GetCustomAttribute<ConfigurationMetadataAttribute>();
                if (metadata != null)
                {
                    configKey = metadata.Key;
                }

                if (configuration.ContainsKey(configKey))
                {
                    property.SetValue(serializedConfiguration, configKey);
                }
            }

            ConfigureItems(serializedConfiguration);
        }

        public IEnumerable<HelpText> GetHelpText()
        {
            var configurationType = typeof(T);
            var properties = configurationType.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var helpText = properties.Select(pi => pi.GetCustomAttribute<ConfigurationMetadataAttribute>() ?? new ConfigurationMetadataAttribute() { Key = pi.Name }).Select(cma => new HelpText() { ConfigValue = cma.Key, Description = cma.Description });

            return helpText;
        }

        public abstract void ConfigureItems(T configuration);
    }
}
