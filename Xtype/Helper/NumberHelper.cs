namespace Xtype.Helper
{
    static class NumberHelper
    {
        internal static byte AddTurn(byte value1, byte value2, byte maxValue)
        {
            var tmp = unchecked(value1 + value2);
            var temp = tmp - maxValue;
            if (temp > 0)
            {
                return (byte)temp;
            }
            return (byte)tmp;
        }
        internal static byte AddTurn(byte value1, byte value2)
        {
            return AddTurn(value1, value2, byte.MaxValue);
        }
        internal static int AddTurn(int value1, int value2, int maxValue)
        {
            var tmp = unchecked(value1 + value2);
            var temp = tmp - maxValue;
            if(temp > 0)
            {
                return temp;
            }
            return tmp;
        }
        internal static int AddTurn(int value1, int value2)
        {
            return AddTurn(value1, value2, int.MaxValue);
        }
        internal static long AddTurn(long value1, long value2, long maxValue)
        {
            var tmp = unchecked(value1 + value2);
            var temp = tmp - maxValue;
            if (temp > 0)
            {
                return temp;
            }
            return tmp;
        }
        internal static long AddTurn(long value1, long value2)
        {
            return AddTurn(value1, value2, long.MaxValue);
        }

        internal static byte SubTurn(byte value1, byte value2, byte minValue)
        {
            var tmp = unchecked(value1 - value2);
            var temp = tmp + minValue;
            if (temp < 0)
            {
                return (byte)temp;
            }
            return (byte)tmp;
        }
        internal static byte SubTurn(byte value1, byte value2)
        {
            return SubTurn(value1, value2, byte.MinValue);
        }
        internal static int SubTurn(int value1, int value2, int minValue)
        {
            var tmp = unchecked(value1 - value2);
            var temp = tmp + minValue;
            if (temp < 0)
            {
                return temp;
            }
            return tmp;
        }
        internal static int SubTurn(int value1, int value2)
        {
            return SubTurn(value1, value2, int.MinValue);
        }
        internal static long SubTurn(long value1, long value2, long minValue)
        {
            var tmp = unchecked(value1 - value2);
            var temp = tmp + minValue;
            if (temp < 0)
            {
                return temp;
            }
            return tmp;
        }
        internal static long SubTurn(long value1, long value2)
        {
            return SubTurn(value1, value2, long.MinValue);
        }
    }
}
