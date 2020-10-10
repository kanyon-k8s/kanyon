using System.Collections.Generic;
using System.Linq;

namespace Kanyon.Core
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
