using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;

namespace GenericMath.Emit
{
    sealed class Instruction
    {
        public OpCode OpCode;
        public object Operand;

        public Instruction() { }
        public Instruction(OpCode opCode, object operand)
        {
            this.OpCode = opCode;
            this.Operand = operand;
        }

        private Label? label;

        public Label GetLabelFor(ILGenerator il) =>
            label ?? (label = il.DefineLabel()).Value;

        public void Prepare(ILGenerator il)
        {
            (Operand as Instruction)?.GetLabelFor(il);
        }

        public void EmitOn(ILGenerator il)
        {
            if (label != null) il.MarkLabel(label.Value);

            switch (OpCode.OperandType)
            {
                case OperandType.InlineBrTarget:
                case OperandType.ShortInlineBrTarget:
                    var target = (Instruction)Operand;
                    il.Emit(OpCode, target.GetLabelFor(il));
                    break;

                case OperandType.InlineField:
                    il.Emit(OpCode, (FieldInfo)Operand);
                    break;

                case OperandType.InlineMethod:
                    if (Operand is ConstructorInfo)
                        il.Emit(OpCode, (ConstructorInfo)Operand);
                    else if (Operand is MethodInfo)
                        il.Emit(OpCode, (MethodInfo)Operand);
                    else
                        throw new InvalidCastException("Operand must be one of ConstructorInfo, MethodInfo");
                    break;

                case OperandType.InlineType:
                    il.Emit(OpCode, (Type)Operand);
                    break;

                case OperandType.InlineString:
                    il.Emit(OpCode, (string)Operand);
                    break;

                case OperandType.InlineSig:
                    il.Emit(OpCode, (SignatureHelper)Operand);
                    break;

                case OperandType.InlineTok:
                    if (Operand is FieldInfo)
                        il.Emit(OpCode, (FieldInfo)Operand);
                    else if (Operand is MethodInfo)
                        il.Emit(OpCode, (MethodInfo)Operand);
                    else if (Operand is Type)
                        il.Emit(OpCode, (Type)Operand);
                    else
                        throw new InvalidCastException("Operand must be one of FieldInfo, MethodInfo, Type");
                    break;

                case OperandType.InlineSwitch:
                    var targets = (Instruction[])Operand;
                    var labels = new Label[targets.Length];
                    for (int i = 0; i < targets.Length; i++)
                        labels[i] = targets[i].GetLabelFor(il);
                    il.Emit(OpCode, labels);
                    break;

                case OperandType.InlineVar:
                    if (Operand is LocalVariable)
                        il.Emit(OpCode, (Operand as LocalVariable).GetBuilderFor(il));
                    else
                        il.Emit(OpCode, (Int16)Operand);
                    break;

                case OperandType.ShortInlineVar:
                    if (Operand is LocalVariable)
                        il.Emit(OpCode, (Operand as LocalVariable).GetBuilderFor(il));
                    else
                        il.Emit(OpCode, (SByte)Operand);
                    break;

                case OperandType.InlineI:
                    il.Emit(OpCode, (Int32)Operand);
                    break;

                case OperandType.InlineI8:
                    il.Emit(OpCode, (Int64)Operand);
                    break;

                case OperandType.InlineNone:
                    il.Emit(OpCode);
                    break;

                case OperandType.InlineR:
                    il.Emit(OpCode, (Double)Operand);
                    break;

                case OperandType.ShortInlineI:
                    il.Emit(OpCode, (SByte)Operand);
                    break;

                case OperandType.ShortInlineR:
                    il.Emit(OpCode, (Single)Operand);
                    break;

                default:
                    throw new NotSupportedException();
            }
        }

        internal class InstructionReaderImpl : InstructionReader
        {
            private readonly Dictionary<int, Instruction> instructions = new Dictionary<int, Instruction>();
            private readonly Module module;
            private readonly Type[] genericTypeArguments, genericMethodArguments;
            private readonly BinaryReader reader;

            public IReadOnlyList<LocalVariable> Variables { get; }

            public InstructionReaderImpl(Module module, Type[] genericTypeArguments, Type[] genericMethodArguments, IReadOnlyList<LocalVariable> variables, byte[] body)
            {
                this.reader = new BinaryReader(new MemoryStream(body));
                this.module = module;
                this.genericTypeArguments = genericTypeArguments;
                this.genericMethodArguments = genericMethodArguments;
                this.Variables = variables;
            }

            private int Position => (int)reader.BaseStream.Position;

            private Instruction FindLabel(int value)
            {
                Instruction target;
                if (!instructions.TryGetValue(value, out target))
                    instructions.Add(value, target = new Instruction());
                return target;
            }

