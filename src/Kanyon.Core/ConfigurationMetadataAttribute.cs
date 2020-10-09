using System;

namespace Kanyon.Core
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ConfigurationMetadataAttribute : Attribute
    {
        public string Key { get; set; }
        public string Description { get; set; }
    }
}