namespace V3Runner
{
    internal class ImplicitIdentityConversion
    {
        public ImplicitIdentityConversion()
        {
            AnyTypeToSameType();
            Dynamic();
        }

        void Dynamic()
        {
            dynamic a = 1;
            var b = a;
            a = "o";
            var c = a;
        }

        void AnyTypeToSameType()
        {
            var a = 1;
            var b = a;

            var c = "o";
            var d = c;

            var e = new object();
            var f = e;
        }
    }
}