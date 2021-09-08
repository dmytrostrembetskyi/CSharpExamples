// ReSharper disable SuggestVarOrType_SimpleTypes

namespace V5.C06Conversion.Implicit.C07Reference
{
    public class C04FromInterface
    {
        public C04FromInterface()
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