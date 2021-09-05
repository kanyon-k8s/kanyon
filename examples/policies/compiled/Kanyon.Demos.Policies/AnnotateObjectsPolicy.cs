using System;
using System.Collections.Generic;
using Kanyon.Core;

namespace Kanyon.Demos.Policies 
{
    public class AnnotateObjectsPolicy : IPolicy 
    {
        public void Evaluate(IManifestObject manifestObject, Dictionary<string, string> configuration)
            {
                dynamic resource = manifestObject;

                try {
                    if (resource.metadata.annotations == null) resource.metadata.annotations = new Dictionary<string, string>();
                        resource.metadata.annotations.Add("Kanyon.dev/manifest", configuration["Invocation.ManifestSource"]);
                }
                catch (Exception ex) { Console.Error.WriteLine(ex.Message); }
            }
    }
}