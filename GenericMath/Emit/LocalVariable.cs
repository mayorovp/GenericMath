using System;
using System.Reflection.Emit;

namespace GenericMath.Emit
{
    public sealed class LocalVariable
    {
        public Type type;
        public bool isPinned;

        private LocalBuilder builder;

        public LocalVariable() { }
        public LocalVariable(Type type, bool isPinned = false)
        {
            this.type = type;
            this.isPinned = isPinned;
        }

        public LocalBuilder GetBuilderFor(ILGenerator il) =>
            builder ?? (builder = il.DeclareLocal(type, isPinned));
    }
}
