using System.Collections.Generic;

namespace Kapitan.Core
{
    public class Manifest : List<IManifestObject>
    {
        public virtual void ConfigureItems(Dictionary<string, string> configuration)
        {
            
        }

        public void Add(Manifest item)
        {
            AddRange(item);
        }
    }
}
