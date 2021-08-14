using V5.Utils;

// ReSharper disable SuggestVarOrType_SimpleTypes

namespace V5.Conversion.Implicit.C7Reference
{
    public class C03Derived
    {
        public C03Derived()
        {
            SimpleChild a = new SimpleChild();
            SimpleParent a2 = a;
        }
    }
}