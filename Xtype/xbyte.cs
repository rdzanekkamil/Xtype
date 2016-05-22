using System;
using Xtype.Helper;

namespace Xtype
{
    using V = System.Diagnostics.DebuggerBrowsableAttribute;
    using VEnum = System.Diagnostics.DebuggerBrowsableState;
    using Dis = System.Diagnostics.DebuggerDisplayAttribute;

    [Dis("{_value}")]
    public struct xbyte : IComparable, IComparable<xbyte>, IEquatable<xbyte>, IFormattable
    {
        [V(VEnum.Never)]
        byte _value;

        public static readonly xbyte MaxValue = byte.MaxValue;
        public static readonly xbyte MinValue = byte.MinValue;

        public xbyte(byte value)
        {
            _value = value;
        }

        public static implicit operator xbyte(byte o)
        {
            return new xbyte(o);
        }
        public static implicit operator byte(xbyte o)
        {
            return o._value;
        }

        public static bool operator ==(xbyte o1, xbyte o2)
        {
            return o1._value == o2._value;
        }
        public static bool operator !=(xbyte o1, xbyte o2)
        {
            return o1._value != o2._value;
        }

        public static bool operator >(xbyte o1, xbyte o2)
        {
            return o1._value > o2._value;
        }
        public static bool operator <(xbyte o1, xbyte o2)
        {
            return o1._value < o2._value;
        }

        public static bool operator >=(xbyte o1, xbyte o2)
        {
            return o1._value >= o2._value;
        }
        public static bool operator <=(xbyte o1, xbyte o2)
        {
            return o1._value <= o2._value;
        }

        public static xbyte operator +(xbyte o1, xbyte o2)
        {
            o1._value = NumberHelper.AddTurn(o1._value, o2._value);
            return o1;
        }
        public static xbyte operator -(xbyte o1, xbyte o2)
        {
            o1._value = NumberHelper.SubTurn(o1._value, o2._value);
            return o1;
        }

        public static xbyte operator ++(xbyte o)
        {
            return NumberHelper.AddTurn(o._value, (byte)1);
        }
        public static xbyte operator --(xbyte o)
        {
            return NumberHelper.SubTurn(o._value, (byte)1);
        }

        public static xbyte Parse(string s)
        {
            return new xbyte(byte.Parse(s));
        }
        public static bool TryParse(string s, out xbyte result)
        {
            return byte.TryParse(s, out result._value);
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
        public int CompareTo(xbyte other)
        {
            return _value.CompareTo(other._value);
        }

        public bool Equals(xbyte other)
        {
            return _value.Equals(other._value);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            return _value.ToString(format, formatProvider);
        }
    }
}
