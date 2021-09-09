using Kanyon.Engine.Configuration;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace KanyonVSIX.ViewModels
{
    public class ViewModelConfigurationProvider : IManifestConfigurationProvider
    {
        private Dictionary<string, string> config;

        public ViewModelConfigurationProvider(ObservableCollection<ConfigurationItemViewModel> viewmodels)
        {
            config = viewmodels.ToDictionary(civm => civm.Key, civm => civm.ConfigValue);
        }

        public Dictionary<string, string> Build(Dictionary<string, string> values)
        {
            foreach (var value in config)
            {
                values.Add(value.Key, value.Value);
            }

            return values;
        }
    }
}
