namespace Basic.Topics.ClassConstructor.Examples
{
    public class PrivateWithNested
    {
        private PrivateWithNested()
        {
        }

        public class Nested
        {
            public PrivateWithNested Create()
            {
                return new();
            }
        }
    }
}