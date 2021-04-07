namespace Basic.Topics.Classes.Constructor.Examples
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