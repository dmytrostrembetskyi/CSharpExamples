// ReSharper disable NotAccessedField.Local

#pragma warning disable 169
namespace Basic.Topics.ClassConstructor.Examples
{
    public class WithParameters
    {
        int _field1;
        int _field2;
        int _field3;

        public WithParameters(int field1)
        {
            _field1 = field1;
        }

        // public WithParameters(int field1)
        // {
        //     this.field1 = field1;
        // }

        public WithParameters(int field1, int field2)
        {
            _field1 = field1;
            _field2 = field2;
        }
    }
}