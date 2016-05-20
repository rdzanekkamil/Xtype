using System;
using Xtype.Helper;

namespace Xtype
{
    using V = System.Diagnostics.DebuggerBrowsableAttribute;
    using VEnum = System.Diagnostics.DebuggerBrowsableState;
    using Dis = System.Diagnostics.DebuggerDisplayAttribute;

    [Dis("{_value}")]
    public struct xint : IComparable, IComparable<xint>, IEquatable<xint>, IFormattable
    {
        [V(VEnum.Never)]
        int _value;

        public static readonly xint MaxValue = int.MaxValue;
        public static readonly xint MinValue = int.MinValue;

        public xint(int value)
        {
            _value = value;
        }

        public static implicit operator xint(int o)
        {
            return new xint(o);
        }
        public static implicit operator int(xint o)
        {
            return o._value;
        }

        public static bool operator ==(xint o1, xint o2)
        {
            return o1._value == o2._value;
        }
        public static bool operator !=(xint o1, xint o2)
        {
            return o1._value != o2._value;
        }

        public static bool operator >(xint o1, xint o2)
        {
            return o1._value > o2._value;
        }
        public static bool operator <(xint o1, xint o2)
        {
            return o1._value < o2._value;
        }

        public static bool operator >=(xint o1, xint o2)
        {
            return o1._value >= o2._value;
        }
        public static bool operator <=(xint o1, xint o2)
        {
            return o1._value <= o2._value;
        }

        public static xint operator +(xint o1, xint o2)
        {
            o1._value = NumberHelper.AddTurn(o1._value, o2._value);
            return o1;
        }
        public static xint operator -(xint o1, xint o2)
        {
            o1._value = NumberHelper.SubTurn(o1._value, o2._value);
            return o1;
        }

        public static xint operator ++(xint o)
        {
            return NumberHelper.AddTurn(o._value, 1);
        }
        public static xint operator --(xint o)
        {
            return NumberHelper.SubTurn(o._value, 1);
        }

        public static xint Parse(string s)
        {
            return new xint(int.Parse(s));
        }
        public static bool TryParse(string s, out xint result)
        {
            return int.TryParse(s, out result._value);
        }

        public override bool Equals(object obj)
        {
            return _value.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode() / 2;
        }
        public override string ToString()
        {
            return _value.ToString();
        }

        public int CompareTo(object obj)
        {
            return ((IComparable)_value).CompareTo(obj);
        }
        public int CompareTo(xint other)
        {
            return _value.CompareTo(other._value);
        }

        public bool Equals(xint other)
        {
            return _value.Equals(other._value);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            return _value.ToString(format, formatProvider);
        }
    }
}
