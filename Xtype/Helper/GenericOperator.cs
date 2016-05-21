using System;
using System.Linq.Expressions;

namespace Xtype.Helper
{
    static class GenericOperator
    {
        internal static T Add<T>(T a, T b)
        {
            var parms = CreateTwoParms<T>();

            BinaryExpression body = Expression.Add(parms.Item1, parms.Item2);

            Func<T, T, T> func = CreateFunc<T>(body, parms.Item1, parms.Item2);

            return func(a, b);
        }
        internal static T Sub<T>(T a, T b)
        {
            var parms = CreateTwoParms<T>();

            BinaryExpression body = Expression.Subtract(parms.Item1, parms.Item2);

            Func<T, T, T> func = CreateFunc<T>(body, parms.Item1, parms.Item2);

            return func(a, b);
        }
        internal static bool And<T>(T a, T b)
        {
            var parms = CreateTwoParms<T>();

            BinaryExpression body = Expression.And(parms.Item1, parms.Item2);

            Func<T, T, bool> func = CreateBoolFunc<T>(body, parms.Item1, parms.Item2);

            return func(a, b);
        }
        internal static bool Or<T>(T a, T b)
        {
            var parms = CreateTwoParms<T>();

            BinaryExpression body = Expression.Or(parms.Item1, parms.Item2);

            Func<T, T, bool> func = CreateBoolFunc<T>(body, parms.Item1, parms.Item2);

            return func(a, b);
        }
        internal static bool Equal<T>(T a, T b)
        {
            var parms = CreateTwoParms<T>();

            BinaryExpression body = Expression.Equal(parms.Item1, parms.Item2);

            Func<T, T, bool> func = CreateBoolFunc<T>(body, parms.Item1, parms.Item2);

            return func(a, b);
        }
        internal static bool NotEqual<T>(T a, T b)
        {
            var parms = CreateTwoParms<T>();

            BinaryExpression body = Expression.NotEqual(parms.Item1, parms.Item2);

            Func<T, T, bool> func = CreateBoolFunc<T>(body, parms.Item1, parms.Item2);

            return func(a, b);
        }

        private static ParameterExpression CreateParm<T>(string v)
        {
            return Expression.Parameter(typeof(T), v);
        }
        private static Tuple<ParameterExpression, ParameterExpression> CreateTwoParms<T>()
        {
            return new Tuple<ParameterExpression, ParameterExpression>(CreateParm<T>("Item1"), CreateParm<T>("Item2"));
        }
        private static Func<T, T, T> CreateFunc<T>(Expression body, ParameterExpression paramA, ParameterExpression paramB)
        {
            return Expression.Lambda<Func<T, T, T>>(body, paramA, paramB).Compile();
        }
        private static Func<T, T, bool> CreateBoolFunc<T>(Expression body, ParameterExpression paramA, ParameterExpression paramB)
        {
            return Expression.Lambda<Func<T, T, bool>>(body, paramA, paramB).Compile();
        }
    }
}
