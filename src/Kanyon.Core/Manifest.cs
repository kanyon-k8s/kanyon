using System.Collections.Generic;
using System.Linq;

namespace Kanyon.Core
{
    public class Manifest : List<IManifestObject>
    {
        public virtual void ConfigureItems(Dictionary<string, string> configuration)
        {
            
        }

        public virtual IEnumerable<HelpText> GetHelpText()
        {
            return Enumerable.Empty<HelpText>();
        }

        public void Add(Manifest item)
        {
            AddRange(item);
        }
    }
}
