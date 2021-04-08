namespace Basic.Topics.ClassConstructor.Examples
{
    public class OuterWithStatic
    {
        private static int _field2;
        private int _field1;

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
            private static int _field2;
            private int _field1;

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