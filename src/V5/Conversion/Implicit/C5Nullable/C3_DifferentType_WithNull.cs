// ReSharper disable ExpressionIsAlwaysNull

namespace V5.Conversion.Implicit.C5Nullable
{
    public class C3_DifferentType_WithNull
    {
        public C3_DifferentType_WithNull()
        {
            int? a = null;
            long? a2 = a;

            int? b = null;
            // long b2 = a;
        }
    }
}