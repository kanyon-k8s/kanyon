using System;
using System.Collections.Generic;
using System.Text;

namespace Kanyon.Core
{
    public class PolicySet : List<IPolicy>
    {
        public void Add(PolicySet policies)
        {
            AddRange(policies);
        }
    }
}
