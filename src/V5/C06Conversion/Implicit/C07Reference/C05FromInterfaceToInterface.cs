namespace V5.C06Conversion.Implicit.C07Reference
{
    public class C05FromInterfaceToInterface
    {
        public C05FromInterfaceToInterface()
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