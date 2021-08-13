using V5.Utils;

// ReSharper disable SuggestVarOrType_SimpleTypes

namespace V5.Conversion.Implicit.C7Reference
{
    public class C3Derived
    {
        public C3Derived()
        {
            SimpleChild a = new SimpleChild();
            SimpleParent a2 = a;
        }
    }
}