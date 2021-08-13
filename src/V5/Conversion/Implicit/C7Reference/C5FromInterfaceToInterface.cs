namespace V5.Conversion.Implicit.C7Reference
{
    public class C5FromInterfaceToInterface
    {
        public C5FromInterfaceToInterface()
        {
            IChild a = new Class();
            IParent a2 = a;
        }

        interface IParent
        {
        }

        interface IChild : IParent
        {
        }

        class Class : IChild
        {
        }
    }
}