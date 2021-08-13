using System;
using System.Collections;

namespace V5.Conversion.Implicit.C7Reference
{
    public class C7ArrayToSystemArray
    {
        public C7ArrayToSystemArray()
        {
            string[] a = { "a" };
            Array a2 = a;

            string[] b = { "a" };
            ICollection b2 = b;
        }
    }
}