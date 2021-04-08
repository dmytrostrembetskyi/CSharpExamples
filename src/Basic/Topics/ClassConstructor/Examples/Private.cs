namespace Basic.Topics.ClassConstructor.Examples
{
    public class Private
    {
        private Private()
        {
        }

        private Private(int field1)
        {
        }

        public static Private Create()
        {
            return new();
        }

        public static Private Create(int parameter1)
        {
            return new(parameter1);
        }
    }
}