namespace V5.C06Conversions.Implicit.C11TypeParameters
{
    public class C02EffectiveBaseClass
    {
        public C02EffectiveBaseClass()
        {
            var a1 = new OuterClass<InnerClassParent>();
            var a2 = new InnerClassChild();
            a1.Method(a2);
        }

        class InnerClassParent
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