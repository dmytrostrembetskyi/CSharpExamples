// ReSharper disable SuggestVarOrType_BuiltInTypes

namespace V5.Conversion.Implicit.Nullable
{
    public class C1_SameType
    {
        public C1_SameType()
        {
            int a = 1;
            int? a2 = a;

            int? b = 1;
            // int b2 = b;
        }
    }
}