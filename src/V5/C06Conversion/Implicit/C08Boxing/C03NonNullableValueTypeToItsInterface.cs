using System;

// ReSharper disable SuggestVarOrType_BuiltInTypes

namespace V5.C06Conversion.Implicit.C08Boxing
{
    public class C03NonNullableValueTypeToItsInterface
    {
        public C03NonNullableValueTypeToItsInterface()
        {
            int a = 1;
            IFormattable a2 = a;
        }
    }
}