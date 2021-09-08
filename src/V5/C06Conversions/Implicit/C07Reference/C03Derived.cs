// ReSharper disable SuggestVarOrType_SimpleTypes

namespace V5.C06Conversions.Implicit.C07Reference
{
    public class C03Derived
    {
        public C03Derived()
        {
            Child a = new Child();
            Parent a2 = a;
        }

        class Parent
        {
        }

        class Child : Parent
        {
        }
    }
}