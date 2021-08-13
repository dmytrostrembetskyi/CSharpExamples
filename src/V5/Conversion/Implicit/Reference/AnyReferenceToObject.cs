namespace V5.Conversion.Implicit.Reference
{
    public class AnyReferenceToObject
    {
        public AnyReferenceToObject()
        {
            var a = new string("Hello");
            object a2 = a;

            var b = new byte();
            object b2 = b;
        }
    }
}