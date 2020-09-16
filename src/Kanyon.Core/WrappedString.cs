using System;
using System.Collections.Generic;
using System.Text;

namespace Kanyon.Core
{
    public class WrappedString
    {
        public WrappedString(string value = default)
        {
            Value = value;
        }

        public string Value { get; }

        public static implicit operator string(WrappedString v)
        {
            return v.Value;
        }

        public static implicit operator WrappedString(string v)
        {
            if (string.IsNullOrEmpty(v)) return null;

            return new WrappedString(v);
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

            if (!(obj is WrappedString sibling))
            {
                return false;
            }

            return string.Equals(Value, sibling.Value);
        }

        public override int GetHashCode()
        {
            return Value != null ? Value.GetHashCode() : 0;
        }
    }
}
