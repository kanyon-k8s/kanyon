using System;
using System.Collections.Generic;
using System.Text;

namespace Kapitan.Core
{
    public class PolicySet : List<IPolicy>
    {
        public void Add(PolicySet policies)
        {
            AddRange(policies);
        }
    }
}
