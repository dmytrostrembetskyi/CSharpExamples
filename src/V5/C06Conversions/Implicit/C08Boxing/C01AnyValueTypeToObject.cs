using System;

// ReSharper disable ConditionIsAlwaysTrueOrFalse
// ReSharper disable SuggestVarOrType_BuiltInTypes
// ReSharper disable SuggestVarOrType_SimpleTypes

namespace V5.C06Conversions.Implicit.C08Boxing
{
    public class C01AnyValueTypeToObject
    {
        public C01AnyValueTypeToObject()
        {
            sbyte a = 1;
            object a2 = a;

            byte b = 1;
            object b2 = b;

            short c = 1;
            object c2 = c;

            ushort d = 1;
            object d2 = d;

            int e = 1;
            object e2 = e;

            uint f = 1;
            object f2 = f;

            long g = 1;
            object g2 = g;

            ulong h = 1;
            object h2 = h;

            float i = 1;
            object i2 = i;

            double j = 1;
            object j2 = j;

            decimal k = 1;
            object k2 = k;

            char l = '1';
            object l2 = l;

            bool m = true;
            object m2 = m;

            DateTime n = DateTime.Now;
            object n2 = n;

            Guid o = new Guid();
            object o2 = o;
        }
    }
}