            public override Instruction Read()
            {
                var initialPosition = Position;
                Instruction result;
                if (!instructions.TryGetValue(initialPosition, out result))
                    instructions.Add(initialPosition, result = new Instruction());

                try
                {
                    short opcode = reader.ReadByte();
                    if (opcode > 0xfe)
                    {
                        opcode = unchecked((short)((opcode << 8) | reader.ReadByte()));
                    }
                    result.OpCode = AllOpCodes[opcode];
                }
                catch (EndOfStreamException)
                {
                    return null;
                }

                switch (result.OpCode.OperandType)
                {
                    case OperandType.InlineBrTarget:
                        result.Operand = FindLabel(initialPosition + result.OpCode.Size + 4 + reader.ReadInt32());
                        break;

                    case OperandType.ShortInlineBrTarget:
                        result.Operand = FindLabel(initialPosition + result.OpCode.Size + 1 + reader.ReadSByte());
                        break;

                    case OperandType.InlineField:
                        result.Operand = module.ResolveField(reader.ReadInt32(), genericTypeArguments, genericMethodArguments);
                        break;

                    case OperandType.InlineMethod:
                        result.Operand = module.ResolveMethod(reader.ReadInt32(), genericTypeArguments, genericMethodArguments);
                        break;

                    case OperandType.InlineType:
                        result.Operand = module.ResolveType(reader.ReadInt32(), genericTypeArguments, genericMethodArguments);
                        break;

                    case OperandType.InlineString:
                        result.Operand = module.ResolveString(reader.ReadInt32());
                        break;

                    case OperandType.InlineSig:
                        result.Operand = module.ResolveSignature(reader.ReadInt32());
                        break;

                    case OperandType.InlineTok:
                        result.Operand = module.ResolveMember(reader.ReadInt32(), genericTypeArguments, genericMethodArguments);
                        break;

                    case OperandType.InlineSwitch:
                        var n = reader.ReadInt32();
                        var targets = new Instruction[n];
                        for (int i = 0; i < targets.Length; i++)
                            targets[i] = FindLabel(initialPosition + reader.ReadInt32());
                        result.Operand = targets;
                        break;

                    case OperandType.InlineVar:
                        result.Operand = reader.ReadInt16();
                        break;

                    case OperandType.ShortInlineVar:
                    case OperandType.ShortInlineI:
                        result.Operand = reader.ReadSByte();
                        break;

                    case OperandType.InlineI:
                        result.Operand = reader.ReadInt32();
                        break;

                    case OperandType.InlineI8:
                        result.Operand = reader.ReadInt64();
                        break;

                    case OperandType.InlineNone:
                        break;

                    case OperandType.InlineR:
                        result.Operand = reader.ReadDouble();
                        break;

                    case OperandType.ShortInlineR:
                        result.Operand = reader.ReadSingle();
                        break;

                    default:
                        throw new NotSupportedException();
                }

                Func<object, int> variableIndex;
                if (VariableIndexes.TryGetValue(result.OpCode, out variableIndex))
                    result.Operand = Variables[variableIndex(result.Operand)];

                OpCode replacement;
                if (OpCodeReplaces.TryGetValue(result.OpCode, out replacement))
                    result.OpCode = replacement;

                return result;
            }

            private static readonly IReadOnlyDictionary<short, OpCode> AllOpCodes =
                typeof(OpCodes).GetFields(BindingFlags.Static | BindingFlags.Public)
                .Select(f => f.GetValue(null))
                .OfType<OpCode>()
                .ToDictionary(op => op.Value);

            private static readonly IReadOnlyDictionary<OpCode, Func<object, int>> VariableIndexes = new Dictionary<OpCode, Func<object, int>>
            {
                { OpCodes.Ldloc_0, x => 0 },
                { OpCodes.Ldloc_1, x => 1 },
                { OpCodes.Ldloc_2, x => 2 },
                { OpCodes.Ldloc_3, x => 3 },
                { OpCodes.Ldloc_S, x => (sbyte)x },
                { OpCodes.Ldloc, x => (short)x },

                { OpCodes.Ldloca_S, x => (sbyte)x },
                { OpCodes.Ldloca, x => (short)x },

                { OpCodes.Stloc_0, x => 0 },
                { OpCodes.Stloc_1, x => 1 },
                { OpCodes.Stloc_2, x => 2 },
                { OpCodes.Stloc_3, x => 3 },
                { OpCodes.Stloc_S, x => (sbyte)x },
                { OpCodes.Stloc, x => (short)x },
            };

            private static readonly IReadOnlyDictionary<OpCode, OpCode> OpCodeReplaces = new Dictionary<OpCode, OpCode>
            {
                { OpCodes.Ldloc_0, OpCodes.Ldloc },
                { OpCodes.Ldloc_1, OpCodes.Ldloc },
                { OpCodes.Ldloc_2, OpCodes.Ldloc },
                { OpCodes.Ldloc_3, OpCodes.Ldloc },
                { OpCodes.Ldloc_S, OpCodes.Ldloc },

                { OpCodes.Ldloca_S, OpCodes.Ldloca },

                { OpCodes.Stloc_0, OpCodes.Stloc },
                { OpCodes.Stloc_1, OpCodes.Stloc },
                { OpCodes.Stloc_2, OpCodes.Stloc },
                { OpCodes.Stloc_3, OpCodes.Stloc },
                { OpCodes.Stloc_S, OpCodes.Stloc },
            };
        }
    }
}
