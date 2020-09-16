using Kanyon.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kanyon.Kubernetes
{
    public partial class IntOrString : WrappedString
    {
        public IntOrString(string value = default) : base(value)
        {

        }

        public static implicit operator int(IntOrString v)
        {
            return int.Parse(v.Value);
        }

        public static implicit operator IntOrString(int v)
        {
            return new IntOrString(Convert.ToString(v));
        }
    }
}
