using GenericMath.Emit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;
using System.Threading;

namespace GenericMath
{
    public static partial class MathRewriter
    {
        private static readonly AssemblyBuilder assembly = AppDomain.CurrentDomain.DefineDynamicAssembly(new AssemblyName(typeof(MathRewriter).Assembly.GetName().Name + ".DynamicAssembly"), AssemblyBuilderAccess.Run);
        private static readonly ModuleBuilder module = assembly.DefineDynamicModule("<Main>");

        private class Holder<T> { public static T value; }

        public static T GetInstance<T>() where T : class, new() => LazyInitializer.EnsureInitialized(ref Holder<T>.value, BuildInstance<T>);
        private static T BuildInstance<T>()
        {
            var basetype = typeof(T);
            var implType = module.DefineType(basetype.FullName + "$Impl", TypeAttributes.Class | TypeAttributes.Sealed, basetype);

            ILGenerator il;
            foreach (var refMethod in basetype.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
            {
                if (refMethod.DeclaringType != typeof(object) && refMethod.IsVirtual && !refMethod.IsFinal)
                {
                    var implMethod = implType.DefineMethod(
                        name: refMethod.Name,
                        attributes: MethodAttributes.Public | MethodAttributes.NewSlot | MethodAttributes.Virtual | MethodAttributes.Final | MethodAttributes.HideBySig,
                        callingConvention: refMethod.CallingConvention,
                        returnType: refMethod.ReturnType,
                        parameterTypes: refMethod.GetParameters().Select(p => p.ParameterType).ToArray());

                    var instructions = InstructionReader.Create(refMethod).ToList();
                    il = implMethod.GetILGenerator();
                    foreach (var i in instructions)
                    {
                        var method = i.Operand as MethodInfo;
                        if (method != null && method.DeclaringType == typeof(MathOperations))
                        {
                            var argtype = method.GetGenericArguments()[0];
                            if (!argtype.IsGenericParameter)
                            {
                                var x = Expression.Parameter(argtype);
                                var expr1 = exprReplaces[method.Name](x, x);
                                if (expr1.Method != null)
                                    i.Operand = expr1.Method;
                                else
                                {
                                    var expr2 = Expression.Call(typeof(MathOperationsImpl), method.Name, null, x, x);
                                    i.Operand = expr2.Method;
                                }
                            }
                        }
                        i.Prepare(il);
                    }

                    foreach (var i in instructions)
                    {
                        i.EmitOn(il);
                    }

                    implType.DefineMethodOverride(implMethod, refMethod);
                }
            }

            var ctor = implType.DefineConstructor(MethodAttributes.Public, CallingConventions.HasThis, Type.EmptyTypes);
            il = ctor.GetILGenerator();
            il.Emit(OpCodes.Ldarg_0);
            il.Emit(OpCodes.Call, implType.BaseType.GetConstructor(Type.EmptyTypes));
            il.Emit(OpCodes.Ret);

            var type = implType.CreateType();
            return (T)Activator.CreateInstance(type);
        }

        private static readonly Dictionary<string, Func<Expression, Expression, BinaryExpression>> exprReplaces =
            (from source in typeof(MathOperations).GetMethods(BindingFlags.Public | BindingFlags.Static)
             let name = source.Name
             let method = typeof(Expression).GetMethod(name, BindingFlags.Public | BindingFlags.Static, null, new Type[] { typeof(Expression), typeof(Expression) }, null)
             let d = (Func<Expression, Expression, BinaryExpression>)Delegate.CreateDelegate(typeof(Func<Expression, Expression, BinaryExpression>), method)
             select new { name, d }).ToDictionary(x => x.name, x => x.d);

    }
}
