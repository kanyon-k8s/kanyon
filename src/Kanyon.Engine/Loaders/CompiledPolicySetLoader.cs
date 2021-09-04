using Kanyon.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Kanyon.Engine.Loaders
{
    public class CompiledPolicySetLoader : IPolicySetLoader
    {
        public string PolicySetName { get; set; }
        public FileInfo Source { get; set; }

        public async Task<IEnumerable<IPolicy>> Load()
        {
            var assembly = Assembly.LoadFrom(Source.FullName);
            Type policySetType = null;
            var attributes = assembly.GetCustomAttributes<KanyonPolicySetAttribute>();
            if (!string.IsNullOrEmpty(PolicySetName)) attributes = attributes.Where(attr => attr.Name == PolicySetName);

            if (attributes.Skip(1).Any()) throw new InvalidOperationException("Multiple policy sets were found. Please specify the policy set name using the --policy-set attribute");
            else if (!attributes.Any())
            {
                // No declared manifest type was detected, so we will load a manifest by convention
                // if it is the one and only one type inheriting from Manifest
                try
                {
                    policySetType = assembly.GetExportedTypes().Single(t => typeof(PolicySet).IsAssignableFrom(t));
                }
                catch (InvalidOperationException)
                {
                    throw new MissingManifestException("No policy set could be loaded from the provided assembly. Please make sure that either there is a single class inheriting from PolicySet publically available, or that the assembly is decorated with the KanyonPolicySetAttribute");
                }
            }
            else
            {
                policySetType = attributes.First().PolicySetType;
            }

            if (!typeof(PolicySet).IsAssignableFrom(policySetType))
            {
                throw new MissingManifestException("The type specified by the KanyonPolicySetAttribute is not a descendant of the PolicySet type");
            }
            else if (policySetType.GetConstructors().SingleOrDefault(ci => ci.GetParameters().Length == 0) == null)
            {
                throw new MissingManifestException("The specified PolicySet type has no parameterless constructors");
            }

            return Activator.CreateInstance(policySetType) as PolicySet;
        }
    }
}
