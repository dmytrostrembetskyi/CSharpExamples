// ReSharper disable NotAccessedField.Local

#pragma warning disable 414
namespace Basic.Topics.ClassConstructor.Examples
{
    public class InitializeReadonlyWithStatic
    {
        static readonly int Field2;
        readonly int _field;

        static InitializeReadonlyWithStatic()
        {
            Field2 = 1;
        }

        public InitializeReadonlyWithStatic(int field)
        {
            _field = field;
        }
    }
}