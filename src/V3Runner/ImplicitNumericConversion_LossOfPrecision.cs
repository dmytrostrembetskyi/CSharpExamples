// ReSharper disable SuggestVarOrType_BuiltInTypes

using System;

namespace V3Runner
{
    internal class ImplicitNumericConversion_LossOfPrecision
    {
        public ImplicitNumericConversion_LossOfPrecision()
        {
            Sbyte();
            Byte();
            Short();
            Ushort();
            Int();
            Uint();
            Long();
            Ulong();
            Nint();
            Nuint();

            Float();

            Double();
            Decimal();
        }

        void Decimal()
        {
            decimal a = decimal.MaxValue;
        }

        void Double()
        {
            double a = double.MaxValue;
            var a2 = $"{a:N}";
        }

        void Float()
        {
            float a = float.MaxValue;
            var a2 = $"{a:N}";

            double m = a;
            var m2 = $"{m:N}";
        }

        void Nuint()
        {
            nuint a = UIntPtr.MaxValue;
            var a2 = $"{a:N}";

            ulong i = a;

            float l = a;
            double m = a;

            decimal n = a;
        }

        void Nint()
        {
            nint a = IntPtr.MaxValue;
            var a2 = $"{a:N}";

            long h = a;

            float l = a;
            var l2 = $"{l:N}";
            double m = a;
            var m2 = $"{m:N}";
            decimal n = a;
        }

        void Ulong()
        {
            ulong a = ulong.MaxValue;

            float l = a;
            var l2 = $"{l:N}";
            double m = a;
            var m2 = $"{m:N}";
            decimal n = a;
        }

        void Long()
        {
            long a = long.MaxValue;

            float l = a;
            var l2 = $"{l:N}";
            double m = a;
            var m2 = $"{m:N}";
            decimal n = a;
        }

        void Uint()
        {
            uint a = uint.MaxValue;

            long h = a;
            ulong i = a;
            nuint k = a;
            var k2 = k.ToString();

            float l = a;
            var l2 = $"{l:N}";
            double m = a;
            decimal n = a;
        }

        void Int()
        {
            int a = int.MaxValue;

            long h = a;
            nint j = a;
            var j2 = j.ToString();

            float l = a;
            var l2 = $"{l:N}";
            double m = a;
            decimal n = a;
        }

        void Ushort()
        {
            ushort a = ushort.MaxValue;

            int f = a;
            uint g = a;
            long h = a;
            ulong i = a;
            nint j = a;
            var j2 = j.ToString();
            nuint k = a;
            var k2 = j.ToString();

            float l = a;
            double m = a;
            decimal n = a;
        }

        void Short()
        {
            short a = short.MaxValue;

            int f = a;
            long h = a;
            nint j = a;
            var j2 = j.ToString();

            float l = a;
            double m = a;
            decimal n = a;
        }

        void Byte()
        {
            byte a = byte.MaxValue;

            short d = a;
            ushort e = a;
            int f = a;
            uint g = a;
            long h = a;
            ulong i = a;
            nint j = a;
            var j2 = j.ToString();
            nuint k = a;
            var k2 = j.ToString();

            float l = a;
            double m = a;
            decimal n = a;
        }

        static void Sbyte()
        {
            sbyte a = sbyte.MaxValue;

            short d = a;
            int f = a;
            long h = a;
            nint j = a;
            var j2 = j.ToString();

            float l = a;
            double m = a;
            decimal n = a;
        }
    }
}