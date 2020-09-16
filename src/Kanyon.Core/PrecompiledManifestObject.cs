using System;
using System.Collections.Generic;
using System.Text;

namespace Kanyon.Core
{
    public class PrecompiledManifestObject : IManifestObject
    {
        public string ApiVersion => "github.com/ermontgo/kapitan/v1alpha1";

        public string Kind => nameof(PrecompiledManifestObject);

        public string ManifestOutput { get; set; }
    }
}
