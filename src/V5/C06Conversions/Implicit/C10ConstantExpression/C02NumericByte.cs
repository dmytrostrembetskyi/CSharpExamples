namespace V5.C06Conversions.Implicit.C10ConstantExpression
{
    public class C02NumericByte
    {
        public C02NumericByte()
        {
            const byte a = 1;

            // const sbyte b = a;
            const short d = a;
            const ushort e = a;
            const int f = a;
            const uint g = a;
            const long h = a;
            const ulong i = a;
            const nint j = a;
            const nuint k = a;

            const float l = a;
            const double m = a;
            const decimal n = a;
        }
    }
}