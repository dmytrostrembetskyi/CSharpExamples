using System;
using System.Collections;

namespace V5.Conversion.Implicit.C7Reference
{
    public class C07ArrayToSystemArray
    {
        public C07ArrayToSystemArray()
        {
            string[] a = { "a" };
            Array a2 = a;

            string[] b = { "a" };
            ICollection b2 = b;
        }
    }
}