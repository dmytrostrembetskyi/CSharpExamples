// ReSharper disable SuggestVarOrType_BuiltInTypes

namespace V3Runner
{
    internal class ImplicitNumericConversion_FromLitaral
    {
        public ImplicitNumericConversion_FromLitaral()
        {
            NoSufixLiteral();
        }

        static void NoSufixLiteral()
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