namespace Basic.Topics.Classes.Constructor
{
    public class Private
    {
        private Private()
        {
        }

        private Private(int parameter1)
        {
        }

        private Private(int parameter1, int parameter2)
        {
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