// ReSharper disable SuggestVarOrType_BuiltInTypes

namespace V3Runner
{
    internal class ImplicitNumericConversion
    {
        public ImplicitNumericConversion()
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
            decimal a = 1;

            // sbyte b = a;
            // byte c = a;
            // short d = a;
            // ushort e = a;
            // int f = a;
            // uint g = a;
            // long h = a;
            // ulong i = a;
            // nint j = a;
            // nuint k = a;

            // float l = a;
            // double m = a;
        }

        void Double()
        {
            double a = 1;

            // sbyte b = a;
            // byte c = a;
            // short d = a;
            // ushort e = a;
            // int f = a;
            // uint g = a;
            // long h = a;
            // ulong i = a;
            // nint j = a;
            // nuint k = a;

            // float l = a;
            // decimal n = a;
        }

        void Float()
        {
            float a = 1;

            // sbyte b = a;
            // byte c = a;
            // short d = a;
            // ushort e = a;
            // int f = a;
            // uint g = a;
            // long h = a;
            // ulong i = a;
            // nint j = a;
            // nuint k = a;

            double m = a;
            // decimal n = a;
        }

        void Nuint()
        {
            nuint a = 1;

            // sbyte b = a;
            // byte c = a;
            // short d = a;
            // ushort e = a;
            // int f = a;
            // uint g = a;
            // long h = a;
            ulong i = a;
            // nint j = a;

            float l = a;
            double m = a;
            decimal n = a;
        }

        void Nint()
        {
            nint a = 1;

            // sbyte b = a;
            // byte c = a;
            // short d = a;
            // ushort e = a;
            // int f = a;
            // uint g = a;
            long h = a;
            // ulong i = a;
            // nuint k = a;

            float l = a;
            double m = a;
            decimal n = a;
        }

        void Ulong()
        {
            ulong a = 1;

            // sbyte b = a;
            // byte c = a;
            // short d = a;
            // ushort e = a;
            // int f = a;
            // uint g = a;
            // long h = a;
            // nint j = a;
            // nuint k = a;

            float l = a;
            double m = a;
            decimal n = a;
        }

        void Long()
        {
            long a = 1;

            // sbyte b = a;
            // byte c = a;
            // short d = a;
            // ushort e = a;
            // int f = a;
            // uint g = a;
            // ulong i = a;
            // nint j = a;
            // nuint k = a;

            float l = a;
            double m = a;
            decimal n = a;
        }

        void Uint()
        {
            uint a = 1;

            // sbyte b = a;
            // byte c = a;
            // short d = a;
            // ushort e = a;
            // int f = a;
            long h = a;
            ulong i = a;
            // nint j = a;
            nuint k = a;

            float l = a;
            double m = a;
            decimal n = a;
        }

        void Int()
        {
            int a = 1;

            // sbyte b = a;
            // byte c = a;
            // short d = a;
            // ushort e = a;
            // uint g = a;
            long h = a;
            // ulong i = a;
            nint j = a;
            // nuint k = a;

            float l = a;
            double m = a;
            decimal n = a;
        }

        void Ushort()
        {
            ushort a = 1;

            // sbyte b = a;
            // byte c = a;
            // short d = a;
            int f = a;
            uint g = a;
            long h = a;
            ulong i = a;
            nint j = a;
            nuint k = a;

            float l = a;
            double m = a;
            decimal n = a;
        }

        void Short()
        {
            short a = 1;

            // sbyte b = a;
            // byte c = a;
            // ushort e = a;
            int f = a;
            // uint g = a;
            long h = a;
            // ulong i = a;
            nint j = a;
            // nuint k = a;

            float l = a;
            double m = a;
            decimal n = a;
        }

        void Byte()
        {
            byte a = 1;

            // sbyte b = a;
            short d = a;
            ushort e = a;
            int f = a;
            uint g = a;
            long h = a;
            ulong i = a;
            nint j = a;
            nuint k = a;

            float l = a;
            double m = a;
            decimal n = a;
        }

        static void Sbyte()
        {
            sbyte a = 1;

            // byte c = a;
            short d = a;
            // ushort e = a;
            int f = a;
            // uint g = a;
            long h = a;
            // ulong i = a;
            nint j = a;
            // nuint k = a;

            float l = a;
            double m = a;
            decimal n = a;
        }
    }
}