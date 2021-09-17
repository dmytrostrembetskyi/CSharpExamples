namespace V5.C06Conversions.Implicit.C11TypeParameters
{
    public class C04AnyInterface
    {
        public C04AnyInterface()
        {
            var a1 = new OuterClass<IInnerInterface>();
            var a2 = new InnerClass();
            a1.Method(a2);
        }

        interface IInnerInterface
        {
        }

        class InnerClass : IInnerInterface
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