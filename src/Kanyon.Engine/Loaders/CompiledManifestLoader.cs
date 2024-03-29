﻿using Kanyon.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Kanyon.Engine.Loaders
{
    public class CompiledManifestLoader : IManifestLoader
    {
        protected Assembly assembly;

        public CompiledManifestLoader FromFile(FileInfo file)
        {
            assembly = Assembly.LoadFrom(file.FullName);

            return this;
        }

        public CompiledManifestLoader FromBytes(byte[] assemblyBytes)
        {
            assembly = Assembly.Load(assemblyBytes);

            return this;
        }

        public virtual Task<Manifest> LoadManifest()
        {
            if (assembly == null) throw new ArgumentException("No assembly was loaded");
            var manifestType = assembly.GetCustomAttribute<KanyonManifestAttribute>()?.ManifestType;

            if (manifestType == null)
            {
                // No declared manifest type was detected, so we will load a manifest by convention
                // if it is the one and only one type inheriting from Manifest
                try
                {
                    manifestType = assembly.GetExportedTypes().Single(t => typeof(Manifest).IsAssignableFrom(t));
                }
                catch (InvalidOperationException)
                {
                    throw new MissingManifestException("No manifest could be loaded from the provided assembly. Please make sure that either there is a single class inheriting from Manifest publically available, or that the assembly is decorated with the KanyonManifestAttribute");
                }
            }
            else if (!typeof(Manifest).IsAssignableFrom(manifestType))
            {
                throw new MissingManifestException("The type specified by the KanyonManifestAttribute is not a descendant of the Manifest type");
            }
            else if (manifestType.GetConstructors().SingleOrDefault(ci => ci.GetParameters().Length == 0) == null)
            {
                throw new MissingManifestException("The specified Manifest type has no parameterless constructors");
            }

            return Task.FromResult(Activator.CreateInstance(manifestType) as Manifest);
        }
    }
}
