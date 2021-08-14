using System;
using System.Text;

// ReSharper disable BuiltInTypeReferenceStyle

namespace V5.Conversion.Implicit.C7Reference
{
    public class C01AnyReferenceToObject
    {
        public C01AnyReferenceToObject()
        {
            var a = new String("Hello");
            object a2 = a;

            var b = new StringBuilder();
            object b2 = b;
        }
    }
}