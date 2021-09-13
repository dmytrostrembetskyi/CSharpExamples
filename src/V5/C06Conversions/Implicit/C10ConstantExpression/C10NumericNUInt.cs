namespace V5.C06Conversions.Implicit.C10ConstantExpression
{
    public class C10NumericNUInt
    {
        public C10NumericNUInt()
        {
            const nuint a = 1;

            // const sbyte b = a;
            // const byte c = a;
            // const short d = a;
            // const ushort e = a;
            // const int f = a;
            // const uint g = a;
            // const long h = a;
            const ulong i = a;
            // const nint j = a;

            const float l = a;
            const double m = a;
            const decimal n = a;
        }
    }
}