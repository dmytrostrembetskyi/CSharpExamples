using System;
using System.Runtime.Serialization;

namespace V5.C06Conversion.Implicit.C07Reference
{
    public class C09Delegate
    {
        public C09Delegate()
        {
            DelegateExample a = Method;
            Delegate a2 = a;

            DelegateExample b = Method;
            ICloneable b2 = b;

            DelegateExample c = Method;
            ISerializable c2 = c;
        }

        void Method()
        {
        }

        delegate void DelegateExample();
    }
}