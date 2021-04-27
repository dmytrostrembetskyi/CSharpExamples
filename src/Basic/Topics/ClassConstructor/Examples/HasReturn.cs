// ReSharper disable NotAccessedField.Local

namespace Basic.Topics.ClassConstructor.Examples
{
    public class HasReturn
    {
        int _field1;

        public HasReturn(int field1, int field2)
        {
            _field1 = field1;
            return;
            _field1 = field2;
        }
    }
}