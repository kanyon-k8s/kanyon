using System;
using System.Collections.Generic;
using System.Text;

namespace Kanyon.Core
{
    public interface IManifestObject
    {
        string ApiVersion { get; }
        string Kind { get; }
    }
}
