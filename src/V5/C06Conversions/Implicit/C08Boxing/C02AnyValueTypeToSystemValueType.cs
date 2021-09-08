using System;

// ReSharper disable SuggestVarOrType_BuiltInTypes
// ReSharper disable SuggestVarOrType_SimpleTypes
// ReSharper disable ConditionIsAlwaysTrueOrFalse

namespace V5.C06Conversions.Implicit.C08Boxing
{
    public class C02AnyValueTypeToSystemValueType
    {
        public C02AnyValueTypeToSystemValueType()
        {
            sbyte a = 1;
            ValueType a2 = a;

            byte b = 1;
            ValueType b2 = b;

            short c = 1;
            ValueType c2 = c;

            ushort d = 1;
            ValueType d2 = d;

            int e = 1;
            ValueType e2 = e;

            uint f = 1;
            ValueType f2 = f;

            long g = 1;
            ValueType g2 = g;

            ulong h = 1;
            ValueType h2 = h;

            float i = 1;
            ValueType i2 = i;

            double j = 1;
            ValueType j2 = j;

            decimal k = 1;
            ValueType k2 = k;

            char l = '1';
            ValueType l2 = l;

            bool m = true;
            ValueType m2 = m;

            DateTime n = DateTime.Now;
            ValueType n2 = n;

            Guid o = new Guid();
            ValueType o2 = o;
        }
    }
}