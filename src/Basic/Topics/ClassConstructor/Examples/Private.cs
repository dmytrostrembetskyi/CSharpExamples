namespace Basic.Topics.ClassConstructor.Examples
{
    public class Private
    {
        private int field1;
        private int field2;

        private Private()
        {
        }

        private Private(int field1)
        {
            this.field1 = field1;
        }

        private Private(int field1, int field2)
        {
            this.field1 = field1;
            this.field2 = field2;
        }

        public static Private Create()
        {
            return new();
        }

        public static Private Create(int parameter1)
        {
            var reference = new Private(parameter1);
            return reference;
        }

        public static Private Create(int parameter1, int parameter2)
        {
            return new(parameter1, parameter2);
        }
    }
}