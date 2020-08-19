using System;
using System.Collections.Generic;
using System.Text;

namespace Kapitan.Kubernetes
{
    public partial class IntOrString
    {
        public IntOrString(string value = default)
        {
            Value = value;
        }

        public string Value { get; }

        public static implicit operator int(IntOrString v)
        {
            return int.Parse(v.Value);
        }

        public static implicit operator IntOrString(int v)
        {
            return new IntOrString(Convert.ToString(v));
        }

        public static implicit operator string(IntOrString v)
        {
            return v.Value;
        }

        public static implicit operator IntOrString(string v)
        {
            return new IntOrString(v);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (!(obj is IntOrString sibling))
            {
                return false;
            }

            return string.Equals(Value, sibling.Value);
        }

        public override int GetHashCode()
        {
            return (Value != null ? Value.GetHashCode() : 0);
        }
    }
}
