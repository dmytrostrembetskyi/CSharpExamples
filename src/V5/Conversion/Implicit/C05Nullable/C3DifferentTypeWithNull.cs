// ReSharper disable ExpressionIsAlwaysNull

namespace V5.Conversion.Implicit.C05Nullable
{
    public class C3DifferentTypeWithNull
    {
        public C3DifferentTypeWithNull()
        {
            int? a = null;
            long? a2 = a;

            int? b = null;
            // long b2 = a;
        }
    }
}