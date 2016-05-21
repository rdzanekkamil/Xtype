using System;
using Xtype.Helper;

namespace Xtype
{
    using V = System.Diagnostics.DebuggerBrowsableAttribute;
    using VEnum = System.Diagnostics.DebuggerBrowsableState;
    using Dis = System.Diagnostics.DebuggerDisplayAttribute;

    [Dis("{_value}")]
    public struct xlong : IComparable, IComparable<xlong>, IEquatable<xlong>, IFormattable
    {
        [V(VEnum.Never)]
        long _value;

        public static readonly xlong MaxValue = long.MaxValue;
        public static readonly xlong MinValue = long.MinValue;

        public xlong(long value)
        {
            _value = value;
        }

        public static implicit operator xlong(long o)
        {
            return new xlong(o);
        }
        public static implicit operator long(xlong o)
        {
            return o._value;
        }

        public static bool operator ==(xlong o1, xlong o2)
        {
            return o1._value == o2._value;
        }
        public static bool operator !=(xlong o1, xlong o2)
        {
            return o1._value != o2._value;
        }

        public static bool operator >(xlong o1, xlong o2)
        {
            return o1._value > o2._value;
        }
        public static bool operator <(xlong o1, xlong o2)
        {
            return o1._value < o2._value;
        }

        public static bool operator >=(xlong o1, xlong o2)
        {
            return o1._value >= o2._value;
        }
        public static bool operator <=(xlong o1, xlong o2)
        {
            return o1._value <= o2._value;
        }

        public static xlong operator +(xlong o1, xlong o2)
        {
            o1._value = NumberHelper.AddTurn(o1._value, o2._value);
            return o1;
        }
        public static xlong operator -(xlong o1, xlong o2)
        {
            o1._value = NumberHelper.SubTurn(o1._value, o2._value);
            return o1;
        }

        public static xlong operator ++(xlong o)
        {
            return NumberHelper.AddTurn(o._value, 1);
        }
        public static xlong operator --(xlong o)
        {
            return NumberHelper.SubTurn(o._value, 1);
        }

        public static xlong Parse(string s)
        {
            return new xlong(long.Parse(s));
        }
        public static bool TryParse(string s, out xlong result)
        {
            return long.TryParse(s, out result._value);
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
        public int CompareTo(xlong other)
        {
            return _value.CompareTo(other._value);
        }

        public bool Equals(xlong other)
        {
            return _value.Equals(other._value);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            return _value.ToString(format, formatProvider);
        }
    }
}
