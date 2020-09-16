using Kapitan.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Kapitan.Loaders
{
    public class CompiledManifestLoader : IManifestLoader
    {
        public async Task<Manifest> LoadManifest(FileInfo file)
        {
            var assembly = Assembly.LoadFrom(file.FullName);
            var manifestType = assembly.GetCustomAttribute<KapitanManifestAttribute>()?.ManifestType;

            if (manifestType == null)
            {
                // No declared manifest type was detected, so we will load a manifest by convention
                // if it is the one and only one type inheriting from Manifest
                try
                {
                    manifestType = assembly.GetExportedTypes().Single(t => typeof(Manifest).IsAssignableFrom(t));
                }
                catch (InvalidOperationException iopEx)
                {
                    throw new MissingManifestException("No manifest could be loaded from the provided assembly. Please make sure that either there is a single class inheriting from Manifest publically available, or that the assembly is decorated with the KapitanManifestAttribute");
                }
            }
            else if (!typeof(Manifest).IsAssignableFrom(manifestType))
            {
                throw new MissingManifestException("The type specified by the KapitanManifestAttribute is not a descendant of the Manifest type");
            }
            else if (manifestType.GetConstructors().SingleOrDefault(ci => ci.GetParameters().Length == 0) == null)
            {
                throw new MissingManifestException("The specified Manifest type has no parameterless constructors");
            }

            return Activator.CreateInstance(manifestType) as Manifest;
        }
    }
}
