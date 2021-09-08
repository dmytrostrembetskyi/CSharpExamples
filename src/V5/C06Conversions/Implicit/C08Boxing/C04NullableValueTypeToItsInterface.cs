using System;

// ReSharper disable ConvertNullableToShortForm
// ReSharper disable ExpressionIsAlwaysNull

namespace V5.C06Conversions.Implicit.C08Boxing
{
    public class C04NullableValueTypeToItsInterface
    {
        public C04NullableValueTypeToItsInterface()
        {
            int? a = 1;
            IConvertible a2 = a;

            int? b = null;
            IConvertible b2 = b;

            Nullable<int> c = 1;
            IConvertible c2 = c;
        }
    }
}