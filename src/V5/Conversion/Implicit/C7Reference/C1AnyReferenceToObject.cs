using System;
using System.Text;

// ReSharper disable BuiltInTypeReferenceStyle

namespace V5.Conversion.Implicit.C7Reference
{
    public class C1AnyReferenceToObject
    {
        public C1AnyReferenceToObject()
        {
            var a = new String("Hello");
            object a2 = a;

            var b = new StringBuilder();
            object b2 = b;
        }
    }
}