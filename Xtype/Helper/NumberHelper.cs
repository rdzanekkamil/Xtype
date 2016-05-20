namespace Xtype.Helper
{
    static class NumberHelper
    {
        public static int AddTurn(int o1, int o2, int maxValue)
        {
            var tmp = unchecked(o1 + o2);
            var temp = tmp - maxValue;
            if(temp > 0)
            {
                return temp;
            }
            return tmp;
        }
        public static int AddTurn(int o1, int o2)
        {
            return AddTurn(o1, o2, int.MaxValue);
        }

        public static int SubTurn(int o1, int o2, int minValue)
        {
            var tmp = unchecked(o1 - o2);
            var temp = tmp + minValue;
            if (temp < 0)
            {
                return temp;
            }
            return tmp;
        }
        public static int SubTurn(int o1, int o2)
        {
            return SubTurn(o1, o2, int.MinValue);
        }
    }
}
