using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace KanyonVSIX.ViewModels
{
    public class ConfigurationItemViewModel : ObservableObject
    {
        private string key;
        public string Key
        {
            get => key;
            set => SetProperty(ref key, value);
        }

        private string configValue;
        public string ConfigValue
        {
            get => configValue;
            set => SetProperty(ref configValue, value);
        }

        private string description;
        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }
    }
}