// ReSharper disable MemberHidesStaticFromOuterClass

namespace Basic.Topics.ClassConstructor.Examples
{
    public static class OuterStaticClass
    {
        public static int Field;

        static OuterStaticClass()
        {
            Field = 1;
        }

        public static class InnerStaticClass
        {
            public static int Field;

            static InnerStaticClass()
            {
                Field = 1;
            }
        }
    }
}