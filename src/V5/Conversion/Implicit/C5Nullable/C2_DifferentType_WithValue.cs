// ReSharper disable SuggestVarOrType_BuiltInTypes

namespace V5.Conversion.Implicit.C5Nullable
{
    public class C2_DifferentType_WithValue
    {
        public C2_DifferentType_WithValue()
        {
            int? a = 1;
            long? a2 = a;

            int b = 1;
            long? b2 = b;
        }
    }
}