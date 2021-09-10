using System;
using System.Diagnostics;

namespace V5.C06Conversions.Implicit.C09Dynamic
{
    public class C03CanBeChangedToAnyType
    {
        public C03CanBeChangedToAnyType()
        {
            dynamic a1 = 1.0;
            a1 = "hello";

            dynamic a2 = 1;
            a2 = 10L;
        }
    }
}