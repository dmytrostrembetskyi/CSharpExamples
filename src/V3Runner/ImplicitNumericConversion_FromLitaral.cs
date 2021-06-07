// ReSharper disable SuggestVarOrType_BuiltInTypes

namespace V3Runner
{
    internal class ImplicitNumericConversion_FromLitaral
    {
        public ImplicitNumericConversion_FromLitaral()
        {
            NoSufixIntegralLiteral();
            NoSuffixDoubleLiteral();
            FloatLiteral();
            DecimalLiteral();
        }

        void DecimalLiteral()
        {
            // sbyte a = 1.0m;
            // byte b = 1.0m;
            // short c = 1.0m;
            // ushort d = 1.0m;
            // int e = 1.0m;
            // uint m = 1.0m;
            // long g = 1.0m;
            // ulong h = 1.0m;
            // nint i = 1.0m;
            // nuint j = 1.0m;

            // float k = 1.0m;
            // double l = 1.0m;

            decimal m = 1.0m;
        }

        void FloatLiteral()
        {
            // sbyte a = 1.0f;
            // byte b = 1.0f;
            // short c = 1.0f;
            // ushort d = 1.0f;
            // int e = 1.0f;
            // uint f = 1.0f;
            // long g = 1.0f;
            // ulong h = 1.0f;
            // nint i = 1.0f;
            // nuint j = 1.0f;

            float k = 1.0f;
            float k2 = 340282349999999999999999999999999999999.0f;
            // float k3 = 340282359999999999999999999999999999999.0f;
            
            double l = 1.0f;
            double l2 = 340282349999999999999999999999999999999.0f;
            // double l3 = 340282359999999999999999999999999999999.0f;

            // decimal m = 1.0f;
        }

        void NoSuffixDoubleLiteral()
        {
            // sbyte a = 1.0;
            // byte b = 1.0;
            // short c = 1.0;
            // ushort d = 1.0;
            // int e = 1.0;
            // uint f = 1.0;
            // long g = 1.0;
            // ulong h = 1.0;
            // nint i = 1.0;
            // nuint j = 1.0;

            // float k = 1.0;
            double l = 1.0;
            double l2 =
                179769313486231579999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999.0;
            // double l3 =
            //  179769313486231589999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999.0;

            // decimal m = 1.0;
        }

        static void NoSufixIntegralLiteral()
        {
            sbyte a = 127;
            // sbyte a2 = 128;

            byte b = 255;
            // byte b2 = 256;

            short c = 32767;
            // short c2 = 32768;

            ushort d = 65535;
            // ushort d2 = 65536;

            int e = 2147483647;
            // int e2 = 2147483648;

            uint f = 4294967295;
            // uint f2 = 4294967296;

            long g = 9223372036854775807;
            // long g2 = 9223372036854775808;

            ulong h = 18446744073709551615;
            // ulong h2 = 18446744073709551616;

            nint i = 2147483647;
            // nint i2 = 2147483648;

            nuint j = 4294967295;
            // nuint j2 = 4294967296;

            float k = 18446744073709551615;
            // float k2 = 18446744073709551616;

            double l = 18446744073709551615;
            // double l2 = 18446744073709551616;

            decimal m = 18446744073709551615;
            // decimal m2 = 18446744073709551616;
        }
    }
}