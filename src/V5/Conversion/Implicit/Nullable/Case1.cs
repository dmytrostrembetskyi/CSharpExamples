namespace V5.Conversion.Implicit.Nullable
{
    public class Case1
    {
        public Case1()
        {
            int a = 1;
            int? a2 = a;

            int? b = 1;
            // int b2 = b;
        }
    }
}