using System;
using System.Collections;

namespace V5.C06Conversion.Implicit.C07Reference
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