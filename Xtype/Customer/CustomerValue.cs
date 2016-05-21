using Xtype.Helper;

namespace Xtype.Customer
{
    public class CustomerValue<T> where T : struct
    {
        T _value;

        public T Value
        {
            get { return _value; }
        }

        public CustomerValue(T value)
        {
            _value = value;
        }

        public static CustomerValue<T> operator +(CustomerValue<T> value1, CustomerValue<T> value2)
        {
            value1._value = GenericOperator.Add<T>(value1._value, value2._value);
            return value1;
        }
        public static CustomerValue<T> operator -(CustomerValue<T> value1, CustomerValue<T> value2)
        {
            value1._value = GenericOperator.Sub<T>(value1._value, value2._value);
            return value1;
        }

        public static bool operator ==(CustomerValue<T> value1, CustomerValue<T> value2)
        {
            return GenericOperator.Equal<T>(value1._value, value2._value);
        }
        public static bool operator !=(CustomerValue<T> value1, CustomerValue<T> value2)
        {
            return GenericOperator.NotEqual<T>(value1._value, value2._value);
        }

        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return _value.Equals(obj);
        }
    }
}
