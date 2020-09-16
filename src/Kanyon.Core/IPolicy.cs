using System;
using System.Collections.Generic;
using System.Text;

namespace Kapitan.Core
{
    public interface IPolicy
    {
        void Evaluate(IManifestObject manifestObject, Dictionary<string, string> configuration);
    }
}
