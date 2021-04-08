namespace Basic.Topics.ClassConstructor.Examples
{
    public class InitializeReadonly
    {
        private static readonly int _field2;
        private readonly int _field;

        static InitializeReadonly()
        {
            _field2 = 1;
        }

        public InitializeReadonly(int field)
        {
            _field = field;
        }
    }
}