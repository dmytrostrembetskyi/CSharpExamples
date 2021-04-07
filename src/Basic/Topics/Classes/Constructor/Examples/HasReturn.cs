namespace Basic.Topics.Classes.Constructor.Examples
{
    public class HasReturn
    {
        private int _field1;
        private int _field2;

        public HasReturn(int field1, int field2)
        {
            _field1 = field1;
            return;
            _field2 = field2;
        }
    }
}