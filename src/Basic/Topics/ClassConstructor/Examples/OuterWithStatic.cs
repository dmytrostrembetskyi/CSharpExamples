// ReSharper disable MemberHidesStaticFromOuterClass
// ReSharper disable NotAccessedField.Local

#pragma warning disable 414
namespace Basic.Topics.ClassConstructor.Examples
{
    public class OuterWithStatic
    {
        static int _field2;
        int _field1;

        static OuterWithStatic()
        {
            _field2 = 1;
        }

        public OuterWithStatic(int field1)
        {
            _field1 = field1;
        }

        public class InnerWithStatic
        {
            static int _field2;
            int _field1;

            static InnerWithStatic()
            {
                _field2 = 1;
            }

            public InnerWithStatic(int field1)
            {
                _field1 = field1;
            }
        }
    }
}