// ReSharper disable SuggestVarOrType_BuiltInTypes
// ReSharper disable ConvertToConstant.Local

namespace V5.C06Conversion.Implicit.C05Nullable
{
    public class C2DifferentTypeWithValue
    {
        public C2DifferentTypeWithValue()
        {
            int? a = 1;
            long? a2 = a;

            int b = 1;
            long? b2 = b;
        }
    }
}