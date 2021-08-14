using System.Collections.Generic;

// ReSharper disable SuggestVarOrType_BuiltInTypes
// ReSharper disable SuggestVarOrType_Elsewhere

namespace V5.Conversion.Implicit.C07Reference
{
    public class C11Dynamic
    {
        public C11Dynamic()
        {
            List<object> a = new List<object>();
            List<dynamic> a2 = a;

            List<dynamic> b = new List<dynamic>();
            List<object> b2 = b;

            dynamic c = new object();
            object c2 = c;

            object d = new object();
            dynamic d2 = d;
        }
    }
}