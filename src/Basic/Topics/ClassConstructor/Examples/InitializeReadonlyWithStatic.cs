namespace Basic.Topics.ClassConstructor.Examples
{
    public class InitializeReadonlyWithStatic
    {
        private static readonly int _field2;
        private readonly int _field;

        static InitializeReadonlyWithStatic()
        {
            _field2 = 1;
        }

        public InitializeReadonlyWithStatic(int field)
        {
            _field = field;
        }
    }
}