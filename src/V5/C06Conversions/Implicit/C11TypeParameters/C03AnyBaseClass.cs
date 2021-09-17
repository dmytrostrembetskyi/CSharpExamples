namespace V5.C06Conversions.Implicit.C11TypeParameters
{
    public class C03AnyBaseClass
    {
        public C03AnyBaseClass()
        {
            var a1 = new OuterClass<InnerClassGrandparent>();
            var a2 = new InnerClassChild();
            a1.Method(a2);
        }

        class InnerClassGrandparent
        {
        }

        class InnerClassParent : InnerClassGrandparent
        {
        }

        class InnerClassChild : InnerClassParent
        {
        }

        class OuterClass<T>
        {
            public void Method(T t)
            {
            }
        }
    }
}