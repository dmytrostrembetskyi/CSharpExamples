namespace V5.C06Conversions.Implicit.C10ConstantExpression
{
    public class C01NumericSByte
    {
        public C01NumericSByte()
        {
            const sbyte a1 = 1;

            // const byte a2 = a1;
            const short a3 = a1;
            // const ushort a4 = a1;
            const int a5 = a1;
            // const uint a6 = a1;
            const long a7 = a1;
            // const ulong a8 = a1;
            const nint a9 = a1;
            // const nuint a10 = a1;

            const float b1 = a1;
            const double b2 = a1;
            const decimal b3 = a1;
        }
    }
}