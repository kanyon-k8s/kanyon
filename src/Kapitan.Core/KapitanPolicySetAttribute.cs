using System;
using System.Collections.Generic;
using System.Text;

namespace Kapitan.Core
{
    [AttributeUsage(AttributeTargets.Assembly)]
    public class KapitanPolicySetAttribute : Attribute
    {
        public KapitanPolicySetAttribute(Type policySetType)
        {
            PolicySetType = policySetType;
        }

        public Type PolicySetType { get; set; }

        /// <summary>
        /// The Name of the PolicySet attribute can be used to choose a specific policy set from a compiled library
        /// </summary>
        public string Name { get; set; }
    }
}
