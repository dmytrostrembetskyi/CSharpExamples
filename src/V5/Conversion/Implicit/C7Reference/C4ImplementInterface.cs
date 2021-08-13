// ReSharper disable SuggestVarOrType_SimpleTypes

namespace V5.Conversion.Implicit.C7Reference
{
    public class C4FromInterface
    {
        public C4FromInterface()
        {
            Class a = new Class();
            IInterface a2 = a;
        }
    }

    internal interface IInterface
    {
    }

    internal class Class : IInterface
    {
    }
}