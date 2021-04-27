namespace Basic.Topics.ClassConstructor.Examples
{
    public class HasReturn
    {
        int _field1;
        int _field2;

        public HasReturn(int field1, int field2)
        {
            _field1 = field1;
            return;
            _field2 = field2;
        }
    }
}