using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;

namespace GenericMath.Emit
{
    abstract class InstructionReader : IEnumerable<Instruction>
    {
        public abstract Instruction Read();

        public IEnumerator<Instruction> GetEnumerator()
        {
            Instruction next;
            while ((next = Read()) != null) yield return next;
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public static InstructionReader Create(Module module, IReadOnlyList<LocalVariable> variables, byte[] body, Type[] genericTypeArguments = null, Type[] genericMethodArguments = null) => 
            new Instruction.InstructionReaderImpl(module, genericTypeArguments, genericMethodArguments, variables, body);
        public static InstructionReader Create(Module module, MethodBody body, Type[] genericTypeArguments = null, Type[] genericMethodArguments = null) => Create(module,
            variables: body.LocalVariables.Select(v => new LocalVariable(v.LocalType, v.IsPinned)).ToList(),
            body: body.GetILAsByteArray(),
            genericTypeArguments: genericTypeArguments,
            genericMethodArguments: genericMethodArguments);
        public static InstructionReader Create(MethodInfo method) => Create(method.Module, method.GetMethodBody(), 
            genericTypeArguments: method.DeclaringType.GetGenericArguments(),
            genericMethodArguments: method.GetGenericArguments());
    }
}
