using System;
using System.Runtime.CompilerServices;


namespace GenericMath
{
    static partial class MathOperationsImpl
    {
#region Int16 methods
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Int16 Add(Int16 x, Int16 y) => (Int16)(x + y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Int16 Subtract(Int16 x, Int16 y) => (Int16)(x - y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Int16 Multiply(Int16 x, Int16 y) => (Int16)(x * y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Int16 Divide(Int16 x, Int16 y) => (Int16)(x / y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Int16 AddChecked(Int16 x, Int16 y) => checked((Int16)(x + y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Int16 SubtractChecked(Int16 x, Int16 y) => checked((Int16)(x - y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Int16 MultiplyChecked(Int16 x, Int16 y) => checked((Int16)(x * y));
#endregion

#region Int16? methods
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Int16? Add(Int16? x, Int16? y) => (Int16?)(x + y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Int16? Subtract(Int16? x, Int16? y) => (Int16?)(x - y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Int16? Multiply(Int16? x, Int16? y) => (Int16?)(x * y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Int16? Divide(Int16? x, Int16? y) => (Int16?)(x / y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Int16? AddChecked(Int16? x, Int16? y) => checked((Int16?)(x + y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Int16? SubtractChecked(Int16? x, Int16? y) => checked((Int16?)(x - y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Int16? MultiplyChecked(Int16? x, Int16? y) => checked((Int16?)(x * y));
#endregion

#region Int32 methods
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Int32 Add(Int32 x, Int32 y) => (Int32)(x + y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Int32 Subtract(Int32 x, Int32 y) => (Int32)(x - y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Int32 Multiply(Int32 x, Int32 y) => (Int32)(x * y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Int32 Divide(Int32 x, Int32 y) => (Int32)(x / y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Int32 AddChecked(Int32 x, Int32 y) => checked((Int32)(x + y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Int32 SubtractChecked(Int32 x, Int32 y) => checked((Int32)(x - y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Int32 MultiplyChecked(Int32 x, Int32 y) => checked((Int32)(x * y));
#endregion

#region Int32? methods
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Int32? Add(Int32? x, Int32? y) => (Int32?)(x + y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Int32? Subtract(Int32? x, Int32? y) => (Int32?)(x - y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Int32? Multiply(Int32? x, Int32? y) => (Int32?)(x * y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Int32? Divide(Int32? x, Int32? y) => (Int32?)(x / y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Int32? AddChecked(Int32? x, Int32? y) => checked((Int32?)(x + y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Int32? SubtractChecked(Int32? x, Int32? y) => checked((Int32?)(x - y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Int32? MultiplyChecked(Int32? x, Int32? y) => checked((Int32?)(x * y));
#endregion

#region Int64 methods
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Int64 Add(Int64 x, Int64 y) => (Int64)(x + y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Int64 Subtract(Int64 x, Int64 y) => (Int64)(x - y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Int64 Multiply(Int64 x, Int64 y) => (Int64)(x * y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Int64 Divide(Int64 x, Int64 y) => (Int64)(x / y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Int64 AddChecked(Int64 x, Int64 y) => checked((Int64)(x + y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Int64 SubtractChecked(Int64 x, Int64 y) => checked((Int64)(x - y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Int64 MultiplyChecked(Int64 x, Int64 y) => checked((Int64)(x * y));
#endregion

#region Int64? methods
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Int64? Add(Int64? x, Int64? y) => (Int64?)(x + y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Int64? Subtract(Int64? x, Int64? y) => (Int64?)(x - y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Int64? Multiply(Int64? x, Int64? y) => (Int64?)(x * y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Int64? Divide(Int64? x, Int64? y) => (Int64?)(x / y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Int64? AddChecked(Int64? x, Int64? y) => checked((Int64?)(x + y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Int64? SubtractChecked(Int64? x, Int64? y) => checked((Int64?)(x - y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Int64? MultiplyChecked(Int64? x, Int64? y) => checked((Int64?)(x * y));
#endregion

#region UInt16 methods
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static UInt16 Add(UInt16 x, UInt16 y) => (UInt16)(x + y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static UInt16 Subtract(UInt16 x, UInt16 y) => (UInt16)(x - y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static UInt16 Multiply(UInt16 x, UInt16 y) => (UInt16)(x * y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static UInt16 Divide(UInt16 x, UInt16 y) => (UInt16)(x / y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static UInt16 AddChecked(UInt16 x, UInt16 y) => checked((UInt16)(x + y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static UInt16 SubtractChecked(UInt16 x, UInt16 y) => checked((UInt16)(x - y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static UInt16 MultiplyChecked(UInt16 x, UInt16 y) => checked((UInt16)(x * y));
#endregion

#region UInt16? methods
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static UInt16? Add(UInt16? x, UInt16? y) => (UInt16?)(x + y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static UInt16? Subtract(UInt16? x, UInt16? y) => (UInt16?)(x - y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static UInt16? Multiply(UInt16? x, UInt16? y) => (UInt16?)(x * y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static UInt16? Divide(UInt16? x, UInt16? y) => (UInt16?)(x / y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static UInt16? AddChecked(UInt16? x, UInt16? y) => checked((UInt16?)(x + y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static UInt16? SubtractChecked(UInt16? x, UInt16? y) => checked((UInt16?)(x - y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static UInt16? MultiplyChecked(UInt16? x, UInt16? y) => checked((UInt16?)(x * y));
#endregion

#region UInt32 methods
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static UInt32 Add(UInt32 x, UInt32 y) => (UInt32)(x + y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static UInt32 Subtract(UInt32 x, UInt32 y) => (UInt32)(x - y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static UInt32 Multiply(UInt32 x, UInt32 y) => (UInt32)(x * y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static UInt32 Divide(UInt32 x, UInt32 y) => (UInt32)(x / y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static UInt32 AddChecked(UInt32 x, UInt32 y) => checked((UInt32)(x + y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static UInt32 SubtractChecked(UInt32 x, UInt32 y) => checked((UInt32)(x - y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static UInt32 MultiplyChecked(UInt32 x, UInt32 y) => checked((UInt32)(x * y));
#endregion

#region UInt32? methods
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static UInt32? Add(UInt32? x, UInt32? y) => (UInt32?)(x + y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static UInt32? Subtract(UInt32? x, UInt32? y) => (UInt32?)(x - y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static UInt32? Multiply(UInt32? x, UInt32? y) => (UInt32?)(x * y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static UInt32? Divide(UInt32? x, UInt32? y) => (UInt32?)(x / y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static UInt32? AddChecked(UInt32? x, UInt32? y) => checked((UInt32?)(x + y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static UInt32? SubtractChecked(UInt32? x, UInt32? y) => checked((UInt32?)(x - y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static UInt32? MultiplyChecked(UInt32? x, UInt32? y) => checked((UInt32?)(x * y));
#endregion

#region UInt64 methods
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static UInt64 Add(UInt64 x, UInt64 y) => (UInt64)(x + y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static UInt64 Subtract(UInt64 x, UInt64 y) => (UInt64)(x - y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static UInt64 Multiply(UInt64 x, UInt64 y) => (UInt64)(x * y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static UInt64 Divide(UInt64 x, UInt64 y) => (UInt64)(x / y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static UInt64 AddChecked(UInt64 x, UInt64 y) => checked((UInt64)(x + y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static UInt64 SubtractChecked(UInt64 x, UInt64 y) => checked((UInt64)(x - y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static UInt64 MultiplyChecked(UInt64 x, UInt64 y) => checked((UInt64)(x * y));
#endregion

#region UInt64? methods
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static UInt64? Add(UInt64? x, UInt64? y) => (UInt64?)(x + y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static UInt64? Subtract(UInt64? x, UInt64? y) => (UInt64?)(x - y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static UInt64? Multiply(UInt64? x, UInt64? y) => (UInt64?)(x * y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static UInt64? Divide(UInt64? x, UInt64? y) => (UInt64?)(x / y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static UInt64? AddChecked(UInt64? x, UInt64? y) => checked((UInt64?)(x + y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static UInt64? SubtractChecked(UInt64? x, UInt64? y) => checked((UInt64?)(x - y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static UInt64? MultiplyChecked(UInt64? x, UInt64? y) => checked((UInt64?)(x * y));
#endregion

#region Byte methods
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Byte Add(Byte x, Byte y) => (Byte)(x + y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Byte Subtract(Byte x, Byte y) => (Byte)(x - y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Byte Multiply(Byte x, Byte y) => (Byte)(x * y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Byte Divide(Byte x, Byte y) => (Byte)(x / y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Byte AddChecked(Byte x, Byte y) => checked((Byte)(x + y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Byte SubtractChecked(Byte x, Byte y) => checked((Byte)(x - y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Byte MultiplyChecked(Byte x, Byte y) => checked((Byte)(x * y));
#endregion

#region Byte? methods
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Byte? Add(Byte? x, Byte? y) => (Byte?)(x + y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Byte? Subtract(Byte? x, Byte? y) => (Byte?)(x - y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Byte? Multiply(Byte? x, Byte? y) => (Byte?)(x * y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Byte? Divide(Byte? x, Byte? y) => (Byte?)(x / y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Byte? AddChecked(Byte? x, Byte? y) => checked((Byte?)(x + y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Byte? SubtractChecked(Byte? x, Byte? y) => checked((Byte?)(x - y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Byte? MultiplyChecked(Byte? x, Byte? y) => checked((Byte?)(x * y));
#endregion

#region SByte methods
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static SByte Add(SByte x, SByte y) => (SByte)(x + y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static SByte Subtract(SByte x, SByte y) => (SByte)(x - y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static SByte Multiply(SByte x, SByte y) => (SByte)(x * y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static SByte Divide(SByte x, SByte y) => (SByte)(x / y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static SByte AddChecked(SByte x, SByte y) => checked((SByte)(x + y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static SByte SubtractChecked(SByte x, SByte y) => checked((SByte)(x - y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static SByte MultiplyChecked(SByte x, SByte y) => checked((SByte)(x * y));
#endregion

#region SByte? methods
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static SByte? Add(SByte? x, SByte? y) => (SByte?)(x + y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static SByte? Subtract(SByte? x, SByte? y) => (SByte?)(x - y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static SByte? Multiply(SByte? x, SByte? y) => (SByte?)(x * y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static SByte? Divide(SByte? x, SByte? y) => (SByte?)(x / y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static SByte? AddChecked(SByte? x, SByte? y) => checked((SByte?)(x + y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static SByte? SubtractChecked(SByte? x, SByte? y) => checked((SByte?)(x - y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static SByte? MultiplyChecked(SByte? x, SByte? y) => checked((SByte?)(x * y));
#endregion

#region Single methods
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Single Add(Single x, Single y) => (Single)(x + y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Single Subtract(Single x, Single y) => (Single)(x - y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Single Multiply(Single x, Single y) => (Single)(x * y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Single Divide(Single x, Single y) => (Single)(x / y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Single AddChecked(Single x, Single y) => checked((Single)(x + y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Single SubtractChecked(Single x, Single y) => checked((Single)(x - y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Single MultiplyChecked(Single x, Single y) => checked((Single)(x * y));
#endregion

#region Single? methods
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Single? Add(Single? x, Single? y) => (Single?)(x + y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Single? Subtract(Single? x, Single? y) => (Single?)(x - y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Single? Multiply(Single? x, Single? y) => (Single?)(x * y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Single? Divide(Single? x, Single? y) => (Single?)(x / y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Single? AddChecked(Single? x, Single? y) => checked((Single?)(x + y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Single? SubtractChecked(Single? x, Single? y) => checked((Single?)(x - y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Single? MultiplyChecked(Single? x, Single? y) => checked((Single?)(x * y));
#endregion

#region Double methods
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Double Add(Double x, Double y) => (Double)(x + y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Double Subtract(Double x, Double y) => (Double)(x - y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Double Multiply(Double x, Double y) => (Double)(x * y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Double Divide(Double x, Double y) => (Double)(x / y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Double AddChecked(Double x, Double y) => checked((Double)(x + y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Double SubtractChecked(Double x, Double y) => checked((Double)(x - y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Double MultiplyChecked(Double x, Double y) => checked((Double)(x * y));
#endregion

#region Double? methods
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Double? Add(Double? x, Double? y) => (Double?)(x + y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Double? Subtract(Double? x, Double? y) => (Double?)(x - y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Double? Multiply(Double? x, Double? y) => (Double?)(x * y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Double? Divide(Double? x, Double? y) => (Double?)(x / y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Double? AddChecked(Double? x, Double? y) => checked((Double?)(x + y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Double? SubtractChecked(Double? x, Double? y) => checked((Double?)(x - y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Double? MultiplyChecked(Double? x, Double? y) => checked((Double?)(x * y));
#endregion

#region Decimal methods
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Decimal Add(Decimal x, Decimal y) => (Decimal)(x + y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Decimal Subtract(Decimal x, Decimal y) => (Decimal)(x - y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Decimal Multiply(Decimal x, Decimal y) => (Decimal)(x * y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Decimal Divide(Decimal x, Decimal y) => (Decimal)(x / y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Decimal AddChecked(Decimal x, Decimal y) => checked((Decimal)(x + y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Decimal SubtractChecked(Decimal x, Decimal y) => checked((Decimal)(x - y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Decimal MultiplyChecked(Decimal x, Decimal y) => checked((Decimal)(x * y));
#endregion

#region Decimal? methods
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Decimal? Add(Decimal? x, Decimal? y) => (Decimal?)(x + y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Decimal? Subtract(Decimal? x, Decimal? y) => (Decimal?)(x - y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Decimal? Multiply(Decimal? x, Decimal? y) => (Decimal?)(x * y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Decimal? Divide(Decimal? x, Decimal? y) => (Decimal?)(x / y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Decimal? AddChecked(Decimal? x, Decimal? y) => checked((Decimal?)(x + y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Decimal? SubtractChecked(Decimal? x, Decimal? y) => checked((Decimal?)(x - y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Decimal? MultiplyChecked(Decimal? x, Decimal? y) => checked((Decimal?)(x * y));
#endregion

#region Char methods
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Char Add(Char x, Char y) => (Char)(x + y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Char Subtract(Char x, Char y) => (Char)(x - y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Char Multiply(Char x, Char y) => (Char)(x * y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Char Divide(Char x, Char y) => (Char)(x / y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Char AddChecked(Char x, Char y) => checked((Char)(x + y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Char SubtractChecked(Char x, Char y) => checked((Char)(x - y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Char MultiplyChecked(Char x, Char y) => checked((Char)(x * y));
#endregion

#region Char? methods
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Char? Add(Char? x, Char? y) => (Char?)(x + y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Char? Subtract(Char? x, Char? y) => (Char?)(x - y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Char? Multiply(Char? x, Char? y) => (Char?)(x * y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Char? Divide(Char? x, Char? y) => (Char?)(x / y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Char? AddChecked(Char? x, Char? y) => checked((Char?)(x + y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Char? SubtractChecked(Char? x, Char? y) => checked((Char?)(x - y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Char? MultiplyChecked(Char? x, Char? y) => checked((Char?)(x * y));
#endregion

    }
}
