using System.Collections.Generic;

// ReSharper disable SuggestVarOrType_BuiltInTypes
// ReSharper disable CoVariantArrayConversion

namespace V5.C06Conversion.Implicit.C07Reference
{
    public class C08ArrayToIList
    {
        public C08ArrayToIList()
        {
            string[] a = { "q" };
            IList<object> a2 = a;

            string[,] b = new string[1, 2];
            // IList<object> b2 = b;

            string[] c = { "q" };
            IList<string> c2 = c;

            string[] d = { "q" };
            IEnumerable<object> d2 = d;
        }
    }
}