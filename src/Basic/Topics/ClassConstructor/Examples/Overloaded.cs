namespace Basic.Topics.ClassConstructor.Examples
{
    public class Overloaded
    {
        private int _field1;
        private int _field2;

        public Overloaded(int field1)
        {
            _field1 = field1;
        }

        public Overloaded(int field1, int field2) : this(field1)
        {
            _field2 = field2;
        }
    }
}