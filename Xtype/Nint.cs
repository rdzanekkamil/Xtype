using System;
using Xtype.Helper;

namespace Xtype
{
    using V = System.Diagnostics.DebuggerBrowsableAttribute;
    using VEnum = System.Diagnostics.DebuggerBrowsableState;
    using Dis = System.Diagnostics.DebuggerDisplayAttribute;

    [Dis("{_value}")]
    public struct Nint : IComparable, IComparable<Nint>, IEquatable<Nint>, IFormattable
    {
        [V(VEnum.Never)]
        int _value;

        public const int MaxGlobalValue = 2147483647;
        public const int MinGlobalValue = -2147483648;

        public int MaxValue { get; set; }
        public int MinValue { get; set; }

        public Nint(int value)
        {
            _value = value;
            MaxValue = MaxGlobalValue;
            MinValue = MinGlobalValue;
        }
        public Nint(int value, int minValue, int maxValue)
        {
            _value = value;
            MaxValue = maxValue;
            MinValue = minValue;
        }

        public static implicit operator Nint(int o)
        {
            return new Nint(o);
        }
        public static implicit operator int(Nint o)
        {
            return o._value;
        }

        public static bool operator ==(Nint o1, Nint o2)
        {
            return o1._value == o2._value;
        }
        public static bool operator !=(Nint o1, Nint o2)
        {
            return o1._value != o2._value;
        }

        public static bool operator >(Nint o1, Nint o2)
        {
            return o1._value > o2._value;
        }
        public static bool operator <(Nint o1, Nint o2)
        {
            return o1._value < o2._value;
        }

        public static bool operator >=(Nint o1, Nint o2)
        {
            return o1._value >= o2._value;
        }
        public static bool operator <=(Nint o1, Nint o2)
        {
            return o1._value <= o2._value;
        }

        public static Nint operator +(Nint o1, Nint o2)
        {
            o1._value = NumberHelper.AddTurn(o1._value, o2._value, o1.MaxValue);
            return o1;
        }
        public static Nint operator -(Nint o1, Nint o2)
        {
            o1._value = NumberHelper.SubTurn(o1._value, o2._value, o1.MinValue);
            return o1;
        }

        public static Nint operator ++(Nint o)
        {
            return NumberHelper.AddTurn(o._value, 1, o.MaxValue);
        }
        public static Nint operator --(Nint o)
        {
            return NumberHelper.SubTurn(o._value, 1, o.MinValue);
        }

        public static Nint Parse(string s)
        {
            return new Nint(int.Parse(s));
        }
        public static bool TryParse(string s, out Nint result)
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
        public int CompareTo(Nint other)
        {
            return _value.CompareTo(other._value);
        }

        public bool Equals(Nint other)
        {
            return _value.Equals(other._value);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            return _value.ToString(format, formatProvider);
        }
    }
}
