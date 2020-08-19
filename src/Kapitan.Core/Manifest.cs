using k8s;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kapitan.Core
{
    public class Manifest : List<IKubernetesObject>
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
