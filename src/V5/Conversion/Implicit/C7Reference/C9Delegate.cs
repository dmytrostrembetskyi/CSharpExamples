using System;
using System.Runtime.Serialization;

namespace V5.Conversion.Implicit.C7Reference
{
    public class C9Delegate
    {
        public C9Delegate()
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