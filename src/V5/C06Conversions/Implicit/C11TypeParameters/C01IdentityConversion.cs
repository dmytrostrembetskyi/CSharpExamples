namespace V5.C06Conversions.Implicit.C11TypeParameters
{
    public class C01IdentityConversion
    {
        public C01IdentityConversion()
        {
            var a1 = new OuterClass<InnerClass>();
            var a2 = new InnerClass();
            a1.Method(a2);
        }

        class InnerClass
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