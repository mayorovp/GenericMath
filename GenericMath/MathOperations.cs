using System;
using System.Linq.Expressions;
using System.Threading;

namespace GenericMath
{
    public static class MathOperations
    {
        static class Holder<T>
        {
            private static readonly ParameterExpression 
                x = Expression.Parameter(typeof(T), "x"),
                y = Expression.Parameter(typeof(T), "y");

            public static Func<T, T, T>
                add, sub, mul, div,
                addChecked, subChecked, mulChecked;

            public static D LazyBuild<D>(ref D field, Func<ParameterExpression, ParameterExpression, Expression> body) where D : class =>
                 LazyInitializer.EnsureInitialized(ref field, () => Expression.Lambda<D>(body(x, y), x, y).Compile());
        }

        public static T Add<T>(T x, T y) => Holder<T>.LazyBuild(ref Holder<T>.add, Expression.Add)(x, y);
        public static T Subtract<T>(T x, T y) => Holder<T>.LazyBuild(ref Holder<T>.sub, Expression.Subtract)(x, y);
        public static T Multiply<T>(T x, T y) => Holder<T>.LazyBuild(ref Holder<T>.mul, Expression.Multiply)(x, y);
        public static T Divide<T>(T x, T y) => Holder<T>.LazyBuild(ref Holder<T>.div, Expression.Divide)(x, y);

        public static T AddChecked<T>(T x, T y) => Holder<T>.LazyBuild(ref Holder<T>.addChecked, Expression.AddChecked)(x, y);
        public static T SubtractChecked<T>(T x, T y) => Holder<T>.LazyBuild(ref Holder<T>.subChecked, Expression.SubtractChecked)(x, y);
        public static T MultiplyChecked<T>(T x, T y) => Holder<T>.LazyBuild(ref Holder<T>.mulChecked, Expression.MultiplyChecked)(x, y);
    }
}
