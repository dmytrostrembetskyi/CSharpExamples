namespace Basic.Topics.ClassConstructor.Examples
{
    public class PrivateWithNested
    {
        PrivateWithNested()
        {
        }

        public class Nested
        {
            public PrivateWithNested Create()
            {
                return new PrivateWithNested();
            }
        }
    }
}