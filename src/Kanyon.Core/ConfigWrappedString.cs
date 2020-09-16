using System;
using System.Collections.Generic;
using System.Text;

namespace Kanyon.Core
{
    public class ConfigWrappedString : WrappedString
    {
        public ConfigWrappedString(string value = default) : base(value) { }

        public static implicit operator string(ConfigWrappedString v)
        {
            return v.Value;
        }

        public static implicit operator ConfigWrappedString(string v)
        {
            if (string.IsNullOrEmpty(v)) return null;

            return new ConfigWrappedString(v);
        }

        public string ConfigKey { get; set; }

        public static ConfigWrappedString FromConfig(string key)
        {
            return new ConfigWrappedString() { ConfigKey = key };
        }

        public string GetValue(Dictionary<string, string> config)
        {
            return string.IsNullOrEmpty(Value) ? config[ConfigKey] : Value;
        }
    }
}
