// ReSharper disable SuggestVarOrType_Elsewhere

namespace V5.Conversion.Implicit.C7Reference
{
    public class C14TypeParameters
    {
        public C14TypeParameters()
        {
            Child<string> a = new Child<string>();
            Parent<string> a2 = a;
        }

        class Parent<T>
        {
        }

        class Child<T> : Parent<T>
        {
        }
    }
}