using System;
using System.Collections.Generic;
using System.Text;

namespace Kanyon.Core
{
    public interface IPolicy
    {
        void Evaluate(IManifestObject manifestObject, Dictionary<string, string> configuration);
    }
}